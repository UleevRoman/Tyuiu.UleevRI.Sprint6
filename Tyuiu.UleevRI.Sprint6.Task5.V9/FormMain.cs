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
using Tyuiu.UleevRI.Sprint6.Task5.V9.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V9.txt";
        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            dataGridViewResult_URI.ColumnCount = 2;
            dataGridViewResult_URI.Columns[0].Width = 30;
            dataGridViewResult_URI.Columns[1].Width = 60;
            this.chartFunction_URI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_URI.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_URI.Series[0].Points.Clear();
            double[] num = new double[ds.len];
            num = ds.LoadFromDataFile(path);
            for (int i = 0; i < num.Length; i++)
            {
                dataGridViewResult_URI.Rows.Add(Convert.ToString(i), Convert.ToString(num[i]));
                chartFunction_URI.Series[0].Points.AddXY(i, num[i]);
            }
        }

        private void buttonOpen_URI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_URI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-3 Улеев Роман Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
