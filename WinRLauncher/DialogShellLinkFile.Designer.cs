namespace WinRLauncher
{
    partial class DialogShellLinkFile
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.labelArguments = new System.Windows.Forms.Label();
            this.textBoxArguments = new System.Windows.Forms.TextBox();
            this.labelWorkingDirectory = new System.Windows.Forms.Label();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.buttonWorkingDirectory = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBoxPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCommand, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCommand, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPath, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelArguments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArguments, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelWorkingDirectory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWorkingDirectory, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonWorkingDirectory, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPath.Location = new System.Drawing.Point(107, 29);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(223, 19);
            this.textBoxPath.TabIndex = 2;
            // 
            // labelCommand
            // 
            this.labelCommand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(44, 6);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(57, 12);
            this.labelCommand.TabIndex = 0;
            this.labelCommand.Text = "Command:";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxCommand, 2);
            this.textBoxCommand.Location = new System.Drawing.Point(107, 3);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(250, 19);
            this.textBoxCommand.TabIndex = 1;
            // 
            // labelPath
            // 
            this.labelPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(71, 33);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(30, 12);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path:";
            // 
            // buttonPath
            // 
            this.buttonPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPath.AutoSize = true;
            this.buttonPath.Location = new System.Drawing.Point(336, 28);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(21, 22);
            this.buttonPath.TabIndex = 3;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // labelArguments
            // 
            this.labelArguments.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelArguments.AutoSize = true;
            this.labelArguments.Location = new System.Drawing.Point(39, 59);
            this.labelArguments.Name = "labelArguments";
            this.labelArguments.Size = new System.Drawing.Size(62, 12);
            this.labelArguments.TabIndex = 0;
            this.labelArguments.Text = "Arguments:";
            // 
            // textBoxArguments
            // 
            this.textBoxArguments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxArguments, 2);
            this.textBoxArguments.Location = new System.Drawing.Point(107, 56);
            this.textBoxArguments.Name = "textBoxArguments";
            this.textBoxArguments.Size = new System.Drawing.Size(250, 19);
            this.textBoxArguments.TabIndex = 1;
            // 
            // labelWorkingDirectory
            // 
            this.labelWorkingDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkingDirectory.AutoSize = true;
            this.labelWorkingDirectory.Location = new System.Drawing.Point(3, 87);
            this.labelWorkingDirectory.Name = "labelWorkingDirectory";
            this.labelWorkingDirectory.Size = new System.Drawing.Size(98, 12);
            this.labelWorkingDirectory.TabIndex = 0;
            this.labelWorkingDirectory.Text = "Working Directory:";
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxWorkingDirectory.Location = new System.Drawing.Point(107, 83);
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new System.Drawing.Size(223, 19);
            this.textBoxWorkingDirectory.TabIndex = 2;
            // 
            // buttonWorkingDirectory
            // 
            this.buttonWorkingDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonWorkingDirectory.AutoSize = true;
            this.buttonWorkingDirectory.Location = new System.Drawing.Point(336, 82);
            this.buttonWorkingDirectory.Name = "buttonWorkingDirectory";
            this.buttonWorkingDirectory.Size = new System.Drawing.Size(21, 22);
            this.buttonWorkingDirectory.TabIndex = 3;
            this.buttonWorkingDirectory.Text = "...";
            this.buttonWorkingDirectory.UseVisualStyleBackColor = true;
            this.buttonWorkingDirectory.Click += new System.EventHandler(this.buttonWorkingDirectory_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(216, 126);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DialogShellLinkFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DialogShellLinkFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogShellLinkFile_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Label labelArguments;
        private System.Windows.Forms.TextBox textBoxArguments;
        private System.Windows.Forms.Label labelWorkingDirectory;
        private System.Windows.Forms.TextBox textBoxWorkingDirectory;
        private System.Windows.Forms.Button buttonWorkingDirectory;
    }
}