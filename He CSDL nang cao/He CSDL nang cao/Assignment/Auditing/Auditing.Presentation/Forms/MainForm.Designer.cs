namespace Auditing.Presentation.Forms
{
	partial class MainForm
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
			this.linkSignout = new System.Windows.Forms.LinkLabel();
			this.adminViewControl = new Auditing.Presentation.Controls.AdminViewControl();
			this.userViewControl = new Auditing.Presentation.Controls.UserViewControl();
			this.loginControl = new Auditing.Presentation.Controls.LoginControl();
			this.userViewControl1 = new Auditing.Presentation.Controls.UserViewControl();
			this.SuspendLayout();
			// 
			// linkSignout
			// 
			this.linkSignout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkSignout.AutoSize = true;
			this.linkSignout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkSignout.Location = new System.Drawing.Point(734, 4);
			this.linkSignout.Name = "linkSignout";
			this.linkSignout.Size = new System.Drawing.Size(46, 13);
			this.linkSignout.TabIndex = 3;
			this.linkSignout.TabStop = true;
			this.linkSignout.Text = "Sign out";
			this.linkSignout.Visible = false;
			this.linkSignout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignout_LinkClicked);
			// 
			// adminViewControl
			// 
			this.adminViewControl.Location = new System.Drawing.Point(470, 45);
			this.adminViewControl.Name = "adminViewControl";
			this.adminViewControl.Size = new System.Drawing.Size(291, 300);
			this.adminViewControl.TabIndex = 1;
			this.adminViewControl.Visible = false;
			this.adminViewControl.DeleteTable += new System.EventHandler<Auditing.Presentation.Controls.TableEventArgs>(this.adminViewControl_DeleteTable);
			this.adminViewControl.AlterUser += new System.EventHandler<Auditing.Presentation.Controls.UserEventArgs>(this.adminViewControl_AlterUser);
			this.adminViewControl.SetAuditTable += new System.EventHandler<Auditing.Presentation.Controls.AuditTableEventArgs>(this.adminViewControl_SetAuditTable);
			this.adminViewControl.DeleteUser += new System.EventHandler<Auditing.Presentation.Controls.UserEventArgs>(this.adminViewControl_DeleteUser);
			this.adminViewControl.ExecuteScript += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.adminViewControl_ExecuteScript);
			this.adminViewControl.SetAuditUser += new System.EventHandler<Auditing.Presentation.Controls.AuditUserEventArgs>(this.adminViewControl_SetAuditUser);
			this.adminViewControl.NewUser += new System.EventHandler<Auditing.Presentation.Controls.UserEventArgs>(this.adminViewControl_NewUser);
			this.adminViewControl.NewTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.adminViewControl_NewTable);
			// 
			// userViewControl
			// 
			this.userViewControl.Location = new System.Drawing.Point(10, 218);
			this.userViewControl.Name = "userViewControl";
			this.userViewControl.Size = new System.Drawing.Size(400, 200);
			this.userViewControl.TabIndex = 2;
			this.userViewControl.DescribeTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.userViewControl_DescribeTable);
			this.userViewControl.DeleteTable += new System.EventHandler<Auditing.Presentation.Controls.TableEventArgs>(this.userViewControl_DeleteTable);
			this.userViewControl.ChangePassword += new System.EventHandler(this.userViewControl_ChangePassword);
			this.userViewControl.CreateSampleTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.userViewControl_CreateSampleTable);
			this.userViewControl.SelectTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.userViewControl_SelectTable);
			this.userViewControl.ExecuteScript += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.userViewControl_ExecuteScript);
			this.userViewControl.UpdateTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.userViewControl_UpdateTable);
			this.userViewControl.InsertTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.userViewControl_InsertTable);
			// 
			// loginControl
			// 
			this.loginControl.BackColor = System.Drawing.SystemColors.Control;
			this.loginControl.IsAdmin = false;
			this.loginControl.Location = new System.Drawing.Point(10, 18);
			this.loginControl.Name = "loginControl";
			this.loginControl.RememberInfo = false;
			this.loginControl.Size = new System.Drawing.Size(265, 133);
			this.loginControl.TabIndex = 0;
			this.loginControl.VisibleChanged += new System.EventHandler(this.loginControl_VisibleChanged);
			this.loginControl.Login += new System.EventHandler(this.loginControl_Login);
			// 
			// userViewControl1
			// 
			this.userViewControl1.Location = new System.Drawing.Point(10, 167);
			this.userViewControl1.Name = "userViewControl1";
			this.userViewControl1.Size = new System.Drawing.Size(600, 400);
			this.userViewControl1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.linkSignout);
			this.Controls.Add(this.adminViewControl);
			this.Controls.Add(this.userViewControl);
			this.Controls.Add(this.loginControl);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Oracle Auditing";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Auditing.Presentation.Controls.LoginControl loginControl;
		private Auditing.Presentation.Controls.AdminViewControl adminViewControl;
		private Auditing.Presentation.Controls.UserViewControl userViewControl;
		private System.Windows.Forms.LinkLabel linkSignout;
		private Auditing.Presentation.Controls.UserViewControl userViewControl1;
	}
}

