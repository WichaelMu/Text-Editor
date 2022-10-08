using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Cut()
		{
			Print(this, Cut, "Cut");

			if (RTextArea.SelectionLength > 0)
				RTextArea.Cut();
		}

		void Copy()
		{
			Print(this, Copy, "Copy");

			if (RTextArea.SelectionLength > 0)
				RTextArea.Copy();
		}

		void Paste()
		{
			Print(this, Paste, "Paste");

			RTextArea.Paste();
		}
	}
}
