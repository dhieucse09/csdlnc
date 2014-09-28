namespace Auditing.Presentation.Forms
{
	partial class AuditTableForm
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
			this.cbxAudit = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBoxStatement = new System.Windows.Forms.GroupBox();
			this.cbxStatementAlter = new System.Windows.Forms.CheckBox();
			this.cbxStatementGrant = new System.Windows.Forms.CheckBox();
			this.cbxStatementDelete = new System.Windows.Forms.CheckBox();
			this.cbxStatementUpdate = new System.Windows.Forms.CheckBox();
			this.cbxStatementInsert = new System.Windows.Forms.CheckBox();
			this.cbxStatementSelect = new System.Windows.Forms.CheckBox();
			this.rbtBySession = new System.Windows.Forms.RadioButton();
			this.rbtByAccess = new System.Windows.Forms.RadioButton();
			this.groupBoxAuditWhen = new System.Windows.Forms.GroupBox();
			this.cbxWheneverUnsuccessful = new System.Windows.Forms.CheckBox();
			this.cbxWheneverSuccessful = new System.Windows.Forms.CheckBox();
			this.groupBoxAuditUsers = new System.Windows.Forms.GroupBox();
			this.groupBoxStatement.SuspendLayout();
			this.groupBoxAuditWhen.SuspendLayout();
			this.groupBoxAuditUsers.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbxAudit
			// 
			this.cbxAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbxAudit.AutoSize = true;
			this.cbxAudit.Checked = true;
			this.cbxAudit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxAudit.Location = new System.Drawing.Point(7, 167);
			this.cbxAudit.Name = "cbxAudit";
			this.cbxAudit.Size = new System.Drawing.Size(95, 17);
			this.cbxAudit.TabIndex = 0;
			this.cbxAudit.Text = "Audit this table";
			this.cbxAudit.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(221, 163);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(302, 163);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// groupBoxStatement
			// 
			this.groupBoxStatement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxStatement.Controls.Add(this.cbxStatementAlter);
			this.groupBoxStatement.Controls.Add(this.cbxStatementGrant);
			this.groupBoxStatement.Controls.Add(this.cbxStatementDelete);
			this.groupBoxStatement.Controls.Add(this.cbxStatementUpdate);
			this.groupBoxStatement.Controls.Add(this.cbxStatementInsert);
			this.groupBoxStatement.Controls.Add(this.cbxStatementSelect);
			this.groupBoxStatement.Location = new System.Drawing.Point(7, 12);
			this.groupBoxStatement.Name = "groupBoxStatement";
			this.groupBoxStatement.Size = new System.Drawing.Size(370, 40);
			this.groupBoxStatement.TabIndex = 0;
			this.groupBoxStatement.TabStop = false;
			this.groupBoxStatement.Text = "Audit statements";
			// 
			// cbxStatementAlter
			// 
			this.cbxStatementAlter.AutoSize = true;
			this.cbxStatementAlter.Checked = true;
			this.cbxStatementAlter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementAlter.Location = new System.Drawing.Point(256, 19);
			this.cbxStatementAlter.Name = "cbxStatementAlter";
			this.cbxStatementAlter.Size = new System.Drawing.Size(47, 17);
			this.cbxStatementAlter.TabIndex = 6;
			this.cbxStatementAlter.Text = "Alter";
			this.cbxStatementAlter.UseVisualStyleBackColor = true;
			// 
			// cbxStatementGrant
			// 
			this.cbxStatementGrant.AutoSize = true;
			this.cbxStatementGrant.Checked = true;
			this.cbxStatementGrant.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementGrant.Location = new System.Drawing.Point(308, 19);
			this.cbxStatementGrant.Name = "cbxStatementGrant";
			this.cbxStatementGrant.Size = new System.Drawing.Size(52, 17);
			this.cbxStatementGrant.TabIndex = 7;
			this.cbxStatementGrant.Text = "Grant";
			this.cbxStatementGrant.UseVisualStyleBackColor = true;
			// 
			// cbxStatementDelete
			// 
			this.cbxStatementDelete.AutoSize = true;
			this.cbxStatementDelete.Checked = true;
			this.cbxStatementDelete.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxStatementDelete.Location = new System.Drawing.Point(194, 19);
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
			this.cbxStatementUpdate.Location = new System.Drawing.Point(128, 19);
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
			this.cbxStatementInsert.Location = new System.Drawing.Point(71, 19);
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
			this.cbxStatementSelect.Location = new System.Drawing.Point(10, 19);
			this.cbxStatementSelect.Name = "cbxStatementSelect";
			this.cbxStatementSelect.Size = new System.Drawing.Size(56, 17);
			this.cbxStatementSelect.TabIndex = 2;
			this.cbxStatementSelect.Text = "Select";
			this.cbxStatementSelect.UseVisualStyleBackColor = true;
			// 
			// rbtBySession
			// 
			this.rbtBySession.AutoSize = true;
			this.rbtBySession.Checked = true;
			this.rbtBySession.Location = new System.Drawing.Point(87, 19);
			this.rbtBySession.Name = "rbtBySession";
			this.rbtBySession.Size = new System.Drawing.Size(75, 17);
			this.rbtBySession.TabIndex = 4;
			this.rbtBySession.TabStop = true;
			this.rbtBySession.Text = "By session";
			this.rbtBySession.UseVisualStyleBackColor = true;
			// 
			// rbtByAccess
			// 
			this.rbtByAccess.AutoSize = true;
			this.rbtByAccess.Location = new System.Drawing.Point(5, 19);
			this.rbtByAccess.Name = "rbtByAccess";
			this.rbtByAccess.Size = new System.Drawing.Size(74, 17);
			this.rbtByAccess.TabIndex = 3;
			this.rbtByAccess.TabStop = true;
			this.rbtByAccess.Text = "By access";
			this.rbtByAccess.UseVisualStyleBackColor = true;
			// 
			// groupBoxAuditWhen
			// 
			this.groupBoxAuditWhen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAuditWhen.Controls.Add(this.cbxWheneverUnsuccessful);
			this.groupBoxAuditWhen.Controls.Add(this.cbxWheneverSuccessful);
			this.groupBoxAuditWhen.Location = new System.Drawing.Point(7, 104);
			this.groupBoxAuditWhen.Name = "groupBoxAuditWhen";
			this.groupBoxAuditWhen.Size = new System.Drawing.Size(370, 40);
			this.groupBoxAuditWhen.TabIndex = 4;
			this.groupBoxAuditWhen.TabStop = false;
			this.groupBoxAuditWhen.Text = "Audit when";
			// 
			// cbxWheneverUnsuccessful
			// 
			this.cbxWheneverUnsuccessful.AutoSize = true;
			this.cbxWheneverUnsuccessful.Location = new System.Drawing.Point(150, 17);
			this.cbxWheneverUnsuccessful.Name = "cbxWheneverUnsuccessful";
			this.cbxWheneverUnsuccessful.Size = new System.Drawing.Size(141, 17);
			this.cbxWheneverUnsuccessful.TabIndex = 1;
			this.cbxWheneverUnsuccessful.Text = "Whenever unsuccessful";
			this.cbxWheneverUnsuccessful.UseVisualStyleBackColor = true;
			// 
			// cbxWheneverSuccessful
			// 
			this.cbxWheneverSuccessful.AutoSize = true;
			this.cbxWheneverSuccessful.Location = new System.Drawing.Point(6, 19);
			this.cbxWheneverSuccessful.Name = "cbxWheneverSuccessful";
			this.cbxWheneverSuccessful.Size = new System.Drawing.Size(129, 17);
			this.cbxWheneverSuccessful.TabIndex = 0;
			this.cbxWheneverSuccessful.Text = "Whenever successful";
			this.cbxWheneverSuccessful.UseVisualStyleBackColor = true;
			// 
			// groupBoxAuditUsers
			// 
			this.groupBoxAuditUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAuditUsers.Controls.Add(this.rbtByAccess);
			this.groupBoxAuditUsers.Controls.Add(this.rbtBySession);
			this.groupBoxAuditUsers.Location = new System.Drawing.Point(7, 58);
			this.groupBoxAuditUsers.Name = "groupBoxAuditUsers";
			this.groupBoxAuditUsers.Size = new System.Drawing.Size(370, 40);
			this.groupBoxAuditUsers.TabIndex = 3;
			this.groupBoxAuditUsers.TabStop = false;
			this.groupBoxAuditUsers.Text = "Audit by";
			// 
			// AuditTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(384, 192);
			this.Controls.Add(this.groupBoxAuditWhen);
			this.Controls.Add(this.groupBoxAuditUsers);
			this.Controls.Add(this.groupBoxStatement);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cbxAudit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuditTableForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Audit table";
			this.groupBoxStatement.ResumeLayout(false);
			this.groupBoxStatement.PerformLayout();
			this.groupBoxAuditWhen.ResumeLayout(false);
			this.groupBoxAuditWhen.PerformLayout();
			this.groupBoxAuditUsers.ResumeLayout(false);
			this.groupBoxAuditUsers.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxAudit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBoxStatement;
		private System.Windows.Forms.CheckBox cbxStatementDelete;
		private System.Windows.Forms.CheckBox cbxStatementUpdate;
		private System.Windows.Forms.CheckBox cbxStatementInsert;
		private System.Windows.Forms.CheckBox cbxStatementSelect;
		private System.Windows.Forms.GroupBox groupBoxAuditWhen;
		private System.Windows.Forms.CheckBox cbxWheneverUnsuccessful;
		private System.Windows.Forms.CheckBox cbxWheneverSuccessful;
		private System.Windows.Forms.RadioButton rbtBySession;
		private System.Windows.Forms.RadioButton rbtByAccess;
		private System.Windows.Forms.CheckBox cbxStatementAlter;
		private System.Windows.Forms.CheckBox cbxStatementGrant;
		private System.Windows.Forms.GroupBox groupBoxAuditUsers;
	}
}