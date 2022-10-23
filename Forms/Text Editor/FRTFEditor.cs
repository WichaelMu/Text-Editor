using static global::UForm;

namespace MTextEditor
{
	public partial class FEditor
	{

		FontStyle ActiveStyles = FontStyle.Regular;

		void Bold()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Bold, "Bold");

			XORFontStyle(FontStyle.Bold);

			SetExtension(0);
		}

		void Underline()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Underline, "Underline");

			XORFontStyle(FontStyle.Underline);

			SetExtension(0);
		}

		void Italics()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Italics, "Italics");

			XORFontStyle(FontStyle.Italic);

			SetExtension(0);
		}

		/// <summary>Invert or apply fonts without losing styles.</summary>
		/// <remarks>A more elegant method than: https://discord.com/channels/998461292237041785/1013962427383173242/1033513163250991255</remarks>
		/// <param name="InStyle">The font to apply or invert.</param>
		void XORFontStyle(FontStyle InStyle)
		{
			UpdateBUIGraphics(InStyle);

			int End = RTextArea.SelectedText.Length;

			if (End != 0)
			{
				int Insert = RTextArea.SelectionStart;

				while (RTextArea.SelectionStart < End + Insert)
				{
					RTextArea.SelectionLength = 1;
					RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(InStyle));
					++RTextArea.SelectionStart;
				}

				RTextArea.SelectionStart = Insert;
				RTextArea.SelectionLength = End;
			}
		}

		/// <summary>Updates the Checked value of the Bold, Underline, and Italics icons in <see cref="FEditor"/>.</summary>
		/// <param name="InStyle">The style/s to mark as Checked.</param>
		void UpdateBUIGraphics(FontStyle InStyle)
		{
			// Bit magic.
			// Flip-flop the Styles and Mask to Bold, Underline, and Italics.
			ActiveStyles ^= InStyle;
			ActiveStyles &= (FontStyle)7;

			byte Byte = (byte)ActiveStyles;

			switch (Byte)
			{
				case 1: // Bold.
					TSBold.Checked = true;
					TSUnderline.Checked = false;
					TSItalics.Checked = false;
					break;
				case 2: // Italics.
					TSBold.Checked = false;
					TSItalics.Checked = true;
					TSUnderline.Checked = false;
					break;
				case 3: // Bold + Italics
					TSBold.Checked = true;
					TSItalics.Checked = true;
					TSUnderline.Checked = false;
					break;
				case 4: // Underline
					TSBold.Checked = false;
					TSItalics.Checked = false;
					TSUnderline.Checked = true;
					break;
				case 5: // Bold + Underline.
					TSBold.Checked = true;
					TSItalics.Checked = false;
					TSUnderline.Checked = true;
					break;
				case 6: // Italics + Underline.
					TSBold.Checked = false;
					TSItalics.Checked = true;
					TSUnderline.Checked = true;
					break;
				case 7: // All.
					TSBold.Checked = true;
					TSUnderline.Checked = true;
					TSItalics.Checked = true;
					break;
				case 0: // None or Fail.
				default:
					TSBold.Checked = TSUnderline.Checked = TSItalics.Checked = false;
					break;
			}
		}

		FontStyle SetOrInvertStyle(FontStyle Style) => RTextArea.SelectionFont.Style ^ Style;

		Font GetCurrentFont() => RTextArea.SelectionFont;

		void AdjustFontSize(int InSize)
		{
			if (RTextArea.SelectedText.Length > 0)
			{
				Font SelectedFont = RTextArea.SelectionFont;
				RTextArea.SelectionFont = new Font(SelectedFont.Name, InSize, SelectedFont.Style);

				SetExtension(0);
			}
		}

		/// <summary>Adjust the typeface to the set <see cref="TSFontSize"/> whilst typing.</summary>
		/// <param name="Delta">The difference in <see cref="RTextArea.Text"/>'s length between the last keystroke and this keystroke.</param>
		void HandleRollingFontSize(int Delta)
		{
			// We're not rolling if we've got text selected or the Delta is NOT 1.
			// The Delta must be 1 if we're normally typing. In any other case it means we're Cutting or Pasting. Negative
			// values mean backspacing.
			if (Delta == 1 && RTextArea.Text.Length > 0 && GetFontSize(out int FontSize) && RTextArea.SelectedText.Length == 0)
			{
				int Start = RTextArea.SelectionStart;
				int End = RTextArea.SelectedText.Length;

				// Set the insertion point back one, and highlight the character that was just entered.
				if (RTextArea.SelectionStart > 0)
					--RTextArea.SelectionStart;
				RTextArea.SelectionLength = 1;

				// Adjust the font size of the new character.
				AdjustFontSize(FontSize);

				// Reset the insertion point to forward one, and deselect the highlight.
				++RTextArea.SelectionStart;
				RTextArea.SelectionLength = 0;

				SetExtension(0);

				RTextArea.SelectionStart = Start;
				RTextArea.SelectionLength = End;
			}
		}

		/// <summary>Gets the Font Size as shown in <see cref="TSFontSize"/>.</summary>
		/// <param name="FontSize">An <see langword="out"/> <see langword="int"/> for the parsed Font Size.</param>
		/// <returns><see langword="true"/> if the value in <see cref="TSFontSize"/> can be parsed as a number.</returns>
		bool GetFontSize(out int FontSize) => int.TryParse(TSFontSize.Text, out FontSize);

		/// <summary>Adjust the typeface to the selected Bold, Underline, and/or Italics selection whilst typing.</summary>
		/// <param name="Delta">The difference in <see cref="RTextArea.Text"/>'s length between the last keystroke and this keystroke.</param>
		void HandleRollingBUI(int Delta)
		{
			// We're not rolling if we've got text selected or the Delta is NOT 1.
			// The Delta must be 1 if we're normally typing. In any other case it means we're Cutting or Pasting. Negative
			// values mean backspacing.
			if (Delta == 1 && RTextArea.Text.Length > 0 && RTextArea.SelectedText.Length == 0)
			{
				// Set the insertion point back one, and highlight the character that was just entered.
				if (RTextArea.SelectionStart > 0)
					--RTextArea.SelectionStart;
				RTextArea.SelectionLength = 1;

				// Adjust the Text Decorations of the new character.
				RTextArea.SelectionFont = new Font(GetCurrentFont(), ActiveStyles);

				// Reset the insertion point to forward one, and deselect the highlight.
				++RTextArea.SelectionStart;
				RTextArea.SelectionLength = 0;
				
				// Set RTF only when there a BUI has been activated.
				if (((byte)ActiveStyles & 7) != 0)
					SetExtension(0);
			}
		}
	}
}