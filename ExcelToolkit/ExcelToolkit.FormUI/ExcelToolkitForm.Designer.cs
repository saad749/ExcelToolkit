namespace ExcelToolkit.FormUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnRename = new System.Windows.Forms.Button();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbRenameProgress = new System.Windows.Forms.Label();
            this.pbRename = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGettingStarted = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwRename = new System.ComponentModel.BackgroundWorker();
            this.pnlSub.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(672, 26);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(95, 23);
            this.btnOpenFolderDialog.TabIndex = 1;
            this.btnOpenFolderDialog.Text = "Select Folder";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.Location = new System.Drawing.Point(12, 28);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(654, 20);
            this.txtFolderPath.TabIndex = 2;
            // 
            // pnlSub
            // 
            this.pnlSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSub.Controls.Add(this.btnRename);
            this.pnlSub.Controls.Add(this.tvFiles);
            this.pnlSub.Location = new System.Drawing.Point(12, 54);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(760, 682);
            this.pnlSub.TabIndex = 4;
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.Color.White;
            this.btnRename.Location = new System.Drawing.Point(0, 627);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(755, 52);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "RENAME";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tvFiles
            // 
            this.tvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFiles.LabelEdit = true;
            this.tvFiles.Location = new System.Drawing.Point(0, 3);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.ShowNodeToolTips = true;
            this.tvFiles.Size = new System.Drawing.Size(755, 618);
            this.tvFiles.TabIndex = 0;
            this.tvFiles.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvFiles_AfterLabelEdit);
            this.tvFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFiles_NodeMouseClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lbRenameProgress);
            this.pnlMain.Controls.Add(this.pbRename);
            this.pnlMain.Controls.Add(this.statusStrip1);
            this.pnlMain.Controls.Add(this.btnOpenFolderDialog);
            this.pnlMain.Controls.Add(this.txtFolderPath);
            this.pnlMain.Controls.Add(this.pnlSub);
            this.pnlMain.Controls.Add(this.msMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 761);
            this.pnlMain.TabIndex = 5;
            // 
            // lbRenameProgress
            // 
            this.lbRenameProgress.AutoSize = true;
            this.lbRenameProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenameProgress.Location = new System.Drawing.Point(469, 742);
            this.lbRenameProgress.Name = "lbRenameProgress";
            this.lbRenameProgress.Size = new System.Drawing.Size(38, 13);
            this.lbRenameProgress.TabIndex = 8;
            this.lbRenameProgress.Text = "Ready";
            // 
            // pbRename
            // 
            this.pbRename.Location = new System.Drawing.Point(511, 742);
            this.pbRename.Name = "pbRename";
            this.pbRename.Size = new System.Drawing.Size(256, 16);
            this.pbRename.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 5;
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
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "&Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGettingStarted,
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsmiGettingStarted
            // 
            this.tsmiGettingStarted.Name = "tsmiGettingStarted";
            this.tsmiGettingStarted.Size = new System.Drawing.Size(157, 22);
            this.tsmiGettingStarted.Text = "&Gettting Started";
            this.tsmiGettingStarted.Click += new System.EventHandler(this.tsmiGettingStarted_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(157, 22);
            this.tsmiAbout.Text = "&About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // bgwRename
            // 
            this.bgwRename.WorkerReportsProgress = true;
            this.bgwRename.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRename_DoWork);
            this.bgwRename.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRename_ProgressChanged);
            this.bgwRename.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRename_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "FormMain";
            this.Text = "Excel Toolkit";
            this.pnlSub.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGettingStarted;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ProgressBar pbRename;
        private System.ComponentModel.BackgroundWorker bgwRename;
        private System.Windows.Forms.Label lbRenameProgress;
    }
}

