using System.Diagnostics;
using static UForm;

namespace MTextEditor
{
	public partial class FEditor : Form, IFormClass
	{
		public string __CLASS__ => "FEditor";

		internal string CurrentlyOpenedFile = "";
		internal int UnsavedChangesTracker = string.Empty.GetHashCode();

		internal bool bIsDirty;

		const int kMinimumFontSize = 8;
		const int kMaximumFontSize = 20;
		const int kDefaultFontSize = 11;

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

				case Keys.Control | Keys.D1:
					TryCompile();
					return true;

				case Keys.Control | Keys.Shift | Keys.OemPeriod:
					AdjustFontSizeShortcut(1);
					return true;
				case Keys.Control | Keys.Shift | Keys.Oemcomma:
					AdjustFontSizeShortcut(-1);
					return true;
			}

			return base.ProcessCmdKey(ref Message, Key);
		}

		void Start(object Sender, EventArgs E)
		{
			MUser LoggedInUser = MUser.Get();
			LLoggedInUser.Text = $"Username: {LoggedInUser.Username}        {LoggedInUser.FirstName} {LoggedInUser.LastName}";

			RTextArea.ReadOnly = MUser.Get().Type < EUserTypes.Edit;

			for (int i = kMinimumFontSize; i <= kMaximumFontSize; ++i)
				TSFontSize.Items.Add(i.ToString());

			TSFontSize.SelectedIndex = 3; // 11
			AdjustFontSize(kDefaultFontSize);
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

		void Tools_SaveAs(object Sender, EventArgs E)
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			SaveAs();
		}

		// Text Manipulation
		void Tools_Cut(object Sender, EventArgs E) => Cut();
		void Tools_Copy(object Sender, EventArgs E) => Copy();
		void Tools_Paste(object Sender, EventArgs E) => Paste();

		// BUI.
		void Tools_Bold(object Sender, EventArgs E) => Bold();
		void Tools_Underline(object Sender, EventArgs E) => Underline();
		void Tools_Italics(object Sender, EventArgs E) => Italics();

		// Misc.
		//

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

		// Helper Functions.
		//

		/// <summary>Ask the <see cref="MUser"/> if they want to save their changes.</summary>
		/// <returns><see langword="True"/> for <see cref="DialogResult.Yes"/> <b>AND</b> <see cref="DialogResult.No"/>.</returns>
		bool CheckAndAskForUnsaved()
		{
			return SaveUnsavedChanges() != DialogResult.Cancel;
		}

		/// <returns><see langword="true"/> if there are unsaved changes in <see cref="RTextArea"/> as compared to <see cref="CurrentlyOpenedFile"/>.</returns>
		bool HasUnsavedChanges() => UnsavedChangesTracker != RTextArea.Text.GetHashCode();

		/// <summary>Prompts the <see cref="MUser"/> to save any unsaved changes to their currently opened file.</summary>
		/// <returns><see cref="DialogResult"/> of their decision to save or cancel.</returns>
		DialogResult SaveUnsavedChanges()
		{
			DialogResult Response = DialogResult.No;

			if (HasUnsavedChanges())
			{
				if (!string.IsNullOrEmpty(CurrentlyOpenedFile))
				{
					Response = MessageBox.Show("You have unsaved changes.\n" +
						$"Do you want to save your changes to: '{CurrentlyOpenedFile}'?",
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
			HandleRollingFontSize();
			HandleRollingBUI();
		}

		void UpdateTitle()
		{
			if (HasUnsavedChanges())
			{
				if (string.IsNullOrEmpty(CurrentlyOpenedFile))
				{
					Text = "Text Editor";
				}
				else
				{
					Text = $"Text Editor | {Path.GetFileName(CurrentlyOpenedFile)}*";
				}
			}
			else
			{
				if (string.IsNullOrEmpty(CurrentlyOpenedFile))
				{
					Text = "Text Editor";
				}
				else
				{
					Text = $"Text Editor | {Path.GetFileName(CurrentlyOpenedFile)}";
				}
			}
		}

		/// <summary>Clears <see cref="RTextArea"/> and sets <see cref="FEditor"/> to it's default state.</summary>
		void Clear()
		{
			RTextArea.Text = string.Empty;
			UnsavedChangesTracker = string.Empty.GetHashCode();

			SetExtension(1);
		}

		void CheckAndApplyFontSize()
		{
			if (int.TryParse(TSFontSize.Text, out int OutSize))
			{
				AdjustFontSize(OutSize);
				RTextArea.Focus();
			}
			else
			{
				TSFontSize.Text = kDefaultFontSize.ToString();
			}
		}

		void Tools_FontSize(object Sender, EventArgs E)
		{
			CheckAndApplyFontSize();
		}

		void Tools_FontSize_LeftFocus(object Sender, EventArgs E)
		{
			RTextArea.Focus();
		}

		void AdjustFontSizeShortcut(int Direction)
		{
			int Final = TSFontSize.SelectedIndex + Direction;

			if (Final == -1 || Final == TSFontSize.Items.Count)
				return;

			TSFontSize.SelectedIndex = Final;
			TSFontSize.Text = TSFontSize.Items[Final].ToString();
		}

		void Tools_Compile(object Sender, EventArgs E)
		{
			TryCompile();
		}

		void TryCompile()
		{
			if (string.IsNullOrEmpty(CurrentlyOpenedFile))
			{
				MessageBox.Show("Open a valid C# Source File, or Save this file as a C# Source File to compile.", "Compilation Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (Path.GetExtension(CurrentlyOpenedFile) == ".cs")
				{
					CompileAndRun();
				}
				else
				{
					MessageBox.Show($"{Path.GetFileName(CurrentlyOpenedFile)} is not a C# Source File.", "Compilation Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void CompileAndRun()
		{
			Print(this, CompileAndRun, "Compiling");
			Process.Start("cmd.exe", $"/C csc {CurrentlyOpenedFile} && {Path.GetFileName(CurrentlyOpenedFile.TrimEnd('.', 'c', 's'))}.exe && pause");
		}
	}
}
