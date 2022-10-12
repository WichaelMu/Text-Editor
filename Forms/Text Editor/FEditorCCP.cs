using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Cut()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

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
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, Paste, "Paste");

			RTextArea.Paste();
		}
	}
}
