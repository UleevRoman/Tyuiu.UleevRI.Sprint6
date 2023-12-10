using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.UleevRI.Sprint6.Task6.V5.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;
        private void buttonOpenFile_URI_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxLoadFile_URI.Text = File.ReadAllText(path);
            groupBoxСonclusion_URI.Text = groupBoxСonclusion_URI.Text + " " + openFileDialogTask.FileName;
            buttonOpenFile_URI.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void buttonHelp_URI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            textBoxPerform_URI.Text = ds.CollectTextFromFile("l", path);
        }
    }
}
