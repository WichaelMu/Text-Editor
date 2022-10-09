using static UForm;

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

		/// <summary><b>Bold</b>, <u>Underline</u>, and <i>Italics</i> shortcut keys.</summary>
		protected override bool ProcessCmdKey(ref Message Message, Keys Key)
		{
			switch (Key)
			{
				case Keys.Control | Keys.B:
					Bold();
					return true;
				case Keys.Control | Keys.U:
					Underline();
					return true;
				case Keys.Control | Keys.I:
					Italics();
					return true;
			}

			return base.ProcessCmdKey(ref Message, Key);
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

		/// <summary>Ask the <see cref="MUser"/> if they want to save their changes.</summary>
		/// <returns><see langword="True"/> for <see cref="DialogResult.Yes"/> <b>AND</b> <see cref="DialogResult.No"/>.</returns>
		bool CheckAndAskForUnsaved()
		{
			return SaveUnsavedChanges() != DialogResult.Cancel;
		}

		/// <returns><see langword="true"/> if there are unsaved changes in <see cref="RTextArea"/> as compared to <see cref="CurrentyOpenedFile"/>.</returns>
		bool HasUnsavedChanges() => UnsavedChangesTracker != RTextArea.Text.GetHashCode();

		/// <summary>Prompts the <see cref="MUser"/> to save any unsaved changes to their currently opened file.</summary>
		/// <returns><see cref="DialogResult"/> of their decision to save or cancel.</returns>
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
						Save();
					}
				}
				else
				{
					Response = MessageBox.Show("Would you like to save your new file?",
						"Unsaved Changes",
						MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

					if (Response == DialogResult.Yes)
					{
						return SaveAs();
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

		/// <summary>Clears <see cref="RTextArea"/> and sets <see cref="FEditor"/> to it's default state.</summary>
		void Clear()
		{
			RTextArea.Text = string.Empty;
			UnsavedChangesTracker = string.Empty.GetHashCode();

			SetExtension(1);
		}
	}
}
