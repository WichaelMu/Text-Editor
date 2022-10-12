using static global::UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Bold()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Bold, "Bold");

			RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(FontStyle.Bold));

			SetExtension(0);
		}

		void Underline()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Underline, "Underline");

			RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(FontStyle.Underline));

			SetExtension(0);
		}

		void Italics()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Italics, "Italics");

			RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(FontStyle.Italic));

			SetExtension(0);
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

		void HandleRollingFontSize()
		{
			if (RTextArea.Text.Length > 0 && GetFontSize(out int FontSize))
			{
				// Set the insertion point back one, and highlight the character that was just entered.
				--RTextArea.SelectionStart;
				RTextArea.SelectionLength = 1;

				// Adjust the font size of the new character.
				AdjustFontSize(FontSize);

				// Reset the insertion point to forward one, and deselect the highlight.
				++RTextArea.SelectionStart;
				RTextArea.SelectionLength = 0;

				SetExtension(0);
			}
		}

		bool GetFontSize(out int FontSize) => int.TryParse(TSFontSize.Text, out FontSize);
	}
}