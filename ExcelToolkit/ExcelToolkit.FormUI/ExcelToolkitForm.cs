using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ExcelToolkit.FormUI
{
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpenFolderDialog_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofdMain = new CommonOpenFileDialog();
            cofdMain.IsFolderPicker = true;
            if (cofdMain.ShowDialog() == CommonFileDialogResult.Ok)
            {
                PopulateTreeView(cofdMain.FileName);
            }
        }

        private void PopulateTreeView(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);
            FileInfo[] files = dInfo.GetFiles("*.xlsx");
            txtFolderPath.Text = path;
            tvFiles.Nodes.Clear();
            foreach (var file in files)
            {
                TreeNode fileNode = new TreeNode
                {
                    Text = file.Name,
                    Tag = file.Name //Will keep the orginal name of the file/sheet
                };
                //tvFiles.Nodes
                var sheets = GetAllWorksheets(file.FullName);
                foreach (Sheet sheet in sheets)
                {
                    TreeNode sheetNode = new TreeNode
                    {
                        Text = sheet.Name,
                        ToolTipText = sheet.Name.Value.Length.ToString("##"),
                        Tag = sheet.Name, //Will keep the orginal name of the file/sheet
                        BackColor = System.Drawing.Color.LimeGreen
                    };
                    if (sheetNode.Text.Length > 31)
                        sheetNode.BackColor = System.Drawing.Color.Pink;
                    fileNode.Nodes.Add(sheetNode);
                }
                tvFiles.Nodes.Add(fileNode);
            }
            tvFiles.ExpandAll();

        }
        //Use background worker here!
        private void btnRename_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            

            var path = txtFolderPath.Text + "\\";


            List<TreeViewNode> rootNodes = new List<TreeViewNode>();
            foreach (TreeNode fileNode in tvFiles.Nodes)
            {
                var rootNode = new TreeViewNode
                {
                    Text = fileNode.Text,
                    Tag = fileNode.Tag.ToString(),
                    Nodes = new List<TreeViewNode>()
                };
                foreach (TreeNode sheetNode in fileNode.Nodes)
                {
                    TreeViewNode childNode = new TreeViewNode
                    {
                        Text = sheetNode.Text,
                        Tag = sheetNode.Tag.ToString(),
                        Parent = rootNode,
                        BackColor = sheetNode.BackColor,
                        TooltipText = sheetNode.ToolTipText
                    };
                    rootNode.Nodes.Add(childNode);
                }
                rootNodes.Add(rootNode);

            }

            bgwRename.RunWorkerAsync(new RenameMetadata()
            {
                RootNodes = rootNodes,
                Path = path
            });
        }

        // Retrieve a List of all the sheets in a workbook.
        // The Sheets class contains a collection of 
        // OpenXmlElement objects, each representing one of 
        // the sheets.
        public static Sheets GetAllWorksheets(string fileName)
        {
            Sheets theSheets = null;

            using (SpreadsheetDocument document =
                SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart wbPart = document.WorkbookPart;
                theSheets = wbPart.Workbook.Sheets;
            }
            return theSheets;
        }


        private void tvFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvFiles.SelectedNode = null;
            e.Node.BeginEdit();
        }

        private void tvFiles_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            e.Node.ToolTipText = e.Label.Length.ToString("##");
            if (e.Label.Length > 31 && e.Node.Parent != null)
            {
                e.Node.ToolTipText = "Reduce Sheet Name to less than 31 characters: " + e.Label.Length.ToString("##");
                e.Node.BackColor = System.Drawing.Color.Pink;
            }
            else if (e.Node.Parent != null)
                e.Node.BackColor = System.Drawing.Color.LimeGreen;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v1.0.0" + Environment.NewLine +
                "Developed by Saad Farooq" + Environment.NewLine +
                "http://saadfarooq.net",
                "About Excel Toolkit");
        }

        private void tsmiGettingStarted_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple tool to rename excel workbooks and worksheets without opening them. " +
                Environment.NewLine + Environment.NewLine +
                "To get started: " + Environment.NewLine +
                "Select the folder with the excel files" + Environment.NewLine +
                "The files with the sheets will appear in a tree strcture" + Environment.NewLine +
                "Click any name in the tree to rename it" + Environment.NewLine +
                "Once all names have been updated, Click the Rename button" + Environment.NewLine + Environment.NewLine +
                "Renaming files are much faster than renaming sheets. Renaming sheets of huge excel files may take a few seconds" +
                Environment.NewLine + Environment.NewLine +
                "http://saadfarooq.net",
                "Getting Started");
        }

        private void bgwRename_DoWork(object sender, DoWorkEventArgs e)
        {
            RenameMetadata meta = e.Argument as RenameMetadata;
            int i = 0;
            int total = meta.RootNodes.Count;
            foreach (TreeViewNode fileNode in meta.RootNodes)
            {
                if (fileNode.Text != fileNode.Tag.ToString())
                {
                    File.Move(meta.Path + fileNode.Tag.ToString(), meta.Path + fileNode.Text);
                }

                bool isAnySheetRenamed = false;
                foreach (TreeViewNode sheetNode in fileNode.Nodes)
                {
                    if (sheetNode.Text != sheetNode.Tag.ToString())
                    {
                        isAnySheetRenamed = true;
                    }
                }

                if (isAnySheetRenamed)
                {
                    using (SpreadsheetDocument document = SpreadsheetDocument.Open(meta.Path + fileNode.Text, true))
                    {
                        WorkbookPart wbPart = document.WorkbookPart;
                        foreach (Sheet sheet in wbPart.Workbook.Sheets)
                        {
                            foreach (TreeViewNode sheetNode in fileNode.Nodes)
                            {
                                if (sheetNode.Tag.ToString() == sheet.Name && sheetNode.Text != sheetNode.Tag.ToString())
                                {
                                    sheet.Name = sheetNode.Text;
                                }
                            }
                        }
                        document.Save();
                    }
                }

                int percentage = (i * 100) / total;
                bgwRename.ReportProgress(percentage);
                i++;
            }
        }

        private void bgwRename_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbRenameProgress.Text = "100%";
            pbRename.Value = 100;
            PopulateTreeView(txtFolderPath.Text);
            pnlMain.Enabled = true;
            
            MessageBox.Show("The items have been renamed successfully", "Rename Successfull");
            pbRename.Value = 0;
            lbRenameProgress.Text = "Ready";
        }

        private void bgwRename_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbRename.Value = e.ProgressPercentage;
            lbRenameProgress.Text = e.ProgressPercentage + "%";
        }
    }
}
