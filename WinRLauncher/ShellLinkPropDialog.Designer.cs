namespace WinRLauncher
{
    partial class ShellLinkPropDialog
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelArgs = new System.Windows.Forms.Label();
            this.labelWDir = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.textBoxWDir = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonWDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(74, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(80, 40);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(30, 12);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Path:";
            // 
            // labelArgs
            // 
            this.labelArgs.AutoSize = true;
            this.labelArgs.Location = new System.Drawing.Point(48, 65);
            this.labelArgs.Name = "labelArgs";
            this.labelArgs.Size = new System.Drawing.Size(62, 12);
            this.labelArgs.TabIndex = 5;
            this.labelArgs.Text = "Arguments:";
            // 
            // labelWDir
            // 
            this.labelWDir.AutoSize = true;
            this.labelWDir.Location = new System.Drawing.Point(12, 90);
            this.labelWDir.Name = "labelWDir";
            this.labelWDir.Size = new System.Drawing.Size(98, 12);
            this.labelWDir.TabIndex = 7;
            this.labelWDir.Text = "Working Directory:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 19);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(116, 37);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(224, 19);
            this.textBoxPath.TabIndex = 3;
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.Location = new System.Drawing.Point(116, 62);
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.Size = new System.Drawing.Size(256, 19);
            this.textBoxArgs.TabIndex = 6;
            // 
            // textBoxWDir
            // 
            this.textBoxWDir.Location = new System.Drawing.Point(116, 87);
            this.textBoxWDir.Name = "textBoxWDir";
            this.textBoxWDir.Size = new System.Drawing.Size(224, 19);
            this.textBoxWDir.TabIndex = 8;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(346, 35);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(26, 23);
            this.buttonPath.TabIndex = 4;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.ButtonPath_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(216, 114);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 114);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonWDir
            // 
            this.buttonWDir.Location = new System.Drawing.Point(346, 85);
            this.buttonWDir.Name = "buttonWDir";
            this.buttonWDir.Size = new System.Drawing.Size(26, 23);
            this.buttonWDir.TabIndex = 9;
            this.buttonWDir.Text = "...";
            this.buttonWDir.UseVisualStyleBackColor = true;
            this.buttonWDir.Click += new System.EventHandler(this.ButtonWDir_Click);
            // 
            // ShellLinkPropDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 145);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonWDir);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.textBoxWDir);
            this.Controls.Add(this.textBoxArgs);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelWDir);
            this.Controls.Add(this.labelArgs);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShellLinkPropDialog";
            this.Text = "Property";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShellLinkPropDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelArgs;
        private System.Windows.Forms.Label labelWDir;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.TextBox textBoxWDir;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonWDir;
    }
}