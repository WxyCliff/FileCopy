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

namespace FileCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 選擇檔案清單
        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var filelines = File.ReadAllLines(dialog.FileName);

            var items = listBoxFiles.Items;
            foreach (var fileline in filelines)
            {
                items.Add(fileline);
            }
        }

        //選擇要複製得目的地
        private void ButtonCopyTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            textBoxCopyPath.Text = dialog.SelectedPath;
        }

        //檔案來源
        private void ButtonFileFrom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            textBoxFileFrom.Text = dialog.SelectedPath;
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCopyPath.Text))
            {
                MessageBox.Show("請選擇複製目的地");
                return;
            }

            var items = listBoxFiles.Items;

            var txtPath = Path.Combine(textBoxCopyPath.Text, $"檔案清單.txt");
            using (StreamWriter sw = File.CreateText(txtPath))
            {

                foreach (string file in items)
                {
                    var fromPath = Path.Combine(textBoxFileFrom.Text, file);
                    var toPath = Path.Combine(textBoxCopyPath.Text, file);
                    // 分辨是路徑或檔案
                    FileAttributes attr = File.GetAttributes(fromPath);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        try
                        {
                            Directory.CreateDirectory(toPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (!File.Exists(toPath))
                            {
                                File.Copy(fromPath, toPath);
                            }
                            int index = file.LastIndexOf(@"\");

                            var stringBuilder = new StringBuilder(file);
                            stringBuilder = stringBuilder.Remove(index, 2);
                            stringBuilder = stringBuilder.Insert(index, "\t");
                            sw.WriteLine(stringBuilder.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            };
            MessageBox.Show("執行完成");
        }
    }
}
