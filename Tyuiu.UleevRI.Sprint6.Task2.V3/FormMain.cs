using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UleevRI.Sprint6.Task2.V3.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_URI.Text);
                int stopValue = Convert.ToInt32(textBoxStop_URI.Text); 
                int l = ds.GetMassFunction(startValue, stopValue).Length;
                double[] num = new double[l];
                num = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction.Titles.Add("График функции F(x)");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= l - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startValue), Convert.ToString(num[i]));
                    this.chartFunction.Series[0].Points.AddXY(startValue, num[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-3 Улеев Роман Игоревич", "Сообщение");
        }

        private void buttonDone_URI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_URI.BackColor = Color.Red;
        }

        private void buttonDone_URI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_URI.BackColor = Color.Green;
        }

        private void buttonDone_URI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_URI.BackColor = Color.Blue;
        }
    }
}
