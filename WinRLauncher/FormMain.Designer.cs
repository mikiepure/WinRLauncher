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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCreateNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditSelectedFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveSelectedFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLauncherFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArgs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreateNewFile,
            this.toolStripButtonEditSelectedFile,
            this.toolStripButtonRemoveSelectedFile,
            this.toolStripSeparator1,
            this.toolStripButtonReload,
            this.toolStripButtonLauncherFolder,
            this.toolStripSeparator2,
            this.toolStripButtonAbout});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(624, 25);
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripButtonCreateNewFile
            // 
            this.toolStripButtonCreateNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreateNewFile.Image = global::WinRLauncher.Properties.Resources.tooltip_new;
            this.toolStripButtonCreateNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateNewFile.Name = "toolStripButtonCreateNewFile";
            this.toolStripButtonCreateNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCreateNewFile.Text = "toolStripButton1";
            this.toolStripButtonCreateNewFile.ToolTipText = "Create new file";
            this.toolStripButtonCreateNewFile.Click += new System.EventHandler(this.ToolStripButtonCreateNewFile_Click);
            // 
            // toolStripButtonEditSelectedFile
            // 
            this.toolStripButtonEditSelectedFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditSelectedFile.Image = global::WinRLauncher.Properties.Resources.tooltip_edit;
            this.toolStripButtonEditSelectedFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditSelectedFile.Name = "toolStripButtonEditSelectedFile";
            this.toolStripButtonEditSelectedFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditSelectedFile.Text = "toolStripButton2";
            this.toolStripButtonEditSelectedFile.ToolTipText = "Edit selected file";
            this.toolStripButtonEditSelectedFile.Click += new System.EventHandler(this.ToolStripButtonEditSelectedFile_Click);
            // 
            // toolStripButtonRemoveSelectedFile
            // 
            this.toolStripButtonRemoveSelectedFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveSelectedFile.Image = global::WinRLauncher.Properties.Resources.tooltip_remove;
            this.toolStripButtonRemoveSelectedFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveSelectedFile.Name = "toolStripButtonRemoveSelectedFile";
            this.toolStripButtonRemoveSelectedFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveSelectedFile.Text = "toolStripButton3";
            this.toolStripButtonRemoveSelectedFile.ToolTipText = "Remove selected file";
            this.toolStripButtonRemoveSelectedFile.Click += new System.EventHandler(this.ToolStripButtonRemoveSelectedFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Image = global::WinRLauncher.Properties.Resources.tooltip_refresh;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReload.Text = "toolStripButton4";
            this.toolStripButtonReload.ToolTipText = "Reload from file system";
            this.toolStripButtonReload.Click += new System.EventHandler(this.ToolStripButtonReload_Click);
            // 
            // toolStripButtonLauncherFolder
            // 
            this.toolStripButtonLauncherFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLauncherFolder.Image = global::WinRLauncher.Properties.Resources.tooltip_diropen;
            this.toolStripButtonLauncherFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLauncherFolder.Name = "toolStripButtonLauncherFolder";
            this.toolStripButtonLauncherFolder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLauncherFolder.Text = "toolStripButton5";
            this.toolStripButtonLauncherFolder.ToolTipText = "Open launcher folder";
            this.toolStripButtonLauncherFolder.Click += new System.EventHandler(this.ToolStripButtonOpenLauncherFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = global::WinRLauncher.Properties.Resources.tooltip_about;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.Text = "toolStripButton6";
            this.toolStripButtonAbout.ToolTipText = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
            // 
            // listViewMain
            // 
            this.listViewMain.AllowDrop = true;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderExt,
            this.columnHeaderPath,
            this.columnHeaderArgs,
            this.columnHeaderWDir});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(0, 25);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.ShowItemToolTips = true;
            this.listViewMain.Size = new System.Drawing.Size(624, 416);
            this.listViewMain.TabIndex = 1;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewMain_DragDrop);
            this.listViewMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListViewMain_DragEnter);
            this.listViewMain.DoubleClick += new System.EventHandler(this.ListViewMain_DoubleClick);
            this.listViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewMain_KeyDown);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderExt
            // 
            this.columnHeaderExt.Text = "Ext";
            this.columnHeaderExt.Width = 40;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 180;
            // 
            // columnHeaderArgs
            // 
            this.columnHeaderArgs.Text = "Arguments";
            this.columnHeaderArgs.Width = 120;
            // 
            // columnHeaderWDir
            // 
            this.columnHeaderWDir.Text = "Working Directory";
            this.columnHeaderWDir.Width = 180;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "WinR Launcher";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderArgs;
        private System.Windows.Forms.ColumnHeader columnHeaderWDir;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateNewFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditSelectedFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveSelectedFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripButton toolStripButtonLauncherFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ColumnHeader columnHeaderExt;
    }
}

