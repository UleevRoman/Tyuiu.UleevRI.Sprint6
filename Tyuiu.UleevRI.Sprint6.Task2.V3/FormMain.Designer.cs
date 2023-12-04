
namespace Tyuiu.UleevRI.Sprint6.Task2.V3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInputData_URI = new System.Windows.Forms.GroupBox();
            this.labelStop_URI = new System.Windows.Forms.Label();
            this.labelStart_URI = new System.Windows.Forms.Label();
            this.textBoxStop_URI = new System.Windows.Forms.TextBox();
            this.textBoxStart_URI = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_URI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_URI = new System.Windows.Forms.GroupBox();
            this.chartFunction_URI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_URI = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_URI = new System.Windows.Forms.Label();
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.groupBoxInputData_URI.SuspendLayout();
            this.groupBoxCondition_URI.SuspendLayout();
            this.groupBoxResult_URI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_URI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputData_URI
            // 
            this.groupBoxInputData_URI.Controls.Add(this.labelStop_URI);
            this.groupBoxInputData_URI.Controls.Add(this.labelStart_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxStop_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxStart_URI);
            this.groupBoxInputData_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_URI.Location = new System.Drawing.Point(13, 249);
            this.groupBoxInputData_URI.Name = "groupBoxInputData_URI";
            this.groupBoxInputData_URI.Size = new System.Drawing.Size(453, 88);
            this.groupBoxInputData_URI.TabIndex = 0;
            this.groupBoxInputData_URI.TabStop = false;
            this.groupBoxInputData_URI.Text = "Ввод данных";
            // 
            // labelStop_URI
            // 
            this.labelStop_URI.AutoSize = true;
            this.labelStop_URI.Location = new System.Drawing.Point(313, 38);
            this.labelStop_URI.Name = "labelStop_URI";
            this.labelStop_URI.Size = new System.Drawing.Size(92, 18);
            this.labelStop_URI.TabIndex = 3;
            this.labelStop_URI.Text = "Конец шага:";
            // 
            // labelStart_URI
            // 
            this.labelStart_URI.AutoSize = true;
            this.labelStart_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_URI.Location = new System.Drawing.Point(59, 38);
            this.labelStart_URI.Name = "labelStart_URI";
            this.labelStart_URI.Size = new System.Drawing.Size(90, 18);
            this.labelStart_URI.TabIndex = 2;
            this.labelStart_URI.Text = "Старт шага:";
            // 
            // textBoxStop_URI
            // 
            this.textBoxStop_URI.Location = new System.Drawing.Point(262, 59);
            this.textBoxStop_URI.Name = "textBoxStop_URI";
            this.textBoxStop_URI.Size = new System.Drawing.Size(185, 24);
            this.textBoxStop_URI.TabIndex = 1;
            // 
            // textBoxStart_URI
            // 
            this.textBoxStart_URI.Location = new System.Drawing.Point(7, 59);
            this.textBoxStart_URI.Name = "textBoxStart_URI";
            this.textBoxStart_URI.Size = new System.Drawing.Size(189, 24);
            this.textBoxStart_URI.TabIndex = 0;
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.textBoxCondition_URI);
            this.groupBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(13, 24);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(453, 219);
            this.groupBoxCondition_URI.TabIndex = 1;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = "Условие";
            // 
            // textBoxCondition_URI
            // 
            this.textBoxCondition_URI.Location = new System.Drawing.Point(9, 24);
            this.textBoxCondition_URI.Multiline = true;
            this.textBoxCondition_URI.Name = "textBoxCondition_URI";
            this.textBoxCondition_URI.ReadOnly = true;
            this.textBoxCondition_URI.Size = new System.Drawing.Size(438, 120);
            this.textBoxCondition_URI.TabIndex = 0;
            this.textBoxCondition_URI.Text = "Протабулировать функцию F(x) = sin(x)/(x+1,2) + cos(x)*7x - 2 на заданном диапозо" +
    "не.\r\nРезультат вывести в DataGirdView и построить график функции.";
            // 
            // groupBoxResult_URI
            // 
            this.groupBoxResult_URI.Controls.Add(this.chartFunction_URI);
            this.groupBoxResult_URI.Controls.Add(this.dataGridViewFunction_URI);
            this.groupBoxResult_URI.Controls.Add(this.labelResult_URI);
            this.groupBoxResult_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_URI.Location = new System.Drawing.Point(473, 24);
            this.groupBoxResult_URI.Name = "groupBoxResult_URI";
            this.groupBoxResult_URI.Size = new System.Drawing.Size(582, 412);
            this.groupBoxResult_URI.TabIndex = 2;
            this.groupBoxResult_URI.TabStop = false;
            this.groupBoxResult_URI.Text = "Вывод данных";
            // 
            // chartFunction_URI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_URI.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_URI.Legends.Add(legend1);
            this.chartFunction_URI.Location = new System.Drawing.Point(178, 46);
            this.chartFunction_URI.Name = "chartFunction_URI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_URI.Series.Add(series1);
            this.chartFunction_URI.Size = new System.Drawing.Size(382, 360);
            this.chartFunction_URI.TabIndex = 2;
            this.chartFunction_URI.Text = "chart1";
            // 
            // dataGridViewFunction_URI
            // 
            this.dataGridViewFunction_URI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_URI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.VarX});
            this.dataGridViewFunction_URI.Location = new System.Drawing.Point(10, 46);
            this.dataGridViewFunction_URI.Name = "dataGridViewFunction_URI";
            this.dataGridViewFunction_URI.ReadOnly = true;
            this.dataGridViewFunction_URI.RowHeadersVisible = false;
            this.dataGridViewFunction_URI.RowHeadersWidth = 51;
            this.dataGridViewFunction_URI.RowTemplate.Height = 24;
            this.dataGridViewFunction_URI.Size = new System.Drawing.Size(162, 360);
            this.dataGridViewFunction_URI.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // VarX
            // 
            this.VarX.HeaderText = "F(X)";
            this.VarX.MinimumWidth = 6;
            this.VarX.Name = "VarX";
            this.VarX.ReadOnly = true;
            this.VarX.Width = 50;
            // 
            // labelResult_URI
            // 
            this.labelResult_URI.AutoSize = true;
            this.labelResult_URI.Location = new System.Drawing.Point(7, 24);
            this.labelResult_URI.Name = "labelResult_URI";
            this.labelResult_URI.Size = new System.Drawing.Size(84, 18);
            this.labelResult_URI.TabIndex = 0;
            this.labelResult_URI.Text = "Результат:";
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonHelp_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_URI.Location = new System.Drawing.Point(20, 356);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(189, 80);
            this.buttonHelp_URI.TabIndex = 3;
            this.buttonHelp_URI.Text = "Справка";
            this.buttonHelp_URI.UseVisualStyleBackColor = false;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_URI.Location = new System.Drawing.Point(275, 356);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(185, 80);
            this.buttonDone_URI.TabIndex = 4;
            this.buttonDone_URI.Text = "Выполнить";
            this.buttonDone_URI.UseVisualStyleBackColor = false;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_URI_Click);
            this.buttonDone_URI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_URI_MouseDown);
            this.buttonDone_URI.MouseEnter += new System.EventHandler(this.buttonDone_URI_MouseEnter);
            this.buttonDone_URI.MouseLeave += new System.EventHandler(this.buttonDone_URI_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.buttonDone_URI);
            this.Controls.Add(this.buttonHelp_URI);
            this.Controls.Add(this.groupBoxResult_URI);
            this.Controls.Add(this.groupBoxCondition_URI);
            this.Controls.Add(this.groupBoxInputData_URI);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 |  Вариант 3 |  Улеев Р.И.";
            this.groupBoxInputData_URI.ResumeLayout(false);
            this.groupBoxInputData_URI.PerformLayout();
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            this.groupBoxResult_URI.ResumeLayout(false);
            this.groupBoxResult_URI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_URI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_URI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputData_URI;
        private System.Windows.Forms.Label labelStop_URI;
        private System.Windows.Forms.Label labelStart_URI;
        private System.Windows.Forms.TextBox textBoxStop_URI;
        private System.Windows.Forms.TextBox textBoxStart_URI;
        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBoxCondition_URI;
        private System.Windows.Forms.GroupBox groupBoxResult_URI;
        private System.Windows.Forms.Label labelResult_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_URI;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_URI;
    }
}

