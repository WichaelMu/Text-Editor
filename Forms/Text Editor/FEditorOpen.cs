using IO;
using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Open()
		{
			Print(this, Open, "Open");

			if (CheckAndAskForUnsaved())
			{
				string PreOpenFilie = CurrentlyOpenedFile;

				if (FileExplorer("Open", ref CurrentlyOpenedFile, true))
				{
					if (PreOpenFilie != CurrentlyOpenedFile)
						Clear();

					int Extension = FileSystem.GetExtension(CurrentlyOpenedFile);
					RTextArea.LoadFile(CurrentlyOpenedFile, (RichTextBoxStreamType)Extension);
					UnsavedChangesTracker = RTextArea.Text.GetHashCode();

					SetExtension(Extension);
				}

				UpdateTitle();
			}
		}
	}
}
