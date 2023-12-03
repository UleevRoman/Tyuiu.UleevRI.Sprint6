using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UleevRI.Sprint6.Task1.V29.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();

        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_URI.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_URI.Text); ;
                string str;
                int l = ds.GetMassFunction(startValue, stopValue).Length;
                double[] num = new double[l];
                num = ds.GetMassFunction(startValue, stopValue);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= l - 1; i++)
                {
                    str = String.Format("|{0,5:d}     | {1,6:f2}   |", startValue, num[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_URI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-3 Улеев Роман Игоревич", "Сообщение");
        }
    }
}
