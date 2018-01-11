namespace ExcelToolkit.FormUI
{
    partial class formMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblSelectFolder = new System.Windows.Forms.Label();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.lbFileList = new System.Windows.Forms.ListBox();
            this.pnlRename = new System.Windows.Forms.Panel();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRenameSheets = new System.Windows.Forms.Panel();
            this.btnRenameSheets = new System.Windows.Forms.Button();
            this.pnlRenameSheetsTextboxes = new System.Windows.Forms.Panel();
            this.msMain.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlRename.SuspendLayout();
            this.pnlRenameSheets.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1008, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Menu";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "&Exit";
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(921, 26);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolderDialog.TabIndex = 1;
            this.btnOpenFolderDialog.Text = "Browse";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(91, 28);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(824, 20);
            this.txtFolderPath.TabIndex = 2;
            // 
            // lblSelectFolder
            // 
            this.lblSelectFolder.AutoSize = true;
            this.lblSelectFolder.Location = new System.Drawing.Point(12, 31);
            this.lblSelectFolder.Name = "lblSelectFolder";
            this.lblSelectFolder.Size = new System.Drawing.Size(72, 13);
            this.lblSelectFolder.TabIndex = 3;
            this.lblSelectFolder.Text = "Select Folder:";
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.pnlRenameSheets);
            this.pnlSub.Controls.Add(this.pnlRename);
            this.pnlSub.Controls.Add(this.lbFileList);
            this.pnlSub.Location = new System.Drawing.Point(15, 54);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(981, 496);
            this.pnlSub.TabIndex = 4;
            // 
            // lbFileList
            // 
            this.lbFileList.FormattingEnabled = true;
            this.lbFileList.Location = new System.Drawing.Point(4, 4);
            this.lbFileList.Name = "lbFileList";
            this.lbFileList.Size = new System.Drawing.Size(301, 485);
            this.lbFileList.TabIndex = 0;
            // 
            // pnlRename
            // 
            this.pnlRename.Controls.Add(this.btnRename);
            this.pnlRename.Controls.Add(this.txtRename);
            this.pnlRename.Location = new System.Drawing.Point(312, 4);
            this.pnlRename.Name = "pnlRename";
            this.pnlRename.Size = new System.Drawing.Size(304, 485);
            this.pnlRename.TabIndex = 1;
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(4, 3);
            this.txtRename.Multiline = true;
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(297, 441);
            this.txtRename.TabIndex = 0;
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(4, 450);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(297, 32);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename Files";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 26);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1008, 536);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlRenameSheets
            // 
            this.pnlRenameSheets.Controls.Add(this.pnlRenameSheetsTextboxes);
            this.pnlRenameSheets.Controls.Add(this.btnRenameSheets);
            this.pnlRenameSheets.Location = new System.Drawing.Point(623, 4);
            this.pnlRenameSheets.Name = "pnlRenameSheets";
            this.pnlRenameSheets.Size = new System.Drawing.Size(355, 485);
            this.pnlRenameSheets.TabIndex = 2;
            // 
            // btnRenameSheets
            // 
            this.btnRenameSheets.Location = new System.Drawing.Point(4, 450);
            this.btnRenameSheets.Name = "btnRenameSheets";
            this.btnRenameSheets.Size = new System.Drawing.Size(348, 32);
            this.btnRenameSheets.TabIndex = 0;
            this.btnRenameSheets.Text = "Rename Sheets";
            this.btnRenameSheets.UseVisualStyleBackColor = true;
            // 
            // pnlRenameSheetsTextboxes
            // 
            this.pnlRenameSheetsTextboxes.Location = new System.Drawing.Point(4, 4);
            this.pnlRenameSheetsTextboxes.Name = "pnlRenameSheetsTextboxes";
            this.pnlRenameSheetsTextboxes.Size = new System.Drawing.Size(348, 440);
            this.pnlRenameSheetsTextboxes.TabIndex = 1;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.lblSelectFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnOpenFolderDialog);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "formMain";
            this.Text = "Excel Toolkit";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlSub.ResumeLayout(false);
            this.pnlRename.ResumeLayout(false);
            this.pnlRename.PerformLayout();
            this.pnlRenameSheets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label lblSelectFolder;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.ListBox lbFileList;
        private System.Windows.Forms.Panel pnlRename;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRenameSheets;
        private System.Windows.Forms.Button btnRenameSheets;
        private System.Windows.Forms.Panel pnlRenameSheetsTextboxes;
    }
}

