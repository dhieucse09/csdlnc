namespace Auditing.Presentation.Controls
{
	partial class UserViewControl
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageExecuteScript = new System.Windows.Forms.TabPage();
			this.tabPageManipulateTable = new System.Windows.Forms.TabPage();
			this.linkChangePassword = new System.Windows.Forms.LinkLabel();
			this.executeScriptControl = new Auditing.Presentation.Controls.ExecuteScriptControl();
			this.manipulateTableControl = new Auditing.Presentation.Controls.ManipulateTableControl();
			this.tabControl.SuspendLayout();
			this.tabPageExecuteScript.SuspendLayout();
			this.tabPageManipulateTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageExecuteScript);
			this.tabControl.Controls.Add(this.tabPageManipulateTable);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(600, 500);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageExecuteScript
			// 
			this.tabPageExecuteScript.Controls.Add(this.executeScriptControl);
			this.tabPageExecuteScript.Location = new System.Drawing.Point(4, 22);
			this.tabPageExecuteScript.Name = "tabPageExecuteScript";
			this.tabPageExecuteScript.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageExecuteScript.Size = new System.Drawing.Size(592, 474);
			this.tabPageExecuteScript.TabIndex = 0;
			this.tabPageExecuteScript.Text = "Execute script";
			this.tabPageExecuteScript.UseVisualStyleBackColor = true;
			// 
			// tabPageManipulateTable
			// 
			this.tabPageManipulateTable.Controls.Add(this.manipulateTableControl);
			this.tabPageManipulateTable.Location = new System.Drawing.Point(4, 22);
			this.tabPageManipulateTable.Name = "tabPageManipulateTable";
			this.tabPageManipulateTable.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageManipulateTable.Size = new System.Drawing.Size(592, 474);
			this.tabPageManipulateTable.TabIndex = 1;
			this.tabPageManipulateTable.Text = "Manipulate table";
			this.tabPageManipulateTable.UseVisualStyleBackColor = true;
			// 
			// linkChangePassword
			// 
			this.linkChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkChangePassword.AutoSize = true;
			this.linkChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkChangePassword.Location = new System.Drawing.Point(450, 5);
			this.linkChangePassword.Name = "linkChangePassword";
			this.linkChangePassword.Size = new System.Drawing.Size(92, 13);
			this.linkChangePassword.TabIndex = 2;
			this.linkChangePassword.TabStop = true;
			this.linkChangePassword.Text = "Change password";
			this.linkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePassword_LinkClicked);
			// 
			// executeScriptControl
			// 
			this.executeScriptControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.executeScriptControl.Location = new System.Drawing.Point(3, 3);
			this.executeScriptControl.Name = "executeScriptControl";
			this.executeScriptControl.QueryString = "Select * from dba_users;";
			this.executeScriptControl.Size = new System.Drawing.Size(586, 468);
			this.executeScriptControl.TabIndex = 0;
			this.executeScriptControl.ExecuteScript += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.executeScriptControl_ExecuteScript);
			// 
			// manipulateTableControl
			// 
			this.manipulateTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manipulateTableControl.Location = new System.Drawing.Point(3, 3);
			this.manipulateTableControl.Name = "manipulateTableControl";
			this.manipulateTableControl.Size = new System.Drawing.Size(586, 468);
			this.manipulateTableControl.TabIndex = 0;
			this.manipulateTableControl.DescribeTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.manipulateTableControl_DescribeTable);
			this.manipulateTableControl.DeleteTable += new System.EventHandler<Auditing.Presentation.Controls.TableEventArgs>(this.manipulateTableControl_DeleteTable);
			this.manipulateTableControl.CreateSampleTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.manipulateTableControl_CreateSampleTable);
			this.manipulateTableControl.SelectTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.manipulateTableControl_SelectTable);
			this.manipulateTableControl.UpdateTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.manipulateTableControl_UpdateTable);
			this.manipulateTableControl.InsertTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.manipulateTableControl_InsertTable);
			// 
			// UserViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linkChangePassword);
			this.Controls.Add(this.tabControl);
			this.Name = "UserViewControl";
			this.Size = new System.Drawing.Size(600, 500);
			this.tabControl.ResumeLayout(false);
			this.tabPageExecuteScript.ResumeLayout(false);
			this.tabPageManipulateTable.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageExecuteScript;
		private System.Windows.Forms.TabPage tabPageManipulateTable;
		private ExecuteScriptControl executeScriptControl;
		private ManipulateTableControl manipulateTableControl;
		private System.Windows.Forms.LinkLabel linkChangePassword;
	}
}
