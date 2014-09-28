namespace Auditing.Presentation.Forms
{
	partial class AuditUserForm
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
			this.groupBoxAuditWhen = new System.Windows.Forms.GroupBox();
			this.cbxWheneverUnsuccessful = new System.Windows.Forms.CheckBox();
			this.cbxWheneverSuccessful = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbxAudit = new System.Windows.Forms.CheckBox();
			this.groupBoxAuditUserActions = new System.Windows.Forms.GroupBox();
			this.cbxExecuteProcedure = new System.Windows.Forms.CheckBox();
			this.cbxStatementDelete = new System.Windows.Forms.CheckBox();
			this.cbxStatementUpdate = new System.Windows.Forms.CheckBox();
			this.cbxStatementInsert = new System.Windows.Forms.CheckBox();
			this.cbxStatementSelect = new System.Windows.Forms.CheckBox();
			this.cbxWhenUserLogon = new System.Windows.Forms.CheckBox();
			this.cbxWhenUserChangePassword = new System.Windows.Forms.CheckBox();
			this.groupBoxAuditWhen.SuspendLayout();
			this.groupBoxAuditUserActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxAuditWhen
			// 
			this.groupBoxAuditWhen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAuditWhen.Controls.Add(this.cbxWheneverUnsuccessful);
			this.groupBoxAuditWhen.Controls.Add(this.cbxWheneverSuccessful);
			this.groupBoxAuditWhen.Location = new System.Drawing.Point(7, 88);
			this.groupBoxAuditWhen.Name = "groupBoxAuditWhen";
			this.groupBoxAuditWhen.Size = new System.Drawing.Size(430, 40);
			this.groupBoxAuditWhen.TabIndex = 2;
			this.groupBoxAuditWhen.TabStop = false;
			this.groupBoxAuditWhen.Text = "Audit when";
			// 
			// cbxWheneverUnsuccessful
			// 
			this.cbxWheneverUnsuccessful.AutoSize = true;
			this.cbxWheneverUnsuccessful.Checked = true;
			this.cbxWheneverUnsuccessful.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxWheneverUnsuccessful.Location = new System.Drawing.Point(150, 17);
			this.cbxWheneverUnsuccessful.Name = "cbxWheneverUnsuccessful";
			this.cbxWheneverUnsuccessful.Size = new System.Drawing.Size(144, 17);
			this.cbxWheneverUnsuccessful.TabIndex = 1;
			this.cbxWheneverUnsuccessful.Text = "Whenever unsuccessful.";
			this.cbxWheneverUnsuccessful.UseVisualStyleBackColor = true;
			// 
			// cbxWheneverSuccessful
			// 
			this.cbxWheneverSuccessful.AutoSize = true;
			this.cbxWheneverSuccessful.Checked = true;
			this.cbxWheneverSuccessful.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxWheneverSuccessful.Location = new System.Drawing.Point(6, 19);
			this.cbxWheneverSuccessful.Name = "cbxWheneverSuccessful";
			this.cbxWheneverSuccessful.Size = new System.Drawing.Size(132, 17);
			this.cbxWheneverSuccessful.TabIndex = 0;
			this.cbxWheneverSuccessful.Text = "Whenever successful.";
			this.cbxWheneverSuccessful.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(362, 133);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(281, 133);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbxAudit
			// 
			this.cbxAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbxAudit.AutoSize = true;
			this.cbxAudit.Checked = true;
			this.cbxAudit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxAudit.Location = new System.Drawing.Point(7, 137);
			this.cbxAudit.Name = "cbxAudit";
			this.cbxAudit.Size = new System.Drawing.Size(92, 17);
			this.cbxAudit.TabIndex = 3;
			this.cbxAudit.Text = "Audit this user";
			this.cbxAudit.UseVisualStyleBackColor = true;
			// 
			// groupBoxAuditUserActions
			// 
			this.groupBoxAuditUserActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAuditUserActions.Controls.Add(this.cbxWhenUserChangePassword);
			this.groupBoxAuditUserActions.Controls.Add(this.cbxWhenUserLogon);
			this.groupBoxAuditUserActions.Controls.Add(this.cbxExecuteProcedure);
			this.groupBoxAuditUserActions.Controls.Add(this.cbxStatementDelete);
			this.groupBoxAuditUserActions.Controls.Add(this.cbxStatementUpdate);
			this.groupBoxAuditUserActions.Controls.Add(this.cbxStatementInsert);
			this.groupBoxAuditUserActions.Controls.Add(this.cbxStatementSelect);
			this.groupBoxAuditUserActions.Location = new System.Drawing.Point(7, 12);
			this.groupBoxAuditUserActions.Name = "groupBoxAuditUserActions";
			this.groupBoxAuditUserActions.Size = new System.Drawing.Size(430, 70);
			this.groupBoxAuditUserActions.TabIndex = 0;
			this.groupBoxAuditUserActions.TabStop = false;
			this.groupBoxAuditUserActions.Text = "Audit user\'s actions";
			// 
			// cbxExecuteProcedure
			// 
			this.cbxExecuteProcedure.AutoSize = true;
			this.cbxExecuteProcedure.Checked = true;
			this.cbxExecuteProcedure.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxExecuteProcedure.Location = new System.Drawing.Point(256, 47);
			this.cbxExecuteProcedure.Name = "cbxExecuteProcedure";
			this.cbxExecuteProcedure.Size = new System.Drawing.Size(116, 17);
			this.cbxExecuteProcedure.TabIndex = 6;
			this.cbxExecuteProcedure.Text = "Execute procedure";
			this.cbxExecuteProcedure.UseVisualStyleBackColor = true;
			// 
			// cbxStatementDelete
			// 
			this.cbxStatementDelete.AutoSize = true;
			this.cbxStatementDelete.Checked = true;
			this.cbxStatementDelete.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementDelete.Location = new System.Drawing.Point(193, 47);
			this.cbxStatementDelete.Name = "cbxStatementDelete";
			this.cbxStatementDelete.Size = new System.Drawing.Size(57, 17);
			this.cbxStatementDelete.TabIndex = 5;
			this.cbxStatementDelete.Text = "Delete";
			this.cbxStatementDelete.UseVisualStyleBackColor = true;
			// 
			// cbxStatementUpdate
			// 
			this.cbxStatementUpdate.AutoSize = true;
			this.cbxStatementUpdate.Checked = true;
			this.cbxStatementUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementUpdate.Location = new System.Drawing.Point(126, 47);
			this.cbxStatementUpdate.Name = "cbxStatementUpdate";
			this.cbxStatementUpdate.Size = new System.Drawing.Size(61, 17);
			this.cbxStatementUpdate.TabIndex = 4;
			this.cbxStatementUpdate.Text = "Update";
			this.cbxStatementUpdate.UseVisualStyleBackColor = true;
			// 
			// cbxStatementInsert
			// 
			this.cbxStatementInsert.AutoSize = true;
			this.cbxStatementInsert.Checked = true;
			this.cbxStatementInsert.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementInsert.Location = new System.Drawing.Point(68, 47);
			this.cbxStatementInsert.Name = "cbxStatementInsert";
			this.cbxStatementInsert.Size = new System.Drawing.Size(52, 17);
			this.cbxStatementInsert.TabIndex = 3;
			this.cbxStatementInsert.Text = "Insert";
			this.cbxStatementInsert.UseVisualStyleBackColor = true;
			// 
			// cbxStatementSelect
			// 
			this.cbxStatementSelect.AutoSize = true;
			this.cbxStatementSelect.Checked = true;
			this.cbxStatementSelect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementSelect.Location = new System.Drawing.Point(6, 47);
			this.cbxStatementSelect.Name = "cbxStatementSelect";
			this.cbxStatementSelect.Size = new System.Drawing.Size(56, 17);
			this.cbxStatementSelect.TabIndex = 2;
			this.cbxStatementSelect.Text = "Select";
			this.cbxStatementSelect.UseVisualStyleBackColor = true;
			// 
			// cbxWhenUserLogon
			// 
			this.cbxWhenUserLogon.AutoSize = true;
			this.cbxWhenUserLogon.Checked = true;
			this.cbxWhenUserLogon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxWhenUserLogon.Location = new System.Drawing.Point(6, 19);
			this.cbxWhenUserLogon.Name = "cbxWhenUserLogon";
			this.cbxWhenUserLogon.Size = new System.Drawing.Size(110, 17);
			this.cbxWhenUserLogon.TabIndex = 0;
			this.cbxWhenUserLogon.Text = "When user log on";
			this.cbxWhenUserLogon.UseVisualStyleBackColor = true;
			// 
			// cbxWhenUserChangePassword
			// 
			this.cbxWhenUserChangePassword.AutoSize = true;
			this.cbxWhenUserChangePassword.Checked = true;
			this.cbxWhenUserChangePassword.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxWhenUserChangePassword.Location = new System.Drawing.Point(122, 19);
			this.cbxWhenUserChangePassword.Name = "cbxWhenUserChangePassword";
			this.cbxWhenUserChangePassword.Size = new System.Drawing.Size(165, 17);
			this.cbxWhenUserChangePassword.TabIndex = 1;
			this.cbxWhenUserChangePassword.Text = "When user change password";
			this.cbxWhenUserChangePassword.UseVisualStyleBackColor = true;
			// 
			// AuditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(444, 162);
			this.Controls.Add(this.groupBoxAuditUserActions);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBoxAuditWhen);
			this.Controls.Add(this.cbxAudit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuditUserForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Audit user";
			this.groupBoxAuditWhen.ResumeLayout(false);
			this.groupBoxAuditWhen.PerformLayout();
			this.groupBoxAuditUserActions.ResumeLayout(false);
			this.groupBoxAuditUserActions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxAuditWhen;
		private System.Windows.Forms.CheckBox cbxWheneverUnsuccessful;
		private System.Windows.Forms.CheckBox cbxWheneverSuccessful;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox cbxAudit;
		private System.Windows.Forms.GroupBox groupBoxAuditUserActions;
		private System.Windows.Forms.CheckBox cbxStatementDelete;
		private System.Windows.Forms.CheckBox cbxStatementUpdate;
		private System.Windows.Forms.CheckBox cbxStatementInsert;
		private System.Windows.Forms.CheckBox cbxStatementSelect;
		private System.Windows.Forms.CheckBox cbxExecuteProcedure;
		private System.Windows.Forms.CheckBox cbxWhenUserChangePassword;
		private System.Windows.Forms.CheckBox cbxWhenUserLogon;
	}
}