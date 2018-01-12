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
        private void btnRename_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlMain.Visible = false;

            Label lblLoading = new Label()
            {
                AutoSize = true,
                Text = "Please Wait ...",
                ForeColor = System.Drawing.Color.Green,
                Font = new System.Drawing.Font("Verdana", 24, FontStyle.Bold)
            };
            lblLoading.Top = (pnlMain.Height / 2) - (lblLoading.Height);
            lblLoading.Left = (pnlMain.Width / 2) - (lblLoading.Width);
            this.Controls.Add(lblLoading);
            this.Refresh();

            var path = txtFolderPath.Text + "\\";


            foreach (TreeNode fileNode in tvFiles.Nodes)
            {
                if(fileNode.Text != fileNode.Tag.ToString())
                {
                    File.Move(path + fileNode.Tag.ToString(), path + fileNode.Text);
                }

                bool isAnySheetRenamed = false;
                foreach (TreeNode sheetNode in fileNode.Nodes)
                {
                    if (sheetNode.Text != sheetNode.Tag.ToString())
                    {
                        isAnySheetRenamed = true;
                    }
                }

                if (isAnySheetRenamed)
                {
                    using (SpreadsheetDocument document = SpreadsheetDocument.Open(path + fileNode.Text, true))
                    {
                        WorkbookPart wbPart = document.WorkbookPart;
                        foreach (Sheet sheet in wbPart.Workbook.Sheets)
                        {
                            foreach (TreeNode sheetNode in fileNode.Nodes)
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
            }

            PopulateTreeView(txtFolderPath.Text);
            MessageBox.Show("The items have been renamed successfully", "Rename Successfull");
            pnlMain.Enabled = true;
            pnlMain.Visible = true;
            this.Controls.Remove(lblLoading);
            this.Refresh();
        }

        public string[] GetSheetNames(FileInfo file)
        {
            List<string> sheets = new List<string>();
            var items = GetAllWorksheets(file.FullName);
            foreach (Sheet sheet in items)
            {
                sheets.Add(sheet.Name);
            }

            return sheets.ToArray();
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
    }
}
