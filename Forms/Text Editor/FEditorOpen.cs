using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Open()
		{
			Print(this, Open, "Open");

			CheckAndAskForUnsaved();

			if (FileExplorer("Open", ref CurrentyOpenedFile, true))
			{
				int Extension = CurrentyOpenedFile.Split('.')[^1] == "rtf" ? 0 : 1;
				RTextArea.LoadFile(CurrentyOpenedFile, (RichTextBoxStreamType)Extension);
				UnsavedChangesTracker = RTextArea.Text.GetHashCode();
			}

			UpdateTitle();
		}
	}
}
