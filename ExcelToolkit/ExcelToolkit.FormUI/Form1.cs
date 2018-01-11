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
using OfficeOpenXml;

namespace ExcelToolkit.FormUI
{
    public partial class formMain : Form
    {
       
        public formMain()
        {
            InitializeComponent();
        }

        private void btnOpenFolderDialog_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofdMain = new CommonOpenFileDialog();
            cofdMain.IsFolderPicker = true;
            if (cofdMain.ShowDialog() == CommonFileDialogResult.Ok)
            {
                GetFiles(cofdMain.FileName);
                //GenerateTextBoxesForRename(files);
            }
        }
        private void GetFiles(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);
            FileInfo[] files = dInfo.GetFiles("*.xlsx");

            lbFileList.Items.Clear();
            lbFileList.Items.AddRange(files);
            txtFolderPath.Text = path;
            var fileNameArray = files.Select(x => x.Name).ToArray();
            txtRename.Text = string.Join(Environment.NewLine, fileNameArray);

            GetSheetNamesForFiles(files);
        }

        private void GetSheetNamesForFiles(FileInfo[] files)
        {
            List<string> sheets = new List<string>();
            foreach (var item in files)
            {
                //this is getting the sheet names but it is tooo sloww!!

                sheets.AddRange(GetSheetNames(item));
            }
            GenerateComprativeTextBoxesForRename(sheets.ToArray());
        }

        private void GenerateTextBoxesForRename(string[] list)
        {
            TextBox[] arrFileNames = new TextBox[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                var x = 300;
                var y = 4;
                y = (20 * i) + 4;
                arrFileNames[i] = new TextBox();
                arrFileNames[i].Left = pnlSub.Left + x;
                arrFileNames[i].Top = y;
                arrFileNames[i].Text = list[i];
                arrFileNames[i].Width = 300;
                arrFileNames[i].Dock = DockStyle.Top;

                pnlSub.Controls.Add(arrFileNames[i]);
            }
        }
        private void GenerateComprativeTextBoxesForRename(string[] list)
        {
            TextBox[] lstTextBoxes = new TextBox[list.Length];
            TextBox[] lstTextBoxesOld = new TextBox[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                var x = 20;
                var y = 4;
                y = (20 * i) + 4;
                lstTextBoxes[i] = new TextBox();
                lstTextBoxes[i].Left = pnlRenameSheetsTextboxes.Left + x;
                lstTextBoxes[i].Top = y;
                lstTextBoxes[i].Text = list[i];
                lstTextBoxes[i].Width = 300;
                lstTextBoxes[i].Dock = DockStyle.Top;

                pnlRenameSheetsTextboxes.Controls.Add(lstTextBoxes[i]);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            var path = txtFolderPath.Text + "\\";
            var newFileNames = 
                txtRename.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var oldFileNames = lbFileList.Items.Cast<FileInfo>().Select(x => x.Name).ToArray();

            for (int i = 0; i < oldFileNames.Length; i++)
            {
                File.Move(path + oldFileNames[i], path + newFileNames[i]);
            }
            GetFiles(txtFolderPath.Text);
            MessageBox.Show("The files have been renamed successfully", "Rename Successfull");
            pnlMain.Enabled = true;
        }


        public string[] GetSheetNames(FileInfo file)
        {
            List<string> sheets = new List<string>();
            using (var package = new ExcelPackage(file))
            {
                foreach (var sheet in package.Workbook.Worksheets)
                {
                    sheets.Add(sheet.Name);
                }
            }
            return sheets.ToArray();
        }

    }
}
