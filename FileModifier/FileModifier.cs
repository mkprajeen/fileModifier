using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FileModifier
{
    public partial class FileModifier : Form
    {
        public FileModifier()
        {
            InitializeComponent();
            btnModify.Enabled = false;
        }
        private BindingSource bindingr1 = new BindingSource();
        private Dictionary<int, string> files = new Dictionary<int, string>();

        private void btnOpenflies_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Multiselect = true;
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = 1;
                fileDlg.FileNames.ToList().ForEach(x =>
                {
                    files.Add(i, x);
                    i++;
                });
                bindDatagrid(files);
            }
            else
            {
                files = null;
                bindDatagrid(files);
                EnableButton();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (files != null && files.Count > 0)
            {
                try
                {
                    progressBar1.Visible = true;
                    progressBar1.Maximum = files.Count;
                    progressBar1.Step = 1;

                    string pattern = "id=(\".+?\")";

                    string replacechar = "";
                    var configChar = ConfigurationManager.AppSettings["ReplaceChar"].ToString();
                    if (!string.IsNullOrEmpty(configChar))
                    {
                        replacechar = configChar;
                    }
                    foreach (KeyValuePair<int, string> item in files)
                    {
                        var outPutfileName = Path.GetFileName(item.Value);
                        var outputfullfilename = Path.Combine(txtDestfolder.Text, outPutfileName);
                        using (var input = File.OpenText(item.Value))
                        using (var output = new StreamWriter(outputfullfilename))
                        {
                            string line;
                            while (null != (line = input.ReadLine()))
                            {
                                // Apply regex to line before writing to new outpu file

                                Regex rgx = new Regex(pattern);
                                MatchCollection mactches = rgx.Matches(line);
                                foreach (Match match in mactches)
                                {
                                    line = line.Replace(match.Value, match.Value.Replace(" ", replacechar));
                                }
                                output.WriteLine(line);
                            }
                        }
                        progressBar1.PerformStep();
                    }
                    progressBar1.Visible = false;
                    MessageBox.Show("File update Completed...", "Update Status");
                    clearall();
                }
                catch (Exception ex)
                {
                    progressBar1.Visible = false;
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnSelectDstFolder_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestfolder.Text = folderDlg.SelectedPath;
                EnableButton();
            }
            else
            {
                txtDestfolder.Text = "";
                EnableButton();
            }
        }

        private void bindDatagrid(Dictionary<int, string> source)
        {
            bindingr1.DataSource = source;
            dataGridView1.DataSource = bindingr1;
            dataGridView1.Refresh();
            EnableButton();
        }

        private void EnableButton()
        {
            btnModify.Enabled = (txtDestfolder.Text.Length > 0) && (files != null && files.Count > 0);
        }

        private void clearall()
        {
            files = null;
            bindDatagrid(files);
            txtDestfolder.Text = "";
            EnableButton();
        }
    }
}
