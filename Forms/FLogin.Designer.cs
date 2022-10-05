namespace MTextEditor
{
	partial class FLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LTitle = new System.Windows.Forms.Label();
			this.LoginGroup = new System.Windows.Forms.GroupBox();
			this.LLoginFailMessage = new System.Windows.Forms.Label();
			this.HSignup = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TLoginPassword = new System.Windows.Forms.TextBox();
			this.TLoginUsername = new System.Windows.Forms.TextBox();
			this.SignUpGroup = new System.Windows.Forms.GroupBox();
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
			this.LoginGroup.SuspendLayout();
			this.SignUpGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// LTitle
			// 
			this.LTitle.AutoSize = true;
			this.LTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LTitle.Location = new System.Drawing.Point(21, 9);
			this.LTitle.Name = "LTitle";
			this.LTitle.Size = new System.Drawing.Size(278, 45);
			this.LTitle.TabIndex = 3;
			this.LTitle.Text = "AN TEXT EDITOR";
			// 
			// LoginGroup
			// 
			this.LoginGroup.Controls.Add(this.LLoginFailMessage);
			this.LoginGroup.Controls.Add(this.HSignup);
			this.LoginGroup.Controls.Add(this.label8);
			this.LoginGroup.Controls.Add(this.button1);
			this.LoginGroup.Controls.Add(this.label2);
			this.LoginGroup.Controls.Add(this.label1);
			this.LoginGroup.Controls.Add(this.TLoginPassword);
			this.LoginGroup.Controls.Add(this.TLoginUsername);
			this.LoginGroup.Location = new System.Drawing.Point(287, 106);
			this.LoginGroup.Name = "LoginGroup";
			this.LoginGroup.Size = new System.Drawing.Size(244, 256);
			this.LoginGroup.TabIndex = 4;
			this.LoginGroup.TabStop = false;
			this.LoginGroup.Text = "Login";
			// 
			// LLoginFailMessage
			// 
			this.LLoginFailMessage.AutoSize = true;
			this.LLoginFailMessage.ForeColor = System.Drawing.Color.Red;
			this.LLoginFailMessage.Location = new System.Drawing.Point(6, 181);
			this.LLoginFailMessage.Name = "LLoginFailMessage";
			this.LLoginFailMessage.Size = new System.Drawing.Size(117, 15);
			this.LLoginFailMessage.TabIndex = 16;
			this.LLoginFailMessage.Text = "## FAIL MESSAGE ##";
			this.LLoginFailMessage.Visible = false;
			// 
			// HSignup
			// 
			this.HSignup.AutoSize = true;
			this.HSignup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HSignup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.HSignup.ForeColor = System.Drawing.SystemColors.Highlight;
			this.HSignup.Location = new System.Drawing.Point(143, 229);
			this.HSignup.Name = "HSignup";
			this.HSignup.Size = new System.Drawing.Size(76, 15);
			this.HSignup.TabIndex = 8;
			this.HSignup.Text = "Sign up here!";
			this.HSignup.Click += new System.EventHandler(this.OnClick_ShowSignup);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 229);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(131, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = "Don\'t have an account?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(163, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnClick_Login);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username";
			// 
			// TLoginPassword
			// 
			this.TLoginPassword.Location = new System.Drawing.Point(5, 109);
			this.TLoginPassword.Name = "TLoginPassword";
			this.TLoginPassword.PlaceholderText = "Password";
			this.TLoginPassword.Size = new System.Drawing.Size(233, 23);
			this.TLoginPassword.TabIndex = 2;
			this.TLoginPassword.UseSystemPasswordChar = true;
			// 
			// TLoginUsername
			// 
			this.TLoginUsername.Location = new System.Drawing.Point(5, 57);
			this.TLoginUsername.Name = "TLoginUsername";
			this.TLoginUsername.PlaceholderText = "Username";
			this.TLoginUsername.Size = new System.Drawing.Size(233, 23);
			this.TLoginUsername.TabIndex = 1;
			// 
			// SignUpGroup
			// 
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
			this.SignUpGroup.Location = new System.Drawing.Point(840, 106);
			this.SignUpGroup.Name = "SignUpGroup";
			this.SignUpGroup.Size = new System.Drawing.Size(444, 258);
			this.SignUpGroup.TabIndex = 5;
			this.SignUpGroup.TabStop = false;
			this.SignUpGroup.Text = "New User Sign Up";
			// 
			// LSignupPasswordFailMessage
			// 
			this.LSignupPasswordFailMessage.AutoSize = true;
			this.LSignupPasswordFailMessage.ForeColor = System.Drawing.Color.Red;
			this.LSignupPasswordFailMessage.Location = new System.Drawing.Point(8, 181);
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
			this.LSignupUsernameFailMessage.Location = new System.Drawing.Point(8, 69);
			this.LSignupUsernameFailMessage.Name = "LSignupUsernameFailMessage";
			this.LSignupUsernameFailMessage.Size = new System.Drawing.Size(117, 15);
			this.LSignupUsernameFailMessage.TabIndex = 15;
			this.LSignupUsernameFailMessage.Text = "## FAIL MESSAGE ##";
			this.LSignupUsernameFailMessage.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(248, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "User Type";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(248, 106);
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
			this.BSignup.Location = new System.Drawing.Point(275, 221);
			this.BSignup.Name = "BSignup";
			this.BSignup.Size = new System.Drawing.Size(75, 23);
			this.BSignup.TabIndex = 9;
			this.BSignup.Text = "Submit";
			this.BSignup.UseVisualStyleBackColor = true;
			this.BSignup.Click += new System.EventHandler(this.OnClick_Signup);
			// 
			// EUserType
			// 
			this.EUserType.FormattingEnabled = true;
			this.EUserType.Location = new System.Drawing.Point(248, 173);
			this.EUserType.Name = "EUserType";
			this.EUserType.Size = new System.Drawing.Size(121, 23);
			this.EUserType.TabIndex = 8;
			// 
			// DBirthday
			// 
			this.DBirthday.Location = new System.Drawing.Point(248, 124);
			this.DBirthday.Name = "DBirthday";
			this.DBirthday.Size = new System.Drawing.Size(190, 23);
			this.DBirthday.TabIndex = 7;
			this.DBirthday.Value = new System.DateTime(2001, 2, 28, 0, 0, 0, 0);
			// 
			// TLastName
			// 
			this.TLastName.Location = new System.Drawing.Point(248, 72);
			this.TLastName.Name = "TLastName";
			this.TLastName.PlaceholderText = "Surname";
			this.TLastName.Size = new System.Drawing.Size(190, 23);
			this.TLastName.TabIndex = 6;
			// 
			// TFirstName
			// 
			this.TFirstName.Location = new System.Drawing.Point(248, 43);
			this.TFirstName.Name = "TFirstName";
			this.TFirstName.PlaceholderText = "Given Name/s";
			this.TFirstName.Size = new System.Drawing.Size(190, 23);
			this.TFirstName.TabIndex = 5;
			// 
			// TSignupPasswordComparison
			// 
			this.TSignupPasswordComparison.Location = new System.Drawing.Point(6, 153);
			this.TSignupPasswordComparison.Name = "TSignupPasswordComparison";
			this.TSignupPasswordComparison.PlaceholderText = "Re-enter Password";
			this.TSignupPasswordComparison.Size = new System.Drawing.Size(190, 23);
			this.TSignupPasswordComparison.TabIndex = 4;
			this.TSignupPasswordComparison.UseSystemPasswordChar = true;
			// 
			// TSignupPasswordBase
			// 
			this.TSignupPasswordBase.Location = new System.Drawing.Point(6, 124);
			this.TSignupPasswordBase.Name = "TSignupPasswordBase";
			this.TSignupPasswordBase.PlaceholderText = "Password";
			this.TSignupPasswordBase.Size = new System.Drawing.Size(190, 23);
			this.TSignupPasswordBase.TabIndex = 3;
			this.TSignupPasswordBase.UseSystemPasswordChar = true;
			// 
			// TSignupUsername
			// 
			this.TSignupUsername.Location = new System.Drawing.Point(6, 43);
			this.TSignupUsername.Name = "TSignupUsername";
			this.TSignupUsername.PlaceholderText = "Username";
			this.TSignupUsername.Size = new System.Drawing.Size(190, 23);
			this.TSignupUsername.TabIndex = 2;
			// 
			// BCancel
			// 
			this.BCancel.Location = new System.Drawing.Point(96, 221);
			this.BCancel.Name = "BCancel";
			this.BCancel.Size = new System.Drawing.Size(75, 23);
			this.BCancel.TabIndex = 0;
			this.BCancel.Text = "Cancel";
			this.BCancel.UseVisualStyleBackColor = true;
			this.BCancel.Click += new System.EventHandler(this.OnClick_ShowLogin);
			// 
			// FLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 457);
			this.Controls.Add(this.SignUpGroup);
			this.Controls.Add(this.LoginGroup);
			this.Controls.Add(this.LTitle);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Start);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FLogin_OnKeyDown);
			this.LoginGroup.ResumeLayout(false);
			this.LoginGroup.PerformLayout();
			this.SignUpGroup.ResumeLayout(false);
			this.SignUpGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label LTitle;
		private GroupBox LoginGroup;
		private TextBox TLoginPassword;
		private TextBox TLoginUsername;
		private GroupBox SignUpGroup;
		private Button BCancel;
		private TextBox TSignupPasswordComparison;
		private TextBox TSignupPasswordBase;
		private TextBox TSignupUsername;
		private TextBox TLastName;
		private TextBox TFirstName;
		private DateTimePicker DBirthday;
		private ComboBox EUserType;
		private Button BSignup;
		private Label label2;
		private Label label1;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button button1;
		private Label HSignup;
		private Label label8;
		private Label LSignupUsernameFailMessage;
		private Label LLoginFailMessage;
		private Label LSignupPasswordFailMessage;
	}
}