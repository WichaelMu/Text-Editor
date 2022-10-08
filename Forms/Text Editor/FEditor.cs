﻿using static UForm;

namespace MTextEditor
{
	public partial class FEditor : Form, IFormClass
	{
		public string __CLASS__ => "FEditor";

		internal string CurrentyOpenedFile = "";
		internal int UnsavedChangesTracker = string.Empty.GetHashCode();

		public FEditor()
		{
			InitializeComponent();
		}

		void Start(object Sender, EventArgs E)
		{
			LLoggedInUser.Text = "Username: " + MUser.Get().Username;
		}

		void FEditor_Closing(object Sender, FormClosingEventArgs E)
		{
			E.Cancel = SaveUnsavedChanges() == DialogResult.Cancel;
		}

		void FEditor_FormClosed(object Sender, FormClosedEventArgs E)
		{
			Application.Exit();
		}

		// File Manipulation.
		void Tools_New(object Sender, EventArgs E) => New();
		void Tools_Open(object Sender, EventArgs E) => Open();
		void Tools_Save(object Sender, EventArgs E) => Save();
		void Tools_SaveAs(object Sender, EventArgs E) => SaveAs();

		// Text Manipulation
		void Tools_Cut(object Sender, EventArgs E) => Cut();
		void Tools_Copy(object Sender, EventArgs E) => Copy();
		void Tools_Paste(object Sender, EventArgs E) => Paste();

		void Tools_Logout(object Sender, EventArgs E)
		{
			Hide();

			FLogin LoginWindow = new FLogin();
			LoginWindow.Show();
		}

		void Tools_About(object Sender, EventArgs E)
		{
			MessageBox.Show("Text Editor Version 1.0\nAuthor: Michael Wu", "About Text Editor",
				MessageBoxButtons.OK, MessageBoxIcon.Information
			);
		}

		void CheckAndAskForUnsaved()
		{
			if (SaveUnsavedChanges() != DialogResult.Cancel)
			{
				RTextArea.Text = string.Empty;
				UnsavedChangesTracker = string.Empty.GetHashCode();
			}
		}

		bool HasUnsavedChanges() => UnsavedChangesTracker != RTextArea.Text.GetHashCode();

		DialogResult SaveUnsavedChanges()
		{
			DialogResult Response = DialogResult.No;

			if (HasUnsavedChanges())
			{
				if (!string.IsNullOrEmpty(CurrentyOpenedFile))
				{
					Response = MessageBox.Show("You have unsaved changes.\n" +
						$"Do you want to save your changes to: '{CurrentyOpenedFile}'?",
						"Unsaved Changes",
						MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

					if (Response == DialogResult.Yes)
					{
						SaveRTextAreaToFile(CurrentyOpenedFile);
					}
				}
				else
				{
					Response = MessageBox.Show("Would you like to save your new file?",
						"Unsaved Changes",
						MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

					if (Response == DialogResult.Yes)
					{
						SaveAs();
					}
				}
			}

			return Response;
		}

		void RTextChanged(object Sender, EventArgs E)
		{
			UpdateTitle();
		}

		void UpdateTitle()
		{
			if (HasUnsavedChanges())
			{
				Text = "Text Editor*";
			}
			else
			{
				Text = "Text Editor";
			}
		}
	}
}