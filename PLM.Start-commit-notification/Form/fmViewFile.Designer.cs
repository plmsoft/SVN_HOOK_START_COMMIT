namespace PLM.Start_commit_notification.Form
{
    partial class FmViewFile
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmViewFile));
			this.tLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.pnBottomStatus = new System.Windows.Forms.Panel();
			this.pnCountFiles = new System.Windows.Forms.Panel();
			this.lblCountFiles = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lnklblUnSelectAll = new System.Windows.Forms.LinkLabel();
			this.lnklblSelectAll = new System.Windows.Forms.LinkLabel();
			this.toolStripMenu = new System.Windows.Forms.ToolStrip();
			this.btnToIgnoreList = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRename = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRevert = new System.Windows.Forms.ToolStripButton();
			this.listViewFiles = new System.Windows.Forms.ListView();
			this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cntMenuStripListViewFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pmnuIgnore = new System.Windows.Forms.ToolStripMenuItem();
			this.pmnuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.pmnuRename = new System.Windows.Forms.ToolStripMenuItem();
			this.pmnuRevert = new System.Windows.Forms.ToolStripMenuItem();
			this.tLayoutPanelMain.SuspendLayout();
			this.pnBottomStatus.SuspendLayout();
			this.pnCountFiles.SuspendLayout();
			this.toolStripMenu.SuspendLayout();
			this.cntMenuStripListViewFiles.SuspendLayout();
			this.SuspendLayout();
			// 
			// tLayoutPanelMain
			// 
			this.tLayoutPanelMain.ColumnCount = 1;
			this.tLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tLayoutPanelMain.Controls.Add(this.pnBottomStatus, 0, 2);
			this.tLayoutPanelMain.Controls.Add(this.toolStripMenu, 0, 0);
			this.tLayoutPanelMain.Controls.Add(this.listViewFiles, 0, 1);
			this.tLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tLayoutPanelMain.Name = "tLayoutPanelMain";
			this.tLayoutPanelMain.RowCount = 3;
			this.tLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tLayoutPanelMain.Size = new System.Drawing.Size(624, 411);
			this.tLayoutPanelMain.TabIndex = 0;
			// 
			// pnBottomStatus
			// 
			this.pnBottomStatus.Controls.Add(this.pnCountFiles);
			this.pnBottomStatus.Controls.Add(this.label1);
			this.pnBottomStatus.Controls.Add(this.lnklblUnSelectAll);
			this.pnBottomStatus.Controls.Add(this.lnklblSelectAll);
			this.pnBottomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnBottomStatus.Location = new System.Drawing.Point(3, 379);
			this.pnBottomStatus.Name = "pnBottomStatus";
			this.pnBottomStatus.Size = new System.Drawing.Size(618, 29);
			this.pnBottomStatus.TabIndex = 2;
			// 
			// pnCountFiles
			// 
			this.pnCountFiles.Controls.Add(this.lblCountFiles);
			this.pnCountFiles.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnCountFiles.Location = new System.Drawing.Point(228, 0);
			this.pnCountFiles.Name = "pnCountFiles";
			this.pnCountFiles.Size = new System.Drawing.Size(390, 29);
			this.pnCountFiles.TabIndex = 8;
			// 
			// lblCountFiles
			// 
			this.lblCountFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCountFiles.Location = new System.Drawing.Point(0, 0);
			this.lblCountFiles.Name = "lblCountFiles";
			this.lblCountFiles.Size = new System.Drawing.Size(390, 29);
			this.lblCountFiles.TabIndex = 8;
			this.lblCountFiles.Text = "{0} files selected, {1} files total";
			this.lblCountFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Select:";
			// 
			// lnklblUnSelectAll
			// 
			this.lnklblUnSelectAll.AutoSize = true;
			this.lnklblUnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklblUnSelectAll.LinkColor = System.Drawing.Color.Black;
			this.lnklblUnSelectAll.Location = new System.Drawing.Point(77, 10);
			this.lnklblUnSelectAll.Name = "lnklblUnSelectAll";
			this.lnklblUnSelectAll.Size = new System.Drawing.Size(37, 13);
			this.lnklblUnSelectAll.TabIndex = 5;
			this.lnklblUnSelectAll.TabStop = true;
			this.lnklblUnSelectAll.Text = "None";
			this.lnklblUnSelectAll.Click += new System.EventHandler(this.lnklblUnSelectAll_Click);
			// 
			// lnklblSelectAll
			// 
			this.lnklblSelectAll.AutoSize = true;
			this.lnklblSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklblSelectAll.LinkColor = System.Drawing.Color.Black;
			this.lnklblSelectAll.Location = new System.Drawing.Point(50, 10);
			this.lnklblSelectAll.Name = "lnklblSelectAll";
			this.lnklblSelectAll.Size = new System.Drawing.Size(21, 13);
			this.lnklblSelectAll.TabIndex = 4;
			this.lnklblSelectAll.TabStop = true;
			this.lnklblSelectAll.Text = "All";
			this.lnklblSelectAll.Click += new System.EventHandler(this.lnklblSelectAll_Click);
			// 
			// toolStripMenu
			// 
			this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToIgnoreList,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnRename,
            this.toolStripSeparator3,
            this.btnRevert});
			this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
			this.toolStripMenu.Name = "toolStripMenu";
			this.toolStripMenu.Size = new System.Drawing.Size(624, 32);
			this.toolStripMenu.TabIndex = 1;
			this.toolStripMenu.Text = "Main menu";
			// 
			// btnToIgnoreList
			// 
			this.btnToIgnoreList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnToIgnoreList.Image = global::PLM.Start_commit_notification.Properties.Resources.Bad_mark;
			this.btnToIgnoreList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnToIgnoreList.Name = "btnToIgnoreList";
			this.btnToIgnoreList.Size = new System.Drawing.Size(28, 29);
			this.btnToIgnoreList.Tag = "0";
			this.btnToIgnoreList.Text = "To ignore list...";
			this.btnToIgnoreList.Click += new System.EventHandler(this.pmnuIgnore_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDelete.Image = global::PLM.Start_commit_notification.Properties.Resources.Delete;
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(28, 29);
			this.btnDelete.Tag = "0";
			this.btnDelete.Text = "Delete...";
			this.btnDelete.Click += new System.EventHandler(this.pmnuDelete_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
			// 
			// btnRename
			// 
			this.btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRename.Image = global::PLM.Start_commit_notification.Properties.Resources.Modify;
			this.btnRename.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(28, 29);
			this.btnRename.Tag = "1";
			this.btnRename.Text = "Rename...";
			this.btnRename.Click += new System.EventHandler(this.pmnuRename_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
			// 
			// btnRevert
			// 
			this.btnRevert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRevert.Image = global::PLM.Start_commit_notification.Properties.Resources.Redo;
			this.btnRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRevert.Name = "btnRevert";
			this.btnRevert.Size = new System.Drawing.Size(28, 29);
			this.btnRevert.Tag = "0";
			this.btnRevert.Text = "Revert...";
			this.btnRevert.Click += new System.EventHandler(this.pmnuRevert_Click);
			// 
			// listViewFiles
			// 
			this.listViewFiles.CheckBoxes = true;
			this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPath,
            this.colExtension,
            this.colStatus});
			this.listViewFiles.ContextMenuStrip = this.cntMenuStripListViewFiles;
			this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewFiles.FullRowSelect = true;
			this.listViewFiles.LabelWrap = false;
			this.listViewFiles.Location = new System.Drawing.Point(3, 35);
			this.listViewFiles.Name = "listViewFiles";
			this.listViewFiles.Size = new System.Drawing.Size(618, 338);
			this.listViewFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewFiles.TabIndex = 0;
			this.listViewFiles.UseCompatibleStateImageBehavior = false;
			this.listViewFiles.View = System.Windows.Forms.View.Details;
			this.listViewFiles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewFiles_ItemChecked);
			// 
			// colPath
			// 
			this.colPath.Text = "Path";
			this.colPath.Width = 450;
			// 
			// colExtension
			// 
			this.colExtension.Text = "Extension";
			this.colExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// colStatus
			// 
			this.colStatus.Text = "Status";
			this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cntMenuStripListViewFiles
			// 
			this.cntMenuStripListViewFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmnuIgnore,
            this.pmnuDelete,
            this.pmnuRename,
            this.pmnuRevert});
			this.cntMenuStripListViewFiles.Name = "cntMenuStripListViewFiles";
			this.cntMenuStripListViewFiles.Size = new System.Drawing.Size(190, 92);
			// 
			// pmnuIgnore
			// 
			this.pmnuIgnore.Name = "pmnuIgnore";
			this.pmnuIgnore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.pmnuIgnore.Size = new System.Drawing.Size(189, 22);
			this.pmnuIgnore.Tag = "0";
			this.pmnuIgnore.Text = "To &ignore list...";
			this.pmnuIgnore.Click += new System.EventHandler(this.pmnuIgnore_Click);
			// 
			// pmnuDelete
			// 
			this.pmnuDelete.Name = "pmnuDelete";
			this.pmnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.pmnuDelete.Size = new System.Drawing.Size(189, 22);
			this.pmnuDelete.Tag = "0";
			this.pmnuDelete.Text = "&Delete...";
			this.pmnuDelete.Click += new System.EventHandler(this.pmnuDelete_Click);
			// 
			// pmnuRename
			// 
			this.pmnuRename.Name = "pmnuRename";
			this.pmnuRename.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.pmnuRename.Size = new System.Drawing.Size(189, 22);
			this.pmnuRename.Tag = "1";
			this.pmnuRename.Text = "&Rename...";
			this.pmnuRename.Click += new System.EventHandler(this.pmnuRename_Click);
			// 
			// pmnuRevert
			// 
			this.pmnuRevert.Name = "pmnuRevert";
			this.pmnuRevert.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
			this.pmnuRevert.Size = new System.Drawing.Size(189, 22);
			this.pmnuRevert.Tag = "0";
			this.pmnuRevert.Text = "R&evert...";
			this.pmnuRevert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.pmnuRevert.Click += new System.EventHandler(this.pmnuRevert_Click);
			// 
			// FmViewFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 411);
			this.Controls.Add(this.tLayoutPanelMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FmViewFile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "fmNotification";
			this.Load += new System.EventHandler(this.FmNotification_Load);
			this.tLayoutPanelMain.ResumeLayout(false);
			this.tLayoutPanelMain.PerformLayout();
			this.pnBottomStatus.ResumeLayout(false);
			this.pnBottomStatus.PerformLayout();
			this.pnCountFiles.ResumeLayout(false);
			this.toolStripMenu.ResumeLayout(false);
			this.toolStripMenu.PerformLayout();
			this.cntMenuStripListViewFiles.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutPanelMain;
        private System.Windows.Forms.Panel pnBottomStatus;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnToIgnoreList;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRename;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.ColumnHeader colExtension;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRevert;
        private System.Windows.Forms.ContextMenuStrip cntMenuStripListViewFiles;
        private System.Windows.Forms.ToolStripMenuItem pmnuIgnore;
        private System.Windows.Forms.ToolStripMenuItem pmnuDelete;
        private System.Windows.Forms.ToolStripMenuItem pmnuRename;
        private System.Windows.Forms.ToolStripMenuItem pmnuRevert;
        private System.Windows.Forms.LinkLabel lnklblUnSelectAll;
        private System.Windows.Forms.LinkLabel lnklblSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCountFiles;
        private System.Windows.Forms.Label lblCountFiles;
    }
}