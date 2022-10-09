using static global::UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Bold()
		{
			Print(this, Bold, "Bold");

			RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(FontStyle.Bold));

			SetExtension(0);
		}

		void Underline()
		{
			Print(this, Underline, "Underline");

			RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(FontStyle.Underline));

			SetExtension(0);
		}

		void Italics()
		{
			Print(this, Italics, "Italics");

			RTextArea.SelectionFont = new Font(GetCurrentFont(), SetOrInvertStyle(FontStyle.Italic));

			SetExtension(0);
		}

		FontStyle SetOrInvertStyle(FontStyle Style) => RTextArea.SelectionFont.Style ^ Style;

		Font GetCurrentFont() => RTextArea.SelectionFont;
	}
}
