namespace Auditing.Presentation.Controls
{
	partial class AuditUsersControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.gbxManageUsers = new System.Windows.Forms.GroupBox();
			this.btnAuditUser = new System.Windows.Forms.Button();
			this.btnNewUser = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.gbxOutputMessage = new System.Windows.Forms.GroupBox();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlterUser = new System.Windows.Forms.DataGridViewImageColumn();
			this.colDeleteUser = new System.Windows.Forms.DataGridViewImageColumn();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.gbxManageUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.gbxOutputMessage.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.gbxManageUsers);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.gbxOutputMessage);
			this.splitContainer.Size = new System.Drawing.Size(400, 300);
			this.splitContainer.SplitterDistance = 133;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
			// 
			// gbxManageUsers
			// 
			this.gbxManageUsers.Controls.Add(this.btnAuditUser);
			this.gbxManageUsers.Controls.Add(this.btnNewUser);
			this.gbxManageUsers.Controls.Add(this.dataGridView);
			this.gbxManageUsers.Controls.Add(this.btnSearch);
			this.gbxManageUsers.Controls.Add(this.txtSearch);
			this.gbxManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxManageUsers.Location = new System.Drawing.Point(0, 0);
			this.gbxManageUsers.Name = "gbxManageUsers";
			this.gbxManageUsers.Size = new System.Drawing.Size(400, 133);
			this.gbxManageUsers.TabIndex = 0;
			this.gbxManageUsers.TabStop = false;
			this.gbxManageUsers.Text = "Manage users";
			// 
			// btnAuditUser
			// 
			this.btnAuditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuditUser.Location = new System.Drawing.Point(319, 104);
			this.btnAuditUser.Name = "btnAuditUser";
			this.btnAuditUser.Size = new System.Drawing.Size(75, 23);
			this.btnAuditUser.TabIndex = 4;
			this.btnAuditUser.Text = "Au&dit user";
			this.btnAuditUser.UseVisualStyleBackColor = true;
			this.btnAuditUser.Click += new System.EventHandler(this.btnAuditUser_Click);
			// 
			// btnNewUser
			// 
			this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewUser.Location = new System.Drawing.Point(8, 104);
			this.btnNewUser.Name = "btnNewUser";
			this.btnNewUser.Size = new System.Drawing.Size(75, 23);
			this.btnNewUser.TabIndex = 3;
			this.btnNewUser.Text = "&New user";
			this.btnNewUser.UseVisualStyleBackColor = true;
			this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.colUsername,
            this.colPassword,
            this.colAlterUser,
            this.colDeleteUser});
			this.dataGridView.Location = new System.Drawing.Point(8, 47);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.RowHeadersWidth = 30;
			this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView.Size = new System.Drawing.Size(386, 51);
			this.dataGridView.TabIndex = 2;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(319, 19);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Location = new System.Drawing.Point(8, 21);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(307, 20);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
			// 
			// gbxOutputMessage
			// 
			this.gbxOutputMessage.Controls.Add(this.rtbOutput);
			this.gbxOutputMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxOutputMessage.Location = new System.Drawing.Point(0, 0);
			this.gbxOutputMessage.Name = "gbxOutputMessage";
			this.gbxOutputMessage.Padding = new System.Windows.Forms.Padding(5);
			this.gbxOutputMessage.Size = new System.Drawing.Size(400, 163);
			this.gbxOutputMessage.TabIndex = 0;
			this.gbxOutputMessage.TabStop = false;
			this.gbxOutputMessage.Text = "Output message";
			// 
			// rtbOutput
			// 
			this.rtbOutput.BackColor = System.Drawing.Color.White;
			this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbOutput.Location = new System.Drawing.Point(5, 18);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.ReadOnly = true;
			this.rtbOutput.Size = new System.Drawing.Size(390, 140);
			this.rtbOutput.TabIndex = 0;
			this.rtbOutput.Text = "";
			// 
			// colUserId
			// 
			this.colUserId.DataPropertyName = "UserId";
			this.colUserId.HeaderText = "User Id";
			this.colUserId.Name = "colUserId";
			this.colUserId.ReadOnly = true;
			// 
			// colUsername
			// 
			this.colUsername.DataPropertyName = "UserName";
			this.colUsername.HeaderText = "Username";
			this.colUsername.Name = "colUsername";
			this.colUsername.ReadOnly = true;
			// 
			// colPassword
			// 
			this.colPassword.DataPropertyName = "Password";
			this.colPassword.HeaderText = "Password";
			this.colPassword.Name = "colPassword";
			this.colPassword.ReadOnly = true;
			// 
			// colAlterUser
			// 
			this.colAlterUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAlterUser.HeaderText = "";
			this.colAlterUser.Image = global::Auditing.Presentation.Properties.Resources.Edit;
			this.colAlterUser.Name = "colAlterUser";
			this.colAlterUser.ReadOnly = true;
			this.colAlterUser.Width = 5;
			// 
			// colDeleteUser
			// 
			this.colDeleteUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colDeleteUser.HeaderText = "";
			this.colDeleteUser.Image = global::Auditing.Presentation.Properties.Resources.Delete;
			this.colDeleteUser.Name = "colDeleteUser";
			this.colDeleteUser.ReadOnly = true;
			this.colDeleteUser.Width = 5;
			// 
			// AuditUsersControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "AuditUsersControl";
			this.Size = new System.Drawing.Size(400, 300);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.gbxManageUsers.ResumeLayout(false);
			this.gbxManageUsers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.gbxOutputMessage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.GroupBox gbxOutputMessage;
		private System.Windows.Forms.GroupBox gbxManageUsers;
		private System.Windows.Forms.RichTextBox rtbOutput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnNewUser;
		private System.Windows.Forms.Button btnAuditUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
		private System.Windows.Forms.DataGridViewImageColumn colAlterUser;
		private System.Windows.Forms.DataGridViewImageColumn colDeleteUser;
	}
}
