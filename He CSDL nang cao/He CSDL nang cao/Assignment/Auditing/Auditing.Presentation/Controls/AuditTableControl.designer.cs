namespace Auditing.Presentation.Controls
{
	partial class AuditTableControl
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
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.gbxManageTable = new System.Windows.Forms.GroupBox();
			this.btnAuditTable = new System.Windows.Forms.Button();
			this.btnNewTable = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.gbxOutputMessage = new System.Windows.Forms.GroupBox();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.gbxManageTable.SuspendLayout();
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
			this.splitContainer.Panel1.Controls.Add(this.gbxManageTable);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.gbxOutputMessage);
			this.splitContainer.Size = new System.Drawing.Size(400, 300);
			this.splitContainer.SplitterDistance = 133;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
			// 
			// gbxManageTable
			// 
			this.gbxManageTable.Controls.Add(this.btnAuditTable);
			this.gbxManageTable.Controls.Add(this.btnNewTable);
			this.gbxManageTable.Controls.Add(this.dataGridView);
			this.gbxManageTable.Controls.Add(this.btnSearch);
			this.gbxManageTable.Controls.Add(this.txtSearch);
			this.gbxManageTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxManageTable.Location = new System.Drawing.Point(0, 0);
			this.gbxManageTable.Name = "gbxManageTable";
			this.gbxManageTable.Size = new System.Drawing.Size(400, 133);
			this.gbxManageTable.TabIndex = 0;
			this.gbxManageTable.TabStop = false;
			this.gbxManageTable.Text = "Manage table";
			// 
			// btnAuditTable
			// 
			this.btnAuditTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuditTable.Location = new System.Drawing.Point(319, 104);
			this.btnAuditTable.Name = "btnAuditTable";
			this.btnAuditTable.Size = new System.Drawing.Size(75, 23);
			this.btnAuditTable.TabIndex = 4;
			this.btnAuditTable.Text = "Au&dit table";
			this.btnAuditTable.UseVisualStyleBackColor = true;
			this.btnAuditTable.Click += new System.EventHandler(this.btnAuditTable_Click);
			// 
			// btnNewTable
			// 
			this.btnNewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewTable.Location = new System.Drawing.Point(8, 104);
			this.btnNewTable.Name = "btnNewTable";
			this.btnNewTable.Size = new System.Drawing.Size(75, 23);
			this.btnNewTable.TabIndex = 3;
			this.btnNewTable.Text = "&New table";
			this.btnNewTable.UseVisualStyleBackColor = true;
			this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOwner,
            this.colTableName,
            this.colDelete});
			this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView.Location = new System.Drawing.Point(8, 47);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 30;
			this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView.Size = new System.Drawing.Size(386, 51);
			this.dataGridView.TabIndex = 2;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// colOwner
			// 
			this.colOwner.DataPropertyName = "Owner";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.ReadOnly = true;
			// 
			// colTableName
			// 
			this.colTableName.DataPropertyName = "TableName";
			this.colTableName.HeaderText = "Table name";
			this.colTableName.Name = "colTableName";
			this.colTableName.ReadOnly = true;
			// 
			// colDelete
			// 
			this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colDelete.HeaderText = "";
			this.colDelete.Image = global::Auditing.Presentation.Properties.Resources.Delete;
			this.colDelete.Name = "colDelete";
			this.colDelete.Width = 5;
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
			this.gbxOutputMessage.Size = new System.Drawing.Size(400, 163);
			this.gbxOutputMessage.TabIndex = 0;
			this.gbxOutputMessage.TabStop = false;
			this.gbxOutputMessage.Text = "Output message";
			// 
			// rtbOutput
			// 
			this.rtbOutput.BackColor = System.Drawing.Color.White;
			this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbOutput.Location = new System.Drawing.Point(3, 16);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.ReadOnly = true;
			this.rtbOutput.Size = new System.Drawing.Size(394, 144);
			this.rtbOutput.TabIndex = 0;
			this.rtbOutput.Text = "";
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::Auditing.Presentation.Properties.Resources.Delete;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			// 
			// AuditTableControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "AuditTableControl";
			this.Size = new System.Drawing.Size(400, 300);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.gbxManageTable.ResumeLayout(false);
			this.gbxManageTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.gbxOutputMessage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.GroupBox gbxOutputMessage;
		private System.Windows.Forms.GroupBox gbxManageTable;
		private System.Windows.Forms.RichTextBox rtbOutput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnNewTable;
		private System.Windows.Forms.Button btnAuditTable;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwner;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
		private System.Windows.Forms.DataGridViewImageColumn colDelete;
	}
}
