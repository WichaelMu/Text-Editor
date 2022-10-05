namespace Text_Editor
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
			this.BLogin = new System.Windows.Forms.Button();
			this.TPassword = new System.Windows.Forms.TextBox();
			this.TUsername = new System.Windows.Forms.TextBox();
			this.SignUpGroup = new System.Windows.Forms.GroupBox();
			this.BSignUp = new System.Windows.Forms.Button();
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
			this.LoginGroup.Controls.Add(this.BLogin);
			this.LoginGroup.Controls.Add(this.TPassword);
			this.LoginGroup.Controls.Add(this.TUsername);
			this.LoginGroup.Location = new System.Drawing.Point(287, 106);
			this.LoginGroup.Name = "LoginGroup";
			this.LoginGroup.Size = new System.Drawing.Size(278, 196);
			this.LoginGroup.TabIndex = 4;
			this.LoginGroup.TabStop = false;
			this.LoginGroup.Text = "Login";
			// 
			// BLogin
			// 
			this.BLogin.Location = new System.Drawing.Point(99, 167);
			this.BLogin.Name = "BLogin";
			this.BLogin.Size = new System.Drawing.Size(75, 23);
			this.BLogin.TabIndex = 3;
			this.BLogin.Text = "LOGIN";
			this.BLogin.UseVisualStyleBackColor = true;
			this.BLogin.Click += new System.EventHandler(this.OnClick_Login);
			// 
			// TPassword
			// 
			this.TPassword.Location = new System.Drawing.Point(5, 109);
			this.TPassword.Name = "TPassword";
			this.TPassword.Size = new System.Drawing.Size(190, 23);
			this.TPassword.TabIndex = 2;
			this.TPassword.UseSystemPasswordChar = true;
			// 
			// TUsername
			// 
			this.TUsername.Location = new System.Drawing.Point(5, 57);
			this.TUsername.Name = "TUsername";
			this.TUsername.Size = new System.Drawing.Size(190, 23);
			this.TUsername.TabIndex = 1;
			// 
			// SignUpGroup
			// 
			this.SignUpGroup.Controls.Add(this.BSignUp);
			this.SignUpGroup.Location = new System.Drawing.Point(840, 120);
			this.SignUpGroup.Name = "SignUpGroup";
			this.SignUpGroup.Size = new System.Drawing.Size(252, 202);
			this.SignUpGroup.TabIndex = 5;
			this.SignUpGroup.TabStop = false;
			this.SignUpGroup.Text = "New User Sign Up";
			// 
			// BSignUp
			// 
			this.BSignUp.Location = new System.Drawing.Point(92, 110);
			this.BSignUp.Name = "BSignUp";
			this.BSignUp.Size = new System.Drawing.Size(75, 23);
			this.BSignUp.TabIndex = 0;
			this.BSignUp.Text = "SIGN UP!";
			this.BSignUp.UseVisualStyleBackColor = true;
			this.BSignUp.Click += new System.EventHandler(this.OnClick_SignUp);
			// 
			// FLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 381);
			this.Controls.Add(this.SignUpGroup);
			this.Controls.Add(this.LoginGroup);
			this.Controls.Add(this.LTitle);
			this.Name = "FLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Start);
			this.LoginGroup.ResumeLayout(false);
			this.LoginGroup.PerformLayout();
			this.SignUpGroup.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label LTitle;
		private GroupBox LoginGroup;
		private Button BLogin;
		private TextBox TPassword;
		private TextBox TUsername;
		private GroupBox SignUpGroup;
		private Button BSignUp;
	}
}