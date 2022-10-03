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
			this.BLogin = new System.Windows.Forms.Button();
			this.TUsername = new System.Windows.Forms.TextBox();
			this.TPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BLogin
			// 
			this.BLogin.Location = new System.Drawing.Point(432, 249);
			this.BLogin.Name = "BLogin";
			this.BLogin.Size = new System.Drawing.Size(75, 23);
			this.BLogin.TabIndex = 2;
			this.BLogin.Text = "LOGIN";
			this.BLogin.UseVisualStyleBackColor = true;
			this.BLogin.Click += new System.EventHandler(this.OnClick_Login);
			// 
			// TUsername
			// 
			this.TUsername.Location = new System.Drawing.Point(395, 107);
			this.TUsername.Name = "TUsername";
			this.TUsername.Size = new System.Drawing.Size(190, 23);
			this.TUsername.TabIndex = 0;
			// 
			// TPassword
			// 
			this.TPassword.Location = new System.Drawing.Point(395, 157);
			this.TPassword.Name = "TPassword";
			this.TPassword.Size = new System.Drawing.Size(190, 23);
			this.TPassword.TabIndex = 1;
			this.TPassword.UseSystemPasswordChar = true;
			// 
			// FLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TPassword);
			this.Controls.Add(this.TUsername);
			this.Controls.Add(this.BLogin);
			this.Name = "FLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Start);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button BLogin;
		private TextBox TUsername;
		private TextBox TPassword;
	}
}