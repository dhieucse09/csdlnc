namespace Auditing.Presentation.Controls
{
	partial class LoginControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblLoginError = new System.Windows.Forms.Label();
			this.btnSignin = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.cbxAdmin = new System.Windows.Forms.CheckBox();
			this.cbxRememberMe = new System.Windows.Forms.CheckBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtDataSourceName = new System.Windows.Forms.TextBox();
			this.lblDataSourceName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblLoginError
			// 
			this.lblLoginError.AutoSize = true;
			this.lblLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoginError.ForeColor = System.Drawing.Color.Red;
			this.lblLoginError.Location = new System.Drawing.Point(60, 101);
			this.lblLoginError.Name = "lblLoginError";
			this.lblLoginError.Size = new System.Drawing.Size(74, 13);
			this.lblLoginError.TabIndex = 0;
			this.lblLoginError.Text = "Error message";
			this.lblLoginError.TextChanged += new System.EventHandler(this.lblLoginError_TextChanged);
			// 
			// btnSignin
			// 
			this.btnSignin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSignin.Enabled = false;
			this.btnSignin.Location = new System.Drawing.Point(62, 120);
			this.btnSignin.Name = "btnSignin";
			this.btnSignin.Size = new System.Drawing.Size(75, 23);
			this.btnSignin.TabIndex = 1;
			this.btnSignin.Text = "Sign in";
			this.btnSignin.UseVisualStyleBackColor = true;
			this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
			this.btnSignin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(62, 55);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(200, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsername.Location = new System.Drawing.Point(62, 29);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(200, 20);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
			this.txtUsername.Text = global::Auditing.Presentation.Properties.Settings.Default.Username;
			// 
			// cbxAdmin
			// 
			this.cbxAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxAdmin.AutoSize = true;
			this.cbxAdmin.Location = new System.Drawing.Point(179, 81);
			this.cbxAdmin.Name = "cbxAdmin";
			this.cbxAdmin.Size = new System.Drawing.Size(84, 17);
			this.cbxAdmin.TabIndex = 4;
			this.cbxAdmin.Text = "Admin mode";
			this.cbxAdmin.UseVisualStyleBackColor = true;
			this.cbxAdmin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
			// 
			// cbxRememberMe
			// 
			this.cbxRememberMe.AutoSize = true;
			this.cbxRememberMe.Location = new System.Drawing.Point(63, 81);
			this.cbxRememberMe.Name = "cbxRememberMe";
			this.cbxRememberMe.Size = new System.Drawing.Size(94, 17);
			this.cbxRememberMe.TabIndex = 3;
			this.cbxRememberMe.Text = "Remember me";
			this.cbxRememberMe.UseVisualStyleBackColor = true;
			this.cbxRememberMe.Visible = false;
			this.cbxRememberMe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.control_KeyUp);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(4, 32);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(6, 58);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Password:";
			// 
			// txtDataSourceName
			// 
			this.txtDataSourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDataSourceName.Location = new System.Drawing.Point(62, 3);
			this.txtDataSourceName.Name = "txtDataSourceName";
			this.txtDataSourceName.Size = new System.Drawing.Size(200, 20);
			this.txtDataSourceName.TabIndex = 0;
			this.txtDataSourceName.Text = global::Auditing.Presentation.Properties.Settings.Default.DataSourceName;
			// 
			// lblDataSourceName
			// 
			this.lblDataSourceName.AutoSize = true;
			this.lblDataSourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataSourceName.Location = new System.Drawing.Point(5, 6);
			this.lblDataSourceName.Name = "lblDataSourceName";
			this.lblDataSourceName.Size = new System.Drawing.Size(56, 13);
			this.lblDataSourceName.TabIndex = 0;
			this.lblDataSourceName.Text = "Database:";
			// 
			// LoginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtDataSourceName);
			this.Controls.Add(this.lblDataSourceName);
			this.Controls.Add(this.lblLoginError);
			this.Controls.Add(this.btnSignin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.cbxAdmin);
			this.Controls.Add(this.cbxRememberMe);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.lblPassword);
			this.Name = "LoginControl";
			this.Size = new System.Drawing.Size(265, 146);
			this.Load += new System.EventHandler(this.LoginControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLoginError;
		private System.Windows.Forms.Button btnSignin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.CheckBox cbxAdmin;
		private System.Windows.Forms.CheckBox cbxRememberMe;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtDataSourceName;
		private System.Windows.Forms.Label lblDataSourceName;
	}
}
