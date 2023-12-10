using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Tyuiu.UleevRI.Sprint6.Task7.V18.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_URI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_URI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        private void buttonHelp_URI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
       
        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(LoadFromData(openFile));
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_URI.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonDone_URI.Enabled = true;
        }

        private void buttonSaveFile_URI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_URI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_URI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_URI.ShowDialog();
            string path = saveFileDialogMatrix_URI.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutMatrix_URI.RowCount;
            int columns = dataGridViewOutMatrix_URI.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_URI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_URI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_URI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_URI.ShowDialog();
            openFile = openFileDialogTask_URI.FileName;
            int[,] matrix = new int[rows, columns];
            matrix = LoadFromData(openFile);

            dataGridViewInMatrix_URI.RowCount = rows;
            dataGridViewInMatrix_URI.ColumnCount = columns;
            dataGridViewOutMatrix_URI.RowCount = rows;
            dataGridViewOutMatrix_URI.ColumnCount = columns;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_URI.Columns[i].Width = 50;
                dataGridViewOutMatrix_URI.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_URI.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            matrix = ds.GetMatrix(LoadFromData(openFile));
            buttonDone_URI.Enabled = true;
        }
    }
}
