namespace Auditing.Presentation.Controls
{
	partial class AuditOtherControl
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
			this.btnAuditCreateAnyDirectory = new System.Windows.Forms.Button();
			this.btnNoauditCreateAnyDirectory = new System.Windows.Forms.Button();
			this.AuditRole = new System.Windows.Forms.GroupBox();
			this.btnAuditRole = new System.Windows.Forms.Button();
			this.cbxWheneverSuccessful = new System.Windows.Forms.CheckBox();
			this.cbxWheneverNotSuccessful = new System.Windows.Forms.CheckBox();
			this.groupBoxAuditDirectory = new System.Windows.Forms.GroupBox();
			this.btnAuditDirectory = new System.Windows.Forms.Button();
			this.btnNoAuditDirectory = new System.Windows.Forms.Button();
			this.groupBoxCommon = new System.Windows.Forms.GroupBox();
			this.btnAuditAll = new System.Windows.Forms.Button();
			this.btnNoAuditAll = new System.Windows.Forms.Button();
			this.btnAuditAllPrivileges = new System.Windows.Forms.Button();
			this.btnNoAuditAllPrivileges = new System.Windows.Forms.Button();
			this.groupBoxAuditPrivileges = new System.Windows.Forms.GroupBox();
			this.AuditRole.SuspendLayout();
			this.groupBoxAuditDirectory.SuspendLayout();
			this.groupBoxCommon.SuspendLayout();
			this.groupBoxAuditPrivileges.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAuditCreateAnyDirectory
			// 
			this.btnAuditCreateAnyDirectory.Location = new System.Drawing.Point(6, 48);
			this.btnAuditCreateAnyDirectory.Name = "btnAuditCreateAnyDirectory";
			this.btnAuditCreateAnyDirectory.Size = new System.Drawing.Size(150, 23);
			this.btnAuditCreateAnyDirectory.TabIndex = 2;
			this.btnAuditCreateAnyDirectory.Text = "Audit create any directory";
			this.btnAuditCreateAnyDirectory.UseVisualStyleBackColor = true;
			this.btnAuditCreateAnyDirectory.Click += new System.EventHandler(this.btnAuditCreateAnyDirectory_Click);
			// 
			// btnNoauditCreateAnyDirectory
			// 
			this.btnNoauditCreateAnyDirectory.Location = new System.Drawing.Point(162, 48);
			this.btnNoauditCreateAnyDirectory.Name = "btnNoauditCreateAnyDirectory";
			this.btnNoauditCreateAnyDirectory.Size = new System.Drawing.Size(150, 23);
			this.btnNoauditCreateAnyDirectory.TabIndex = 3;
			this.btnNoauditCreateAnyDirectory.Text = "Audit create any directory";
			this.btnNoauditCreateAnyDirectory.UseVisualStyleBackColor = true;
			this.btnNoauditCreateAnyDirectory.Click += new System.EventHandler(this.btnNoauditCreateAnyDirectory_Click);
			// 
			// AuditRole
			// 
			this.AuditRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.AuditRole.Controls.Add(this.cbxWheneverNotSuccessful);
			this.AuditRole.Controls.Add(this.cbxWheneverSuccessful);
			this.AuditRole.Controls.Add(this.btnAuditRole);
			this.AuditRole.Location = new System.Drawing.Point(3, 51);
			this.AuditRole.Name = "AuditRole";
			this.AuditRole.Size = new System.Drawing.Size(394, 70);
			this.AuditRole.TabIndex = 1;
			this.AuditRole.TabStop = false;
			this.AuditRole.Text = "Audit role";
			// 
			// btnAuditRole
			// 
			this.btnAuditRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAuditRole.Location = new System.Drawing.Point(6, 41);
			this.btnAuditRole.Name = "btnAuditRole";
			this.btnAuditRole.Size = new System.Drawing.Size(75, 23);
			this.btnAuditRole.TabIndex = 2;
			this.btnAuditRole.Text = "Audit role";
			this.btnAuditRole.UseVisualStyleBackColor = true;
			this.btnAuditRole.Click += new System.EventHandler(this.btnAuditRole_Click);
			// 
			// cbxWheneverSuccessful
			// 
			this.cbxWheneverSuccessful.AutoSize = true;
			this.cbxWheneverSuccessful.Checked = true;
			this.cbxWheneverSuccessful.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxWheneverSuccessful.Location = new System.Drawing.Point(6, 19);
			this.cbxWheneverSuccessful.Name = "cbxWheneverSuccessful";
			this.cbxWheneverSuccessful.Size = new System.Drawing.Size(129, 17);
			this.cbxWheneverSuccessful.TabIndex = 0;
			this.cbxWheneverSuccessful.Text = "Whenever successful";
			this.cbxWheneverSuccessful.UseVisualStyleBackColor = true;
			// 
			// cbxWheneverNotSuccessful
			// 
			this.cbxWheneverNotSuccessful.AutoSize = true;
			this.cbxWheneverNotSuccessful.Checked = true;
			this.cbxWheneverNotSuccessful.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxWheneverNotSuccessful.Location = new System.Drawing.Point(141, 19);
			this.cbxWheneverNotSuccessful.Name = "cbxWheneverNotSuccessful";
			this.cbxWheneverNotSuccessful.Size = new System.Drawing.Size(147, 17);
			this.cbxWheneverNotSuccessful.TabIndex = 1;
			this.cbxWheneverNotSuccessful.Text = "Whenever not successful";
			this.cbxWheneverNotSuccessful.UseVisualStyleBackColor = true;
			// 
			// groupBoxAuditDirectory
			// 
			this.groupBoxAuditDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAuditDirectory.Controls.Add(this.btnNoAuditDirectory);
			this.groupBoxAuditDirectory.Controls.Add(this.btnAuditDirectory);
			this.groupBoxAuditDirectory.Controls.Add(this.btnNoauditCreateAnyDirectory);
			this.groupBoxAuditDirectory.Controls.Add(this.btnAuditCreateAnyDirectory);
			this.groupBoxAuditDirectory.Location = new System.Drawing.Point(3, 181);
			this.groupBoxAuditDirectory.Name = "groupBoxAuditDirectory";
			this.groupBoxAuditDirectory.Size = new System.Drawing.Size(394, 78);
			this.groupBoxAuditDirectory.TabIndex = 3;
			this.groupBoxAuditDirectory.TabStop = false;
			this.groupBoxAuditDirectory.Text = "Audit directory";
			// 
			// btnAuditDirectory
			// 
			this.btnAuditDirectory.Location = new System.Drawing.Point(6, 19);
			this.btnAuditDirectory.Name = "btnAuditDirectory";
			this.btnAuditDirectory.Size = new System.Drawing.Size(150, 23);
			this.btnAuditDirectory.TabIndex = 0;
			this.btnAuditDirectory.Text = "Audit directory";
			this.btnAuditDirectory.UseVisualStyleBackColor = true;
			this.btnAuditDirectory.Click += new System.EventHandler(this.btnAuditDirectory_Click);
			// 
			// btnNoAuditDirectory
			// 
			this.btnNoAuditDirectory.Location = new System.Drawing.Point(162, 19);
			this.btnNoAuditDirectory.Name = "btnNoAuditDirectory";
			this.btnNoAuditDirectory.Size = new System.Drawing.Size(150, 23);
			this.btnNoAuditDirectory.TabIndex = 1;
			this.btnNoAuditDirectory.Text = "No audit directory";
			this.btnNoAuditDirectory.UseVisualStyleBackColor = true;
			this.btnNoAuditDirectory.Click += new System.EventHandler(this.btnNoAuditDirectory_Click);
			// 
			// groupBoxCommon
			// 
			this.groupBoxCommon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxCommon.Controls.Add(this.btnNoAuditAll);
			this.groupBoxCommon.Controls.Add(this.btnAuditAll);
			this.groupBoxCommon.Location = new System.Drawing.Point(3, 3);
			this.groupBoxCommon.Name = "groupBoxCommon";
			this.groupBoxCommon.Size = new System.Drawing.Size(394, 48);
			this.groupBoxCommon.TabIndex = 0;
			this.groupBoxCommon.TabStop = false;
			this.groupBoxCommon.Text = "Common";
			// 
			// btnAuditAll
			// 
			this.btnAuditAll.Location = new System.Drawing.Point(6, 19);
			this.btnAuditAll.Name = "btnAuditAll";
			this.btnAuditAll.Size = new System.Drawing.Size(150, 23);
			this.btnAuditAll.TabIndex = 0;
			this.btnAuditAll.Text = "Audit all";
			this.btnAuditAll.UseVisualStyleBackColor = true;
			this.btnAuditAll.Click += new System.EventHandler(this.btnAuditAll_Click);
			// 
			// btnNoAuditAll
			// 
			this.btnNoAuditAll.Location = new System.Drawing.Point(162, 19);
			this.btnNoAuditAll.Name = "btnNoAuditAll";
			this.btnNoAuditAll.Size = new System.Drawing.Size(150, 23);
			this.btnNoAuditAll.TabIndex = 1;
			this.btnNoAuditAll.Text = "No audit all";
			this.btnNoAuditAll.UseVisualStyleBackColor = true;
			this.btnNoAuditAll.Click += new System.EventHandler(this.btnNoAuditAll_Click);
			// 
			// btnAuditAllPrivileges
			// 
			this.btnAuditAllPrivileges.Location = new System.Drawing.Point(6, 19);
			this.btnAuditAllPrivileges.Name = "btnAuditAllPrivileges";
			this.btnAuditAllPrivileges.Size = new System.Drawing.Size(150, 23);
			this.btnAuditAllPrivileges.TabIndex = 0;
			this.btnAuditAllPrivileges.Text = "Audit all privileges";
			this.btnAuditAllPrivileges.UseVisualStyleBackColor = true;
			this.btnAuditAllPrivileges.Click += new System.EventHandler(this.btnAuditAllPrivileges_Click);
			// 
			// btnNoAuditAllPrivileges
			// 
			this.btnNoAuditAllPrivileges.Location = new System.Drawing.Point(162, 19);
			this.btnNoAuditAllPrivileges.Name = "btnNoAuditAllPrivileges";
			this.btnNoAuditAllPrivileges.Size = new System.Drawing.Size(150, 23);
			this.btnNoAuditAllPrivileges.TabIndex = 1;
			this.btnNoAuditAllPrivileges.Text = "No audit all privileges";
			this.btnNoAuditAllPrivileges.UseVisualStyleBackColor = true;
			this.btnNoAuditAllPrivileges.Click += new System.EventHandler(this.btnNoAuditAllPrivileges_Click);
			// 
			// groupBoxAuditPrivileges
			// 
			this.groupBoxAuditPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAuditPrivileges.Controls.Add(this.btnNoAuditAllPrivileges);
			this.groupBoxAuditPrivileges.Controls.Add(this.btnAuditAllPrivileges);
			this.groupBoxAuditPrivileges.Location = new System.Drawing.Point(3, 127);
			this.groupBoxAuditPrivileges.Name = "groupBoxAuditPrivileges";
			this.groupBoxAuditPrivileges.Size = new System.Drawing.Size(394, 48);
			this.groupBoxAuditPrivileges.TabIndex = 2;
			this.groupBoxAuditPrivileges.TabStop = false;
			this.groupBoxAuditPrivileges.Text = "Audit privileges";
			// 
			// AuditOtherControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxAuditPrivileges);
			this.Controls.Add(this.groupBoxCommon);
			this.Controls.Add(this.groupBoxAuditDirectory);
			this.Controls.Add(this.AuditRole);
			this.Name = "AuditOtherControl";
			this.Size = new System.Drawing.Size(400, 400);
			this.AuditRole.ResumeLayout(false);
			this.AuditRole.PerformLayout();
			this.groupBoxAuditDirectory.ResumeLayout(false);
			this.groupBoxCommon.ResumeLayout(false);
			this.groupBoxAuditPrivileges.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAuditCreateAnyDirectory;
		private System.Windows.Forms.Button btnNoauditCreateAnyDirectory;
		private System.Windows.Forms.GroupBox AuditRole;
		private System.Windows.Forms.CheckBox cbxWheneverNotSuccessful;
		private System.Windows.Forms.CheckBox cbxWheneverSuccessful;
		private System.Windows.Forms.Button btnAuditRole;
		private System.Windows.Forms.GroupBox groupBoxAuditDirectory;
		private System.Windows.Forms.Button btnNoAuditDirectory;
		private System.Windows.Forms.Button btnAuditDirectory;
		private System.Windows.Forms.GroupBox groupBoxCommon;
		private System.Windows.Forms.Button btnAuditAll;
		private System.Windows.Forms.Button btnNoAuditAll;
		private System.Windows.Forms.Button btnAuditAllPrivileges;
		private System.Windows.Forms.Button btnNoAuditAllPrivileges;
		private System.Windows.Forms.GroupBox groupBoxAuditPrivileges;
	}
}
