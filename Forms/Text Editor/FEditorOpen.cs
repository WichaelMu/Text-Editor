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
				string PreOpenFilie = CurrentyOpenedFile;

				if (FileExplorer("Open", ref CurrentyOpenedFile, true))
				{
					if (PreOpenFilie != CurrentyOpenedFile)
						Clear();

					int Extension = FileSystem.GetExtension(CurrentyOpenedFile);
					RTextArea.LoadFile(CurrentyOpenedFile, (RichTextBoxStreamType)Extension);
					UnsavedChangesTracker = RTextArea.Text.GetHashCode();

					SetExtension(Extension);
				}


				UpdateTitle();
			}
		}
	}
}
