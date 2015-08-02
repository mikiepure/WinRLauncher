namespace WinRLauncher
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLinkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBatchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLauncherFilesPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNewLinkFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewBatchFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditSelectedFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveSelectedFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOpenLauncherFilesPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArguments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWorkingDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorkerDragDrop = new System.ComponentModel.BackgroundWorker();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(584, 24);
            this.menuStripMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.application_delete;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLinkFileToolStripMenuItem,
            this.newBatchFileToolStripMenuItem,
            this.editSelectedFileToolStripMenuItem,
            this.removeSelectedFileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newLinkFileToolStripMenuItem
            // 
            this.newLinkFileToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.page_white_link;
            this.newLinkFileToolStripMenuItem.Name = "newLinkFileToolStripMenuItem";
            this.newLinkFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newLinkFileToolStripMenuItem.Text = "New link file";
            this.newLinkFileToolStripMenuItem.Click += new System.EventHandler(this.newLinkFileToolStripMenuItem_Click);
            // 
            // newBatchFileToolStripMenuItem
            // 
            this.newBatchFileToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.page_white_gear;
            this.newBatchFileToolStripMenuItem.Name = "newBatchFileToolStripMenuItem";
            this.newBatchFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newBatchFileToolStripMenuItem.Text = "New batch file";
            this.newBatchFileToolStripMenuItem.Click += new System.EventHandler(this.newBatchFileToolStripMenuItem_Click);
            // 
            // editSelectedFileToolStripMenuItem
            // 
            this.editSelectedFileToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.page_white_edit;
            this.editSelectedFileToolStripMenuItem.Name = "editSelectedFileToolStripMenuItem";
            this.editSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editSelectedFileToolStripMenuItem.Text = "Edit selected file";
            this.editSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.editSelectedFileToolStripMenuItem_Click);
            // 
            // removeSelectedFileToolStripMenuItem
            // 
            this.removeSelectedFileToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.page_white_delete;
            this.removeSelectedFileToolStripMenuItem.Name = "removeSelectedFileToolStripMenuItem";
            this.removeSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.removeSelectedFileToolStripMenuItem.Text = "Remove selected file";
            this.removeSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedFileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.arrow_refresh;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLauncherFilesPathToolStripMenuItem,
            this.uninstallToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // openLauncherFilesPathToolStripMenuItem
            // 
            this.openLauncherFilesPathToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.folder_go;
            this.openLauncherFilesPathToolStripMenuItem.Name = "openLauncherFilesPathToolStripMenuItem";
            this.openLauncherFilesPathToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openLauncherFilesPathToolStripMenuItem.Text = "Open launcher files path";
            this.openLauncherFilesPathToolStripMenuItem.Click += new System.EventHandler(this.openLauncherFilesPathToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::WinRLauncher.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExit,
            this.toolStripSeparator1,
            this.toolStripButtonNewLinkFile,
            this.toolStripButtonNewBatchFile,
            this.toolStripButtonEditSelectedFile,
            this.toolStripButtonRemoveSelectedFile,
            this.toolStripSeparator2,
            this.toolStripButtonReload,
            this.toolStripSeparator3,
            this.toolStripButtonOpenLauncherFilesPath,
            this.toolStripSeparator4,
            this.toolStripButtonAbout});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(584, 25);
            this.toolStripMain.TabIndex = 1;
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::WinRLauncher.Properties.Resources.application_delete;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonNewLinkFile
            // 
            this.toolStripButtonNewLinkFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewLinkFile.Image = global::WinRLauncher.Properties.Resources.page_white_link;
            this.toolStripButtonNewLinkFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewLinkFile.Name = "toolStripButtonNewLinkFile";
            this.toolStripButtonNewLinkFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewLinkFile.Click += new System.EventHandler(this.toolStripButtonNewLinkFile_Click);
            // 
            // toolStripButtonNewBatchFile
            // 
            this.toolStripButtonNewBatchFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewBatchFile.Image = global::WinRLauncher.Properties.Resources.page_white_gear;
            this.toolStripButtonNewBatchFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewBatchFile.Name = "toolStripButtonNewBatchFile";
            this.toolStripButtonNewBatchFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewBatchFile.Click += new System.EventHandler(this.toolStripButtonNewBatchFile_Click);
            // 
            // toolStripButtonEditSelectedFile
            // 
            this.toolStripButtonEditSelectedFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditSelectedFile.Image = global::WinRLauncher.Properties.Resources.page_white_edit;
            this.toolStripButtonEditSelectedFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditSelectedFile.Name = "toolStripButtonEditSelectedFile";
            this.toolStripButtonEditSelectedFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditSelectedFile.Click += new System.EventHandler(this.toolStripButtonEditSelectedFile_Click);
            // 
            // toolStripButtonRemoveSelectedFile
            // 
            this.toolStripButtonRemoveSelectedFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveSelectedFile.Image = global::WinRLauncher.Properties.Resources.page_white_delete;
            this.toolStripButtonRemoveSelectedFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveSelectedFile.Name = "toolStripButtonRemoveSelectedFile";
            this.toolStripButtonRemoveSelectedFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveSelectedFile.Click += new System.EventHandler(this.toolStripButtonRemoveSelectedFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Image = global::WinRLauncher.Properties.Resources.arrow_refresh;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonOpenLauncherFilesPath
            // 
            this.toolStripButtonOpenLauncherFilesPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenLauncherFilesPath.Image = global::WinRLauncher.Properties.Resources.folder_go;
            this.toolStripButtonOpenLauncherFilesPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenLauncherFilesPath.Name = "toolStripButtonOpenLauncherFilesPath";
            this.toolStripButtonOpenLauncherFilesPath.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenLauncherFilesPath.Click += new System.EventHandler(this.toolStripButtonOpenLauncherFilesPath_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = global::WinRLauncher.Properties.Resources.information;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // listViewMain
            // 
            this.listViewMain.AllowDrop = true;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCommand,
            this.columnHeaderAction,
            this.columnHeaderArguments,
            this.columnHeaderWorkingDirectory});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.Location = new System.Drawing.Point(0, 49);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(584, 312);
            this.listViewMain.TabIndex = 2;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewMain_DragDrop);
            this.listViewMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewMain_DragEnter);
            this.listViewMain.DoubleClick += new System.EventHandler(this.listViewMain_DoubleClick);
            this.listViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMain_KeyDown);
            // 
            // columnHeaderCommand
            // 
            this.columnHeaderCommand.Text = "Command";
            this.columnHeaderCommand.Width = global::WinRLauncher.Properties.Settings.Default.columnHeaderCommand_Width;
            // 
            // columnHeaderAction
            // 
            this.columnHeaderAction.Text = "Action";
            this.columnHeaderAction.Width = global::WinRLauncher.Properties.Settings.Default.columnHeaderAction_Width;
            // 
            // columnHeaderArguments
            // 
            this.columnHeaderArguments.Text = "Arguments";
            this.columnHeaderArguments.Width = global::WinRLauncher.Properties.Settings.Default.columnHeaderArguments_Width;
            // 
            // columnHeaderWorkingDirectory
            // 
            this.columnHeaderWorkingDirectory.Text = "Working Directory";
            this.columnHeaderWorkingDirectory.Width = global::WinRLauncher.Properties.Settings.Default.columnHeaderWorkingDirectory_Width;
            // 
            // backgroundWorkerDragDrop
            // 
            this.backgroundWorkerDragDrop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDragDrop_DoWork);
            this.backgroundWorkerDragDrop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDragDrop_RunWorkerCompleted);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = global::WinRLauncher.Properties.Settings.Default.formMain_ClientSize;
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WinRLauncher.Properties.Settings.Default, "formMain_Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::WinRLauncher.Properties.Settings.Default, "formMain_ClientSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::WinRLauncher.Properties.Settings.Default.formMain_Location;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Win+R Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLinkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBatchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLauncherFilesPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewLinkFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewBatchFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditSelectedFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveSelectedFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenLauncherFilesPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderCommand;
        private System.Windows.Forms.ColumnHeader columnHeaderAction;
        private System.Windows.Forms.ColumnHeader columnHeaderWorkingDirectory;
        private System.Windows.Forms.ColumnHeader columnHeaderArguments;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDragDrop;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
    }
}

