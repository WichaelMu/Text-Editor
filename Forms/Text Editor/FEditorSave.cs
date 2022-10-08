using System.Text;
using IO;
using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Save()
		{
			if (string.IsNullOrEmpty(CurrentyOpenedFile))
			{
				SaveAs();
			}
			else
			{
				Print(this, Save, "Save");

				SaveRTextAreaToFile(CurrentyOpenedFile);
				UnsavedChangesTracker = RTextArea.Text.GetHashCode();
			}

			UpdateTitle();
		}

		void SaveAs()
		{
			Print(this, SaveAs, "Save As");

			if (FileExplorer("Save As", ref CurrentyOpenedFile, false))
			{
				SaveRTextAreaToFile(CurrentyOpenedFile);

				UnsavedChangesTracker = RTextArea.Text.GetHashCode();
			}

			UpdateTitle();
		}

		async void SaveRTextAreaToFile(string Path)
		{
			await FileSystem.WriteToFile("", Path, EWriteMode.Overwrite, Encoding.UTF8, RTextArea.Text);
		}
	}
}
