namespace Auditing.Presentation.Forms
{
    partial class UserInfoForm
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
					this.btnLogin = new System.Windows.Forms.Button();
					this.lblUsername = new System.Windows.Forms.Label();
					this.txtUserName = new System.Windows.Forms.TextBox();
					this.txtPassword1 = new System.Windows.Forms.TextBox();
					this.lblPassword = new System.Windows.Forms.Label();
					this.btnCancel = new System.Windows.Forms.Button();
					this.txtPassword2 = new System.Windows.Forms.TextBox();
					this.lblRetype = new System.Windows.Forms.Label();
					this.lblMessage = new System.Windows.Forms.Label();
					this.SuspendLayout();
					// 
					// btnLogin
					// 
					this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
					this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
					this.btnLogin.Enabled = false;
					this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.btnLogin.Location = new System.Drawing.Point(90, 113);
					this.btnLogin.Name = "btnLogin";
					this.btnLogin.Size = new System.Drawing.Size(80, 23);
					this.btnLogin.TabIndex = 4;
					this.btnLogin.Text = "&OK";
					this.btnLogin.UseVisualStyleBackColor = true;
					// 
					// lblUsername
					// 
					this.lblUsername.AutoSize = true;
					this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.lblUsername.Location = new System.Drawing.Point(8, 15);
					this.lblUsername.Name = "lblUsername";
					this.lblUsername.Size = new System.Drawing.Size(58, 13);
					this.lblUsername.TabIndex = 0;
					this.lblUsername.Text = "Username:";
					// 
					// txtUserName
					// 
					this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
											| System.Windows.Forms.AnchorStyles.Right)));
					this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.txtUserName.Location = new System.Drawing.Point(66, 12);
					this.txtUserName.Name = "txtUserName";
					this.txtUserName.Size = new System.Drawing.Size(190, 20);
					this.txtUserName.TabIndex = 1;
					this.txtUserName.TextChanged += new System.EventHandler(this.textbox_TextChanged);
					this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyUp);
					// 
					// txtPassword1
					// 
					this.txtPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
											| System.Windows.Forms.AnchorStyles.Right)));
					this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.txtPassword1.Location = new System.Drawing.Point(66, 38);
					this.txtPassword1.Name = "txtPassword1";
					this.txtPassword1.Size = new System.Drawing.Size(190, 20);
					this.txtPassword1.TabIndex = 2;
					this.txtPassword1.UseSystemPasswordChar = true;
					this.txtPassword1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
					this.txtPassword1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyUp);
					// 
					// lblPassword
					// 
					this.lblPassword.AutoSize = true;
					this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.lblPassword.Location = new System.Drawing.Point(10, 41);
					this.lblPassword.Name = "lblPassword";
					this.lblPassword.Size = new System.Drawing.Size(56, 13);
					this.lblPassword.TabIndex = 0;
					this.lblPassword.Text = "Password:";
					// 
					// btnCancel
					// 
					this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
					this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
					this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.btnCancel.Location = new System.Drawing.Point(176, 113);
					this.btnCancel.Name = "btnCancel";
					this.btnCancel.Size = new System.Drawing.Size(80, 23);
					this.btnCancel.TabIndex = 5;
					this.btnCancel.Text = "&Cancel";
					this.btnCancel.UseVisualStyleBackColor = true;
					// 
					// txtPassword2
					// 
					this.txtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
											| System.Windows.Forms.AnchorStyles.Right)));
					this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.txtPassword2.Location = new System.Drawing.Point(66, 64);
					this.txtPassword2.Name = "txtPassword2";
					this.txtPassword2.Size = new System.Drawing.Size(190, 20);
					this.txtPassword2.TabIndex = 3;
					this.txtPassword2.UseSystemPasswordChar = true;
					this.txtPassword2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
					this.txtPassword2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyUp);
					// 
					// lblRetype
					// 
					this.lblRetype.AutoSize = true;
					this.lblRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.lblRetype.Location = new System.Drawing.Point(22, 67);
					this.lblRetype.Name = "lblRetype";
					this.lblRetype.Size = new System.Drawing.Size(44, 13);
					this.lblRetype.TabIndex = 0;
					this.lblRetype.Text = "Retype:";
					// 
					// lblMessage
					// 
					this.lblMessage.AutoSize = true;
					this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
					this.lblMessage.ForeColor = System.Drawing.Color.Red;
					this.lblMessage.Location = new System.Drawing.Point(63, 93);
					this.lblMessage.Name = "lblMessage";
					this.lblMessage.Size = new System.Drawing.Size(170, 13);
					this.lblMessage.TabIndex = 0;
					this.lblMessage.Text = "Please verify your password again.";
					this.lblMessage.Visible = false;
					// 
					// NewUserForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.CancelButton = this.btnCancel;
					this.ClientSize = new System.Drawing.Size(264, 142);
					this.Controls.Add(this.lblMessage);
					this.Controls.Add(this.txtPassword2);
					this.Controls.Add(this.lblRetype);
					this.Controls.Add(this.btnCancel);
					this.Controls.Add(this.txtPassword1);
					this.Controls.Add(this.lblPassword);
					this.Controls.Add(this.btnLogin);
					this.Controls.Add(this.txtUserName);
					this.Controls.Add(this.lblUsername);
					this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
					this.MaximizeBox = false;
					this.MinimizeBox = false;
					this.Name = "NewUserForm";
					this.ShowInTaskbar = false;
					this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
					this.Text = "New user";
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblPassword;
				private System.Windows.Forms.Button btnCancel;
				private System.Windows.Forms.TextBox txtPassword2;
				private System.Windows.Forms.Label lblRetype;
				private System.Windows.Forms.Label lblMessage;
    }
}