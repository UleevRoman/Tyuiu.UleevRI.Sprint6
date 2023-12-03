using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UleevRI.Sprint6.Task3.V18.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
            {
                {-19, -19, 1, 18, 7, },
                { 5, 3, -4, -6, -12 },
                { -15, 6, 2, 2, -14 },
                { -9, -10, 15, -5, -6 },
                { -13, -15, -9, 7, 1 }
            };

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] num = ds.Calculate(matrix);
            dataGridViewMatrixResult_URI.ColumnCount = columns;
            dataGridViewMatrixResult_URI.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_URI.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_URI.Rows[i].Cells[j].Value = Convert.ToString(num[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewMatrix_URI.ColumnCount = columns;
            dataGridViewMatrix_URI.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_URI.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_URI.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-23-3 Улеев Роман Игоревич", "Сообщение");
        }
    }
}
