namespace Auditing.Presentation.Forms
{
	partial class NewTableForm
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
			this.rtbScript = new System.Windows.Forms.RichTextBox();
			this.btnExecuteScript = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbScript
			// 
			this.rtbScript.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbScript.Location = new System.Drawing.Point(0, 0);
			this.rtbScript.Name = "rtbScript";
			this.rtbScript.Size = new System.Drawing.Size(370, 110);
			this.rtbScript.TabIndex = 0;
			this.rtbScript.Text = "create table t (\n  a number,\n  b varchar2(10)\n)";
			this.rtbScript.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbScript_KeyUp);
			// 
			// btnExecuteScript
			// 
			this.btnExecuteScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExecuteScript.Location = new System.Drawing.Point(8, 235);
			this.btnExecuteScript.Name = "btnExecuteScript";
			this.btnExecuteScript.Size = new System.Drawing.Size(75, 23);
			this.btnExecuteScript.TabIndex = 1;
			this.btnExecuteScript.Text = "&Execute";
			this.btnExecuteScript.UseVisualStyleBackColor = true;
			this.btnExecuteScript.Click += new System.EventHandler(this.btnExecuteScript_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(302, 235);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(7, 7);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.rtbScript);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.rtbOutput);
			this.splitContainer.Size = new System.Drawing.Size(370, 220);
			this.splitContainer.SplitterDistance = 110;
			this.splitContainer.TabIndex = 3;
			this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
			// 
			// rtbOutput
			// 
			this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbOutput.Location = new System.Drawing.Point(0, 0);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.ReadOnly = true;
			this.rtbOutput.Size = new System.Drawing.Size(370, 106);
			this.rtbOutput.TabIndex = 0;
			this.rtbOutput.Text = "";
			// 
			// NewTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 262);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnExecuteScript);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "NewTableForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create New Table";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbScript;
		private System.Windows.Forms.Button btnExecuteScript;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.RichTextBox rtbOutput;
	}
}