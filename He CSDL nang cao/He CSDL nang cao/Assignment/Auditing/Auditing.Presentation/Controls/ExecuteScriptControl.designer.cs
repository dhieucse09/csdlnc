namespace Auditing.Presentation.Controls
{
	partial class ExecuteScriptControl
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
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.btnExecute = new System.Windows.Forms.Button();
			this.rtbScript = new System.Windows.Forms.RichTextBox();
			this.linkClearOutput = new System.Windows.Forms.LinkLabel();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.gbxScript = new System.Windows.Forms.GroupBox();
			this.linkClearScript = new System.Windows.Forms.LinkLabel();
			this.lblSeperate2 = new System.Windows.Forms.Label();
			this.linkLoadScript = new System.Windows.Forms.LinkLabel();
			this.linkSaveScript = new System.Windows.Forms.LinkLabel();
			this.lblSeperate1 = new System.Windows.Forms.Label();
			this.gbxOutputMessage = new System.Windows.Forms.GroupBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.gbxScript.SuspendLayout();
			this.gbxOutputMessage.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbOutput
			// 
			this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbOutput.BackColor = System.Drawing.Color.White;
			this.rtbOutput.Location = new System.Drawing.Point(6, 19);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.ReadOnly = true;
			this.rtbOutput.Size = new System.Drawing.Size(388, 100);
			this.rtbOutput.TabIndex = 0;
			this.rtbOutput.Text = "";
			// 
			// btnExecute
			// 
			this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnExecute.Location = new System.Drawing.Point(6, 121);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(100, 23);
			this.btnExecute.TabIndex = 2;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// rtbScript
			// 
			this.rtbScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.rtbScript.Location = new System.Drawing.Point(6, 19);
			this.rtbScript.Name = "rtbScript";
			this.rtbScript.Size = new System.Drawing.Size(388, 96);
			this.rtbScript.TabIndex = 1;
			this.rtbScript.Text = "Select * from dba_users\nwhere username = \'TEST1\';";
			this.rtbScript.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbScript_KeyUp);
			this.rtbScript.TextChanged += new System.EventHandler(this.rtbScript_TextChanged);
			// 
			// linkClearOutput
			// 
			this.linkClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkClearOutput.AutoSize = true;
			this.linkClearOutput.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkClearOutput.Location = new System.Drawing.Point(366, 122);
			this.linkClearOutput.Name = "linkClearOutput";
			this.linkClearOutput.Size = new System.Drawing.Size(31, 13);
			this.linkClearOutput.TabIndex = 1;
			this.linkClearOutput.TabStop = true;
			this.linkClearOutput.Text = "Clear";
			this.linkClearOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClearOutput_LinkClicked);
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
			this.splitContainer.Panel1.Controls.Add(this.gbxScript);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.gbxOutputMessage);
			this.splitContainer.Size = new System.Drawing.Size(400, 300);
			this.splitContainer.SplitterDistance = 150;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
			// 
			// gbxScript
			// 
			this.gbxScript.Controls.Add(this.linkClearScript);
			this.gbxScript.Controls.Add(this.btnExecute);
			this.gbxScript.Controls.Add(this.rtbScript);
			this.gbxScript.Controls.Add(this.lblSeperate2);
			this.gbxScript.Controls.Add(this.linkLoadScript);
			this.gbxScript.Controls.Add(this.linkSaveScript);
			this.gbxScript.Controls.Add(this.lblSeperate1);
			this.gbxScript.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxScript.Location = new System.Drawing.Point(0, 0);
			this.gbxScript.Name = "gbxScript";
			this.gbxScript.Size = new System.Drawing.Size(400, 150);
			this.gbxScript.TabIndex = 0;
			this.gbxScript.TabStop = false;
			this.gbxScript.Text = "Enter SQL, PL/SQL and SQL*Plus statements. ";
			// 
			// linkClearScript
			// 
			this.linkClearScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkClearScript.AutoSize = true;
			this.linkClearScript.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkClearScript.Location = new System.Drawing.Point(363, 126);
			this.linkClearScript.Name = "linkClearScript";
			this.linkClearScript.Size = new System.Drawing.Size(31, 13);
			this.linkClearScript.TabIndex = 5;
			this.linkClearScript.TabStop = true;
			this.linkClearScript.Text = "Clear";
			this.linkClearScript.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClearScript_LinkClicked);
			// 
			// lblSeperate2
			// 
			this.lblSeperate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSeperate2.AutoSize = true;
			this.lblSeperate2.Location = new System.Drawing.Point(354, 126);
			this.lblSeperate2.Name = "lblSeperate2";
			this.lblSeperate2.Size = new System.Drawing.Size(9, 13);
			this.lblSeperate2.TabIndex = 0;
			this.lblSeperate2.Text = "|";
			// 
			// linkLoadScript
			// 
			this.linkLoadScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLoadScript.AutoSize = true;
			this.linkLoadScript.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLoadScript.Location = new System.Drawing.Point(222, 126);
			this.linkLoadScript.Name = "linkLoadScript";
			this.linkLoadScript.Size = new System.Drawing.Size(61, 13);
			this.linkLoadScript.TabIndex = 3;
			this.linkLoadScript.TabStop = true;
			this.linkLoadScript.Text = "Load Script";
			this.linkLoadScript.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoadScript_LinkClicked);
			// 
			// linkSaveScript
			// 
			this.linkSaveScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkSaveScript.AutoSize = true;
			this.linkSaveScript.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkSaveScript.Location = new System.Drawing.Point(292, 126);
			this.linkSaveScript.Name = "linkSaveScript";
			this.linkSaveScript.Size = new System.Drawing.Size(62, 13);
			this.linkSaveScript.TabIndex = 4;
			this.linkSaveScript.TabStop = true;
			this.linkSaveScript.Text = "Save Script";
			this.linkSaveScript.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSaveScript_LinkClicked);
			// 
			// lblSeperate1
			// 
			this.lblSeperate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSeperate1.AutoSize = true;
			this.lblSeperate1.Location = new System.Drawing.Point(283, 126);
			this.lblSeperate1.Name = "lblSeperate1";
			this.lblSeperate1.Size = new System.Drawing.Size(9, 13);
			this.lblSeperate1.TabIndex = 0;
			this.lblSeperate1.Text = "|";
			// 
			// gbxOutputMessage
			// 
			this.gbxOutputMessage.Controls.Add(this.rtbOutput);
			this.gbxOutputMessage.Controls.Add(this.linkClearOutput);
			this.gbxOutputMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxOutputMessage.Location = new System.Drawing.Point(0, 0);
			this.gbxOutputMessage.Name = "gbxOutputMessage";
			this.gbxOutputMessage.Size = new System.Drawing.Size(400, 146);
			this.gbxOutputMessage.TabIndex = 0;
			this.gbxOutputMessage.TabStop = false;
			this.gbxOutputMessage.Text = "Output message";
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "SQL script files (*.sql)|*.sql|All files (*.*)|*.*";
			this.openFileDialog.RestoreDirectory = true;
			this.openFileDialog.Title = "Open script file";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "SQL script files (*.sql)|*.sql|All files (*.*)|*.*";
			this.saveFileDialog.RestoreDirectory = true;
			this.saveFileDialog.Title = "Save script file";
			// 
			// ExecuteScriptControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "ExecuteScriptControl";
			this.Size = new System.Drawing.Size(400, 300);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.gbxScript.ResumeLayout(false);
			this.gbxScript.PerformLayout();
			this.gbxOutputMessage.ResumeLayout(false);
			this.gbxOutputMessage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbOutput;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.RichTextBox rtbScript;
		private System.Windows.Forms.LinkLabel linkClearOutput;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.LinkLabel linkLoadScript;
		private System.Windows.Forms.LinkLabel linkClearScript;
		private System.Windows.Forms.LinkLabel linkSaveScript;
		private System.Windows.Forms.Label lblSeperate2;
		private System.Windows.Forms.Label lblSeperate1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.GroupBox gbxOutputMessage;
		private System.Windows.Forms.GroupBox gbxScript;
	}
}
