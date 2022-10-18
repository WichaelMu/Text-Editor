namespace MTextEditor
{
	partial class FSignup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SignUpGroup = new System.Windows.Forms.GroupBox();
			this.LSignupNameFailMessage = new System.Windows.Forms.Label();
			this.LSignupPasswordFailMessage = new System.Windows.Forms.Label();
			this.LSignupUsernameFailMessage = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.BSignup = new System.Windows.Forms.Button();
			this.EUserType = new System.Windows.Forms.ComboBox();
			this.DBirthday = new System.Windows.Forms.DateTimePicker();
			this.TLastName = new System.Windows.Forms.TextBox();
			this.TFirstName = new System.Windows.Forms.TextBox();
			this.TSignupPasswordComparison = new System.Windows.Forms.TextBox();
			this.TSignupPasswordBase = new System.Windows.Forms.TextBox();
			this.TSignupUsername = new System.Windows.Forms.TextBox();
			this.BCancel = new System.Windows.Forms.Button();
			this.LTitle = new System.Windows.Forms.Label();
			this.SignUpGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// SignUpGroup
			// 
			this.SignUpGroup.Controls.Add(this.LSignupNameFailMessage);
			this.SignUpGroup.Controls.Add(this.LSignupPasswordFailMessage);
			this.SignUpGroup.Controls.Add(this.LSignupUsernameFailMessage);
			this.SignUpGroup.Controls.Add(this.label7);
			this.SignUpGroup.Controls.Add(this.label6);
			this.SignUpGroup.Controls.Add(this.label5);
			this.SignUpGroup.Controls.Add(this.label4);
			this.SignUpGroup.Controls.Add(this.label3);
			this.SignUpGroup.Controls.Add(this.BSignup);
			this.SignUpGroup.Controls.Add(this.EUserType);
			this.SignUpGroup.Controls.Add(this.DBirthday);
			this.SignUpGroup.Controls.Add(this.TLastName);
			this.SignUpGroup.Controls.Add(this.TFirstName);
			this.SignUpGroup.Controls.Add(this.TSignupPasswordComparison);
			this.SignUpGroup.Controls.Add(this.TSignupPasswordBase);
			this.SignUpGroup.Controls.Add(this.TSignupUsername);
			this.SignUpGroup.Controls.Add(this.BCancel);
			this.SignUpGroup.Location = new System.Drawing.Point(178, 99);
			this.SignUpGroup.Name = "SignUpGroup";
			this.SignUpGroup.Size = new System.Drawing.Size(444, 290);
			this.SignUpGroup.TabIndex = 6;
			this.SignUpGroup.TabStop = false;
			this.SignUpGroup.Text = "New User Sign Up";
			// 
			// LSignupNameFailMessage
			// 
			this.LSignupNameFailMessage.AutoSize = true;
			this.LSignupNameFailMessage.ForeColor = System.Drawing.Color.Red;
			this.LSignupNameFailMessage.Location = new System.Drawing.Point(248, 98);
			this.LSignupNameFailMessage.Name = "LSignupNameFailMessage";
			this.LSignupNameFailMessage.Size = new System.Drawing.Size(117, 15);
			this.LSignupNameFailMessage.TabIndex = 17;
			this.LSignupNameFailMessage.Text = "## FAIL MESSAGE ##";
			this.LSignupNameFailMessage.Visible = false;
			// 
			// LSignupPasswordFailMessage
			// 
			this.LSignupPasswordFailMessage.AutoSize = true;
			this.LSignupPasswordFailMessage.ForeColor = System.Drawing.Color.Red;
			this.LSignupPasswordFailMessage.Location = new System.Drawing.Point(6, 179);
			this.LSignupPasswordFailMessage.Name = "LSignupPasswordFailMessage";
			this.LSignupPasswordFailMessage.Size = new System.Drawing.Size(117, 15);
			this.LSignupPasswordFailMessage.TabIndex = 16;
			this.LSignupPasswordFailMessage.Text = "## FAIL MESSAGE ##";
			this.LSignupPasswordFailMessage.Visible = false;
			// 
			// LSignupUsernameFailMessage
			// 
			this.LSignupUsernameFailMessage.AutoSize = true;
			this.LSignupUsernameFailMessage.ForeColor = System.Drawing.Color.Red;
			this.LSignupUsernameFailMessage.Location = new System.Drawing.Point(6, 69);
			this.LSignupUsernameFailMessage.Name = "LSignupUsernameFailMessage";
			this.LSignupUsernameFailMessage.Size = new System.Drawing.Size(117, 15);
			this.LSignupUsernameFailMessage.TabIndex = 15;
			this.LSignupUsernameFailMessage.Text = "## FAIL MESSAGE ##";
			this.LSignupUsernameFailMessage.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(248, 184);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "User Type";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(248, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Date of Birth";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(248, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Username:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Password:";
			// 
			// BSignup
			// 
			this.BSignup.Location = new System.Drawing.Point(275, 250);
			this.BSignup.Name = "BSignup";
			this.BSignup.Size = new System.Drawing.Size(75, 23);
			this.BSignup.TabIndex = 7;
			this.BSignup.Text = "Submit";
			this.BSignup.UseVisualStyleBackColor = true;
			this.BSignup.Click += new System.EventHandler(this.OnClick_Signup);
			// 
			// EUserType
			// 
			this.EUserType.FormattingEnabled = true;
			this.EUserType.Location = new System.Drawing.Point(248, 202);
			this.EUserType.Name = "EUserType";
			this.EUserType.Size = new System.Drawing.Size(121, 23);
			this.EUserType.TabIndex = 6;
			// 
			// DBirthday
			// 
			this.DBirthday.Location = new System.Drawing.Point(248, 153);
			this.DBirthday.Name = "DBirthday";
			this.DBirthday.Size = new System.Drawing.Size(190, 23);
			this.DBirthday.TabIndex = 5;
			this.DBirthday.Value = new System.DateTime(2001, 2, 28, 0, 0, 0, 0);
			// 
			// TLastName
			// 
			this.TLastName.Location = new System.Drawing.Point(248, 72);
			this.TLastName.Name = "TLastName";
			this.TLastName.PlaceholderText = "Surname";
			this.TLastName.Size = new System.Drawing.Size(190, 23);
			this.TLastName.TabIndex = 4;
			// 
			// TFirstName
			// 
			this.TFirstName.Location = new System.Drawing.Point(248, 43);
			this.TFirstName.Name = "TFirstName";
			this.TFirstName.PlaceholderText = "Given Name/s";
			this.TFirstName.Size = new System.Drawing.Size(190, 23);
			this.TFirstName.TabIndex = 3;
			// 
			// TSignupPasswordComparison
			// 
			this.TSignupPasswordComparison.Location = new System.Drawing.Point(6, 153);
			this.TSignupPasswordComparison.Name = "TSignupPasswordComparison";
			this.TSignupPasswordComparison.PlaceholderText = "Re-enter Password";
			this.TSignupPasswordComparison.Size = new System.Drawing.Size(190, 23);
			this.TSignupPasswordComparison.TabIndex = 2;
			this.TSignupPasswordComparison.UseSystemPasswordChar = true;
			// 
			// TSignupPasswordBase
			// 
			this.TSignupPasswordBase.Location = new System.Drawing.Point(6, 124);
			this.TSignupPasswordBase.Name = "TSignupPasswordBase";
			this.TSignupPasswordBase.PlaceholderText = "Password";
			this.TSignupPasswordBase.Size = new System.Drawing.Size(190, 23);
			this.TSignupPasswordBase.TabIndex = 1;
			this.TSignupPasswordBase.UseSystemPasswordChar = true;
			// 
			// TSignupUsername
			// 
			this.TSignupUsername.Location = new System.Drawing.Point(6, 43);
			this.TSignupUsername.Name = "TSignupUsername";
			this.TSignupUsername.PlaceholderText = "Username";
			this.TSignupUsername.Size = new System.Drawing.Size(190, 23);
			this.TSignupUsername.TabIndex = 0;
			// 
			// BCancel
			// 
			this.BCancel.Location = new System.Drawing.Point(96, 250);
			this.BCancel.Name = "BCancel";
			this.BCancel.Size = new System.Drawing.Size(75, 23);
			this.BCancel.TabIndex = 8;
			this.BCancel.Text = "Cancel";
			this.BCancel.UseVisualStyleBackColor = true;
			this.BCancel.Click += new System.EventHandler(this.OnClick_SignupCancel);
			// 
			// LTitle
			// 
			this.LTitle.AutoSize = true;
			this.LTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LTitle.Location = new System.Drawing.Point(12, 9);
			this.LTitle.Name = "LTitle";
			this.LTitle.Size = new System.Drawing.Size(477, 45);
			this.LTitle.TabIndex = 7;
			this.LTitle.Text = "SIGNUP FOR AN TEXT EDITOR";
			// 
			// FSignup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LTitle);
			this.Controls.Add(this.SignUpGroup);
			this.KeyPreview = true;
			this.Name = "FSignup";
			this.Text = "Signup | MTextEditor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose_FSignup);
			this.Load += new System.EventHandler(this.Start);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FSignup_OnKeyDown);
			this.SignUpGroup.ResumeLayout(false);
			this.SignUpGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox SignUpGroup;
		private Label LSignupNameFailMessage;
		private Label LSignupPasswordFailMessage;
		private Label LSignupUsernameFailMessage;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button BSignup;
		private ComboBox EUserType;
		private DateTimePicker DBirthday;
		private TextBox TLastName;
		private TextBox TFirstName;
		private TextBox TSignupPasswordComparison;
		private TextBox TSignupPasswordBase;
		private TextBox TSignupUsername;
		private Button BCancel;
		private Label LTitle;
	}
}