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

namespace TXTEditorPDF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string TextFile = "";
                OpenFileDialog Ofd = new OpenFileDialog();

                Ofd.InitialDirectory = "c:\\";
                Ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                Ofd.FilterIndex = 2;
                Ofd.RestoreDirectory = true;

                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcefile = System.IO.Path.Combine(Ofd.FileName);
                    using (StreamReader sr = new StreamReader(sourcefile))
                    { TextFile = sr.ReadToEnd(); }
                    //string[] ConVarlist = TextFile.Split('');
                   

                    display.Text = TextFile.Replace(" ", string.Empty);
                  
                    //display.Text = TextFile.Replace(@"""""", @"j""");
                    display.Text = TextFile.Replace(@"'""'",string.Empty);

                }

            }
            catch
            {
                MessageBox.Show("ERROR! Please Try Agin");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
