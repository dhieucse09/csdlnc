namespace Auditing.Presentation.Controls
{
	partial class AdminViewControl
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
			this.tabPageAuditUsers = new System.Windows.Forms.TabPage();
			this.auditUsersControl = new Auditing.Presentation.Controls.AuditUsersControl();
			this.tabPageAuditTables = new System.Windows.Forms.TabPage();
			this.auditTableControl = new Auditing.Presentation.Controls.AuditTableControl();
			this.tabPageAuditOther = new System.Windows.Forms.TabPage();
			this.auditOtherControl = new Auditing.Presentation.Controls.AuditOtherControl();
			this.tabPageViewAuditing = new System.Windows.Forms.TabPage();
			this.viewAuditingControl = new Auditing.Presentation.Controls.ViewAuditingControl();
			this.tabControl.SuspendLayout();
			this.tabPageAuditUsers.SuspendLayout();
			this.tabPageAuditTables.SuspendLayout();
			this.tabPageAuditOther.SuspendLayout();
			this.tabPageViewAuditing.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageAuditUsers);
			this.tabControl.Controls.Add(this.tabPageAuditTables);
			this.tabControl.Controls.Add(this.tabPageAuditOther);
			this.tabControl.Controls.Add(this.tabPageViewAuditing);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(600, 400);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageAuditUsers
			// 
			this.tabPageAuditUsers.Controls.Add(this.auditUsersControl);
			this.tabPageAuditUsers.Location = new System.Drawing.Point(4, 22);
			this.tabPageAuditUsers.Name = "tabPageAuditUsers";
			this.tabPageAuditUsers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAuditUsers.Size = new System.Drawing.Size(592, 374);
			this.tabPageAuditUsers.TabIndex = 0;
			this.tabPageAuditUsers.Text = "Audit users";
			this.tabPageAuditUsers.UseVisualStyleBackColor = true;
			// 
			// auditUsersControl
			// 
			this.auditUsersControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.auditUsersControl.Location = new System.Drawing.Point(3, 3);
			this.auditUsersControl.Name = "auditUsersControl";
			this.auditUsersControl.Size = new System.Drawing.Size(586, 368);
			this.auditUsersControl.TabIndex = 0;
			this.auditUsersControl.DeleteUser += new System.EventHandler<Auditing.Presentation.Controls.UserEventArgs>(this.auditUsersControl_DeleteUser);
			this.auditUsersControl.SetAuditUser += new System.EventHandler<Auditing.Presentation.Controls.AuditUserEventArgs>(this.auditUsersControl_SetAuditUser);
			this.auditUsersControl.SearchUser += new System.EventHandler<Auditing.Presentation.Controls.SearchEventArgs<Auditing.Business.Entities.User>>(this.auditUsersControl_SearchUser);
			this.auditUsersControl.AlterUser += new System.EventHandler<Auditing.Presentation.Controls.UserEventArgs>(this.auditUsersControl_AlterUser);
			this.auditUsersControl.NewUser += new System.EventHandler<Auditing.Presentation.Controls.UserEventArgs>(this.auditUsersControl_NewUser);
			// 
			// tabPageAuditTables
			// 
			this.tabPageAuditTables.Controls.Add(this.auditTableControl);
			this.tabPageAuditTables.Location = new System.Drawing.Point(4, 22);
			this.tabPageAuditTables.Name = "tabPageAuditTables";
			this.tabPageAuditTables.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAuditTables.Size = new System.Drawing.Size(592, 374);
			this.tabPageAuditTables.TabIndex = 1;
			this.tabPageAuditTables.Text = "Audit tables";
			this.tabPageAuditTables.UseVisualStyleBackColor = true;
			// 
			// auditTableControl
			// 
			this.auditTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.auditTableControl.Location = new System.Drawing.Point(3, 3);
			this.auditTableControl.Name = "auditTableControl";
			this.auditTableControl.Size = new System.Drawing.Size(586, 368);
			this.auditTableControl.TabIndex = 0;
			this.auditTableControl.DeleteTable += new System.EventHandler<Auditing.Presentation.Controls.TableEventArgs>(this.auditTableControl_DeleteTable);
			this.auditTableControl.SearchTable += new System.EventHandler<Auditing.Presentation.Controls.SearchEventArgs<Auditing.Business.Entities.Table>>(this.auditTableControl_SearchTable);
			this.auditTableControl.SetAuditTable += new System.EventHandler<Auditing.Presentation.Controls.AuditTableEventArgs>(this.auditTableControl_SetAuditTable);
			this.auditTableControl.NewTable += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.auditTableControl_NewTable);
			// 
			// tabPageAuditOther
			// 
			this.tabPageAuditOther.Controls.Add(this.auditOtherControl);
			this.tabPageAuditOther.Location = new System.Drawing.Point(4, 22);
			this.tabPageAuditOther.Name = "tabPageAuditOther";
			this.tabPageAuditOther.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAuditOther.Size = new System.Drawing.Size(592, 374);
			this.tabPageAuditOther.TabIndex = 3;
			this.tabPageAuditOther.Text = "Audit other";
			this.tabPageAuditOther.UseVisualStyleBackColor = true;
			// 
			// auditOtherControl
			// 
			this.auditOtherControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.auditOtherControl.Location = new System.Drawing.Point(3, 3);
			this.auditOtherControl.Name = "auditOtherControl";
			this.auditOtherControl.Size = new System.Drawing.Size(586, 368);
			this.auditOtherControl.TabIndex = 0;
			this.auditOtherControl.ExecuteScript += new System.EventHandler<Auditing.Presentation.Controls.ScriptEventArgs>(this.auditOtherControl_ExecuteScript);
			// 
			// tabPageViewAuditing
			// 
			this.tabPageViewAuditing.Controls.Add(this.viewAuditingControl);
			this.tabPageViewAuditing.Location = new System.Drawing.Point(4, 22);
			this.tabPageViewAuditing.Name = "tabPageViewAuditing";
			this.tabPageViewAuditing.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageViewAuditing.Size = new System.Drawing.Size(592, 374);
			this.tabPageViewAuditing.TabIndex = 2;
			this.tabPageViewAuditing.Text = "View auditing";
			this.tabPageViewAuditing.UseVisualStyleBackColor = true;
			// 
			// viewAuditingControl
			// 
			this.viewAuditingControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewAuditingControl.Location = new System.Drawing.Point(3, 3);
			this.viewAuditingControl.Name = "viewAuditingControl";
			this.viewAuditingControl.Size = new System.Drawing.Size(586, 368);
			this.viewAuditingControl.TabIndex = 0;
			this.viewAuditingControl.SearchAuditing += new System.EventHandler<Auditing.Presentation.Controls.SearchEventArgs<Auditing.Business.Entities.AuditInfo>>(this.viewAuditingControl_SearchAuditing);
			// 
			// AdminViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl);
			this.Name = "AdminViewControl";
			this.Size = new System.Drawing.Size(600, 400);
			this.tabControl.ResumeLayout(false);
			this.tabPageAuditUsers.ResumeLayout(false);
			this.tabPageAuditTables.ResumeLayout(false);
			this.tabPageAuditOther.ResumeLayout(false);
			this.tabPageViewAuditing.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageAuditUsers;
		private System.Windows.Forms.TabPage tabPageAuditTables;
		private System.Windows.Forms.TabPage tabPageViewAuditing;
		private AuditUsersControl auditUsersControl;
		private ViewAuditingControl viewAuditingControl;
		private AuditTableControl auditTableControl;
		private System.Windows.Forms.TabPage tabPageAuditOther;
		private AuditOtherControl auditOtherControl;
	}
}
