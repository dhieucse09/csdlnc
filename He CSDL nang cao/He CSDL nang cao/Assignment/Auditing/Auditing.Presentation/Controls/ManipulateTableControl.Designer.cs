namespace Auditing.Presentation.Controls
{
	partial class ManipulateTableControl
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
			this.groupBoxOutput = new System.Windows.Forms.GroupBox();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.groupBoxTable = new System.Windows.Forms.GroupBox();
			this.btnDeleteTable = new System.Windows.Forms.Button();
			this.btnDescribeTable = new System.Windows.Forms.Button();
			this.lblChooseATable = new System.Windows.Forms.Label();
			this.btnCreateSampleTable = new System.Windows.Forms.Button();
			this.btnListTables = new System.Windows.Forms.Button();
			this.cbxTable = new System.Windows.Forms.ComboBox();
			this.groupBoxSelect = new System.Windows.Forms.GroupBox();
			this.txtSelectWhere = new System.Windows.Forms.TextBox();
			this.lblSelectWhere = new System.Windows.Forms.Label();
			this.txtSelectFrom = new System.Windows.Forms.TextBox();
			this.lblSelectFrom = new System.Windows.Forms.Label();
			this.txtSelectColumns = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.groupBoxInsert = new System.Windows.Forms.GroupBox();
			this.txtInsertValues = new System.Windows.Forms.TextBox();
			this.lblValues = new System.Windows.Forms.Label();
			this.txtInsertTable = new System.Windows.Forms.TextBox();
			this.btnInsertInto = new System.Windows.Forms.Button();
			this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
			this.txtUpdateWhere = new System.Windows.Forms.TextBox();
			this.lblUpdateWhere = new System.Windows.Forms.Label();
			this.txtUpdateSet = new System.Windows.Forms.TextBox();
			this.lblUpdateSet = new System.Windows.Forms.Label();
			this.txtUpdateTable = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.groupBoxOutput.SuspendLayout();
			this.groupBoxTable.SuspendLayout();
			this.groupBoxSelect.SuspendLayout();
			this.groupBoxInsert.SuspendLayout();
			this.groupBoxUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxOutput
			// 
			this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxOutput.Controls.Add(this.rtbOutput);
			this.groupBoxOutput.Location = new System.Drawing.Point(3, 405);
			this.groupBoxOutput.Name = "groupBoxOutput";
			this.groupBoxOutput.Size = new System.Drawing.Size(394, 57);
			this.groupBoxOutput.TabIndex = 4;
			this.groupBoxOutput.TabStop = false;
			this.groupBoxOutput.Text = "Output";
			// 
			// rtbOutput
			// 
			this.rtbOutput.BackColor = System.Drawing.Color.White;
			this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbOutput.Location = new System.Drawing.Point(3, 16);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.ReadOnly = true;
			this.rtbOutput.Size = new System.Drawing.Size(388, 38);
			this.rtbOutput.TabIndex = 0;
			this.rtbOutput.Text = "";
			// 
			// groupBoxTable
			// 
			this.groupBoxTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxTable.Controls.Add(this.btnDeleteTable);
			this.groupBoxTable.Controls.Add(this.btnDescribeTable);
			this.groupBoxTable.Controls.Add(this.lblChooseATable);
			this.groupBoxTable.Controls.Add(this.btnCreateSampleTable);
			this.groupBoxTable.Controls.Add(this.btnListTables);
			this.groupBoxTable.Controls.Add(this.cbxTable);
			this.groupBoxTable.Location = new System.Drawing.Point(3, 3);
			this.groupBoxTable.Name = "groupBoxTable";
			this.groupBoxTable.Size = new System.Drawing.Size(394, 105);
			this.groupBoxTable.TabIndex = 0;
			this.groupBoxTable.TabStop = false;
			this.groupBoxTable.Text = "Table";
			// 
			// btnDeleteTable
			// 
			this.btnDeleteTable.Enabled = false;
			this.btnDeleteTable.Location = new System.Drawing.Point(137, 76);
			this.btnDeleteTable.Name = "btnDeleteTable";
			this.btnDeleteTable.Size = new System.Drawing.Size(125, 23);
			this.btnDeleteTable.TabIndex = 5;
			this.btnDeleteTable.Text = "Delete table";
			this.btnDeleteTable.UseVisualStyleBackColor = true;
			this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
			// 
			// btnDescribeTable
			// 
			this.btnDescribeTable.Enabled = false;
			this.btnDescribeTable.Location = new System.Drawing.Point(6, 76);
			this.btnDescribeTable.Name = "btnDescribeTable";
			this.btnDescribeTable.Size = new System.Drawing.Size(125, 23);
			this.btnDescribeTable.TabIndex = 4;
			this.btnDescribeTable.Text = "Describe table";
			this.btnDescribeTable.UseVisualStyleBackColor = true;
			this.btnDescribeTable.Click += new System.EventHandler(this.btnDescribeTable_Click);
			// 
			// lblChooseATable
			// 
			this.lblChooseATable.AutoSize = true;
			this.lblChooseATable.Location = new System.Drawing.Point(56, 51);
			this.lblChooseATable.Name = "lblChooseATable";
			this.lblChooseATable.Size = new System.Drawing.Size(81, 13);
			this.lblChooseATable.TabIndex = 0;
			this.lblChooseATable.Text = "Choose a table:";
			// 
			// btnCreateSampleTable
			// 
			this.btnCreateSampleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateSampleTable.Location = new System.Drawing.Point(263, 19);
			this.btnCreateSampleTable.Name = "btnCreateSampleTable";
			this.btnCreateSampleTable.Size = new System.Drawing.Size(125, 23);
			this.btnCreateSampleTable.TabIndex = 2;
			this.btnCreateSampleTable.Text = "Create sample table";
			this.btnCreateSampleTable.UseVisualStyleBackColor = true;
			this.btnCreateSampleTable.Click += new System.EventHandler(this.btnCreateSampleTable_Click);
			// 
			// btnListTables
			// 
			this.btnListTables.Location = new System.Drawing.Point(6, 19);
			this.btnListTables.Name = "btnListTables";
			this.btnListTables.Size = new System.Drawing.Size(125, 23);
			this.btnListTables.TabIndex = 1;
			this.btnListTables.Text = "List tables";
			this.btnListTables.UseVisualStyleBackColor = true;
			this.btnListTables.Click += new System.EventHandler(this.btnListTables_Click);
			// 
			// cbxTable
			// 
			this.cbxTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbxTable.FormattingEnabled = true;
			this.cbxTable.Location = new System.Drawing.Point(137, 48);
			this.cbxTable.Name = "cbxTable";
			this.cbxTable.Size = new System.Drawing.Size(248, 21);
			this.cbxTable.TabIndex = 3;
			this.cbxTable.SelectedIndexChanged += new System.EventHandler(this.cbxTable_SelectedIndexChanged);
			this.cbxTable.TextChanged += new System.EventHandler(this.cbxTable_TextChanged);
			// 
			// groupBoxSelect
			// 
			this.groupBoxSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSelect.Controls.Add(this.txtSelectWhere);
			this.groupBoxSelect.Controls.Add(this.lblSelectWhere);
			this.groupBoxSelect.Controls.Add(this.txtSelectFrom);
			this.groupBoxSelect.Controls.Add(this.lblSelectFrom);
			this.groupBoxSelect.Controls.Add(this.txtSelectColumns);
			this.groupBoxSelect.Controls.Add(this.btnSelect);
			this.groupBoxSelect.Enabled = false;
			this.groupBoxSelect.Location = new System.Drawing.Point(3, 114);
			this.groupBoxSelect.Name = "groupBoxSelect";
			this.groupBoxSelect.Size = new System.Drawing.Size(394, 100);
			this.groupBoxSelect.TabIndex = 1;
			this.groupBoxSelect.TabStop = false;
			this.groupBoxSelect.Text = "Select";
			// 
			// txtSelectWhere
			// 
			this.txtSelectWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelectWhere.Location = new System.Drawing.Point(137, 73);
			this.txtSelectWhere.Name = "txtSelectWhere";
			this.txtSelectWhere.Size = new System.Drawing.Size(251, 20);
			this.txtSelectWhere.TabIndex = 4;
			// 
			// lblSelectWhere
			// 
			this.lblSelectWhere.AutoSize = true;
			this.lblSelectWhere.Location = new System.Drawing.Point(98, 76);
			this.lblSelectWhere.Name = "lblSelectWhere";
			this.lblSelectWhere.Size = new System.Drawing.Size(39, 13);
			this.lblSelectWhere.TabIndex = 0;
			this.lblSelectWhere.Text = "Where";
			// 
			// txtSelectFrom
			// 
			this.txtSelectFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelectFrom.Location = new System.Drawing.Point(137, 47);
			this.txtSelectFrom.Name = "txtSelectFrom";
			this.txtSelectFrom.Size = new System.Drawing.Size(251, 20);
			this.txtSelectFrom.TabIndex = 3;
			this.txtSelectFrom.TextChanged += new System.EventHandler(this.txtSelect_TextChanged);
			// 
			// lblSelectFrom
			// 
			this.lblSelectFrom.AutoSize = true;
			this.lblSelectFrom.Location = new System.Drawing.Point(107, 50);
			this.lblSelectFrom.Name = "lblSelectFrom";
			this.lblSelectFrom.Size = new System.Drawing.Size(30, 13);
			this.lblSelectFrom.TabIndex = 0;
			this.lblSelectFrom.Text = "From";
			// 
			// txtSelectColumns
			// 
			this.txtSelectColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelectColumns.Location = new System.Drawing.Point(137, 21);
			this.txtSelectColumns.Name = "txtSelectColumns";
			this.txtSelectColumns.Size = new System.Drawing.Size(251, 20);
			this.txtSelectColumns.TabIndex = 2;
			this.txtSelectColumns.TextChanged += new System.EventHandler(this.txtSelect_TextChanged);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(6, 19);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(125, 23);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// groupBoxInsert
			// 
			this.groupBoxInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxInsert.Controls.Add(this.txtInsertValues);
			this.groupBoxInsert.Controls.Add(this.lblValues);
			this.groupBoxInsert.Controls.Add(this.txtInsertTable);
			this.groupBoxInsert.Controls.Add(this.btnInsertInto);
			this.groupBoxInsert.Enabled = false;
			this.groupBoxInsert.Location = new System.Drawing.Point(3, 220);
			this.groupBoxInsert.Name = "groupBoxInsert";
			this.groupBoxInsert.Size = new System.Drawing.Size(394, 73);
			this.groupBoxInsert.TabIndex = 2;
			this.groupBoxInsert.TabStop = false;
			this.groupBoxInsert.Text = "Insert";
			// 
			// txtInsertValues
			// 
			this.txtInsertValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtInsertValues.Location = new System.Drawing.Point(137, 47);
			this.txtInsertValues.Name = "txtInsertValues";
			this.txtInsertValues.Size = new System.Drawing.Size(251, 20);
			this.txtInsertValues.TabIndex = 3;
			this.txtInsertValues.TextChanged += new System.EventHandler(this.txtInsert_TextChanged);
			// 
			// lblValues
			// 
			this.lblValues.AutoSize = true;
			this.lblValues.Location = new System.Drawing.Point(98, 50);
			this.lblValues.Name = "lblValues";
			this.lblValues.Size = new System.Drawing.Size(39, 13);
			this.lblValues.TabIndex = 0;
			this.lblValues.Text = "Values";
			// 
			// txtInsertTable
			// 
			this.txtInsertTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtInsertTable.Location = new System.Drawing.Point(137, 21);
			this.txtInsertTable.Name = "txtInsertTable";
			this.txtInsertTable.Size = new System.Drawing.Size(251, 20);
			this.txtInsertTable.TabIndex = 2;
			this.txtInsertTable.TextChanged += new System.EventHandler(this.txtInsert_TextChanged);
			// 
			// btnInsertInto
			// 
			this.btnInsertInto.Location = new System.Drawing.Point(6, 19);
			this.btnInsertInto.Name = "btnInsertInto";
			this.btnInsertInto.Size = new System.Drawing.Size(125, 23);
			this.btnInsertInto.TabIndex = 1;
			this.btnInsertInto.Text = "Insert Into";
			this.btnInsertInto.UseVisualStyleBackColor = true;
			this.btnInsertInto.Click += new System.EventHandler(this.btnInsertInto_Click);
			// 
			// groupBoxUpdate
			// 
			this.groupBoxUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxUpdate.Controls.Add(this.txtUpdateWhere);
			this.groupBoxUpdate.Controls.Add(this.lblUpdateWhere);
			this.groupBoxUpdate.Controls.Add(this.txtUpdateSet);
			this.groupBoxUpdate.Controls.Add(this.lblUpdateSet);
			this.groupBoxUpdate.Controls.Add(this.txtUpdateTable);
			this.groupBoxUpdate.Controls.Add(this.btnUpdate);
			this.groupBoxUpdate.Enabled = false;
			this.groupBoxUpdate.Location = new System.Drawing.Point(3, 299);
			this.groupBoxUpdate.Name = "groupBoxUpdate";
			this.groupBoxUpdate.Size = new System.Drawing.Size(394, 100);
			this.groupBoxUpdate.TabIndex = 3;
			this.groupBoxUpdate.TabStop = false;
			this.groupBoxUpdate.Text = "Update";
			// 
			// txtUpdateWhere
			// 
			this.txtUpdateWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUpdateWhere.Location = new System.Drawing.Point(137, 73);
			this.txtUpdateWhere.Name = "txtUpdateWhere";
			this.txtUpdateWhere.Size = new System.Drawing.Size(251, 20);
			this.txtUpdateWhere.TabIndex = 4;
			this.txtUpdateWhere.TextChanged += new System.EventHandler(this.txtUpdate_TextChanged);
			// 
			// lblUpdateWhere
			// 
			this.lblUpdateWhere.AutoSize = true;
			this.lblUpdateWhere.Location = new System.Drawing.Point(98, 76);
			this.lblUpdateWhere.Name = "lblUpdateWhere";
			this.lblUpdateWhere.Size = new System.Drawing.Size(39, 13);
			this.lblUpdateWhere.TabIndex = 0;
			this.lblUpdateWhere.Text = "Where";
			// 
			// txtUpdateSet
			// 
			this.txtUpdateSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUpdateSet.Location = new System.Drawing.Point(137, 47);
			this.txtUpdateSet.Name = "txtUpdateSet";
			this.txtUpdateSet.Size = new System.Drawing.Size(251, 20);
			this.txtUpdateSet.TabIndex = 3;
			this.txtUpdateSet.TextChanged += new System.EventHandler(this.txtUpdate_TextChanged);
			// 
			// lblUpdateSet
			// 
			this.lblUpdateSet.AutoSize = true;
			this.lblUpdateSet.Location = new System.Drawing.Point(114, 50);
			this.lblUpdateSet.Name = "lblUpdateSet";
			this.lblUpdateSet.Size = new System.Drawing.Size(23, 13);
			this.lblUpdateSet.TabIndex = 0;
			this.lblUpdateSet.Text = "Set";
			// 
			// txtUpdateTable
			// 
			this.txtUpdateTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUpdateTable.Location = new System.Drawing.Point(137, 21);
			this.txtUpdateTable.Name = "txtUpdateTable";
			this.txtUpdateTable.Size = new System.Drawing.Size(251, 20);
			this.txtUpdateTable.TabIndex = 2;
			this.txtUpdateTable.TextChanged += new System.EventHandler(this.txtUpdate_TextChanged);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(6, 19);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(125, 23);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// ManipulateTableControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxOutput);
			this.Controls.Add(this.groupBoxUpdate);
			this.Controls.Add(this.groupBoxInsert);
			this.Controls.Add(this.groupBoxSelect);
			this.Controls.Add(this.groupBoxTable);
			this.Name = "ManipulateTableControl";
			this.Size = new System.Drawing.Size(400, 465);
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxTable.ResumeLayout(false);
			this.groupBoxTable.PerformLayout();
			this.groupBoxSelect.ResumeLayout(false);
			this.groupBoxSelect.PerformLayout();
			this.groupBoxInsert.ResumeLayout(false);
			this.groupBoxInsert.PerformLayout();
			this.groupBoxUpdate.ResumeLayout(false);
			this.groupBoxUpdate.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxOutput;
		private System.Windows.Forms.GroupBox groupBoxTable;
		private System.Windows.Forms.Button btnListTables;
		private System.Windows.Forms.ComboBox cbxTable;
		private System.Windows.Forms.Label lblChooseATable;
		private System.Windows.Forms.Button btnCreateSampleTable;
		private System.Windows.Forms.Button btnDescribeTable;
		private System.Windows.Forms.GroupBox groupBoxSelect;
		private System.Windows.Forms.TextBox txtSelectFrom;
		private System.Windows.Forms.Label lblSelectFrom;
		private System.Windows.Forms.TextBox txtSelectColumns;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.TextBox txtSelectWhere;
		private System.Windows.Forms.Label lblSelectWhere;
		private System.Windows.Forms.GroupBox groupBoxInsert;
		private System.Windows.Forms.Button btnDeleteTable;
		private System.Windows.Forms.TextBox txtInsertValues;
		private System.Windows.Forms.Label lblValues;
		private System.Windows.Forms.TextBox txtInsertTable;
		private System.Windows.Forms.Button btnInsertInto;
		private System.Windows.Forms.GroupBox groupBoxUpdate;
		private System.Windows.Forms.TextBox txtUpdateWhere;
		private System.Windows.Forms.Label lblUpdateWhere;
		private System.Windows.Forms.TextBox txtUpdateSet;
		private System.Windows.Forms.Label lblUpdateSet;
		private System.Windows.Forms.TextBox txtUpdateTable;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.RichTextBox rtbOutput;
	}
}
