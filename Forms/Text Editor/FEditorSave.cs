using System.Text;
using IO;
using static IO.FileSystem;
using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		/// <summary>Saves the <see cref="CurrentlyOpenedFile"/> or <see cref="SaveAs"/> if no file exists.</summary>
		void Save()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			if (string.IsNullOrEmpty(CurrentlyOpenedFile))
			{
				SaveAs();
			}
			else
			{
				Print(this, Save, "Save");

				SaveRTextAreaToFile(CurrentlyOpenedFile);
				UnsavedChangesTracker = RTextArea.Text.GetHashCode();
			}

			UpdateTitle();
		}

		/// <summary>Saves the <see cref="CurrentlyOpenedFile"/> as either <see cref="kTXT"/> or <see cref="kRTF"/>.</summary>
		/// <returns><see cref="DialogResult"/> reporting any cancel operations.</returns>
		DialogResult SaveAs()
		{
			Print(this, SaveAs, "Save As");

			if (FileExplorer("Save As", ref CurrentlyOpenedFile, false, out DialogResult Response))
			{
				SaveRTextAreaToFile(CurrentlyOpenedFile);

				UnsavedChangesTracker = RTextArea.Text.GetHashCode();
			}

			UpdateTitle();

			return Response;
		}

		async void SaveRTextAreaToFile(string Path)
		{
			await WriteToFile("", Path, EWriteMode.Overwrite, Encoding.Default,
				GetExtension(CurrentlyOpenedFile) == 0 ? RTextArea.Rtf : RTextArea.Text);
		}
	}
}
