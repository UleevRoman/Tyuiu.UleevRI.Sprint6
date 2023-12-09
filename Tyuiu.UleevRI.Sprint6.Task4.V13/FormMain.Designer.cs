
namespace Tyuiu.UleevRI.Sprint6.Task4.V13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_URI = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_URI = new System.Windows.Forms.GroupBox();
            this.labelStop_URI = new System.Windows.Forms.Label();
            this.textBoxStop_URI = new System.Windows.Forms.TextBox();
            this.labelStart_URI = new System.Windows.Forms.Label();
            this.textBoxStart_URI = new System.Windows.Forms.TextBox();
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.buttonSave_URI = new System.Windows.Forms.Button();
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.groupBoxResult_URI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_URI = new System.Windows.Forms.TextBox();
            this.chartFunction_URI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCondition_URI = new System.Windows.Forms.Panel();
            this.panelResultFunction_URI = new System.Windows.Forms.Panel();
            this.panelResult_URI = new System.Windows.Forms.Panel();
            this.splitterResult_URI = new System.Windows.Forms.Splitter();
            this.groupBoxCondition_URI.SuspendLayout();
            this.groupBoxInputData_URI.SuspendLayout();
            this.groupBoxResult_URI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_URI)).BeginInit();
            this.panelCondition_URI.SuspendLayout();
            this.panelResultFunction_URI.SuspendLayout();
            this.panelResult_URI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.textBoxCondition_URI);
            this.groupBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(497, 116);
            this.groupBoxCondition_URI.TabIndex = 0;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = "Условие";
            // 
            // textBoxCondition_URI
            // 
            this.textBoxCondition_URI.Location = new System.Drawing.Point(7, 24);
            this.textBoxCondition_URI.Multiline = true;
            this.textBoxCondition_URI.Name = "textBoxCondition_URI";
            this.textBoxCondition_URI.ReadOnly = true;
            this.textBoxCondition_URI.Size = new System.Drawing.Size(484, 84);
            this.textBoxCondition_URI.TabIndex = 0;
            this.textBoxCondition_URI.Text = resources.GetString("textBoxCondition_URI.Text");
            // 
            // groupBoxInputData_URI
            // 
            this.groupBoxInputData_URI.Controls.Add(this.labelStop_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxStop_URI);
            this.groupBoxInputData_URI.Controls.Add(this.labelStart_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxStart_URI);
            this.groupBoxInputData_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_URI.Location = new System.Drawing.Point(506, 8);
            this.groupBoxInputData_URI.Name = "groupBoxInputData_URI";
            this.groupBoxInputData_URI.Size = new System.Drawing.Size(297, 116);
            this.groupBoxInputData_URI.TabIndex = 1;
            this.groupBoxInputData_URI.TabStop = false;
            this.groupBoxInputData_URI.Text = "Ввод данных";
            // 
            // labelStop_URI
            // 
            this.labelStop_URI.AutoSize = true;
            this.labelStop_URI.Location = new System.Drawing.Point(182, 45);
            this.labelStop_URI.Name = "labelStop_URI";
            this.labelStop_URI.Size = new System.Drawing.Size(92, 18);
            this.labelStop_URI.TabIndex = 3;
            this.labelStop_URI.Text = "Конец шага:";
            // 
            // textBoxStop_URI
            // 
            this.textBoxStop_URI.Location = new System.Drawing.Point(166, 66);
            this.textBoxStop_URI.Name = "textBoxStop_URI";
            this.textBoxStop_URI.Size = new System.Drawing.Size(125, 24);
            this.textBoxStop_URI.TabIndex = 2;
            // 
            // labelStart_URI
            // 
            this.labelStart_URI.AutoSize = true;
            this.labelStart_URI.Location = new System.Drawing.Point(24, 45);
            this.labelStart_URI.Name = "labelStart_URI";
            this.labelStart_URI.Size = new System.Drawing.Size(90, 18);
            this.labelStart_URI.TabIndex = 1;
            this.labelStart_URI.Text = "Старт шага:";
            // 
            // textBoxStart_URI
            // 
            this.textBoxStart_URI.Location = new System.Drawing.Point(7, 66);
            this.textBoxStart_URI.Name = "textBoxStart_URI";
            this.textBoxStart_URI.Size = new System.Drawing.Size(125, 24);
            this.textBoxStart_URI.TabIndex = 0;
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_URI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_URI.Location = new System.Drawing.Point(809, 27);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(131, 79);
            this.buttonDone_URI.TabIndex = 2;
            this.buttonDone_URI.Text = "Выполнить";
            this.buttonDone_URI.UseVisualStyleBackColor = false;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_URI_Click);
            // 
            // buttonSave_URI
            // 
            this.buttonSave_URI.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_URI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_URI.Location = new System.Drawing.Point(946, 27);
            this.buttonSave_URI.Name = "buttonSave_URI";
            this.buttonSave_URI.Size = new System.Drawing.Size(131, 79);
            this.buttonSave_URI.TabIndex = 3;
            this.buttonSave_URI.Text = "Сохранить";
            this.buttonSave_URI.UseVisualStyleBackColor = false;
            this.buttonSave_URI.Click += new System.EventHandler(this.buttonSave_URI_Click);
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_URI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_URI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_URI.Location = new System.Drawing.Point(1095, 27);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(131, 79);
            this.buttonHelp_URI.TabIndex = 4;
            this.buttonHelp_URI.Text = "Справка";
            this.buttonHelp_URI.UseVisualStyleBackColor = false;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_URI_Click);
            // 
            // groupBoxResult_URI
            // 
            this.groupBoxResult_URI.Controls.Add(this.textBoxResult_URI);
            this.groupBoxResult_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_URI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_URI.Name = "groupBoxResult_URI";
            this.groupBoxResult_URI.Size = new System.Drawing.Size(482, 553);
            this.groupBoxResult_URI.TabIndex = 5;
            this.groupBoxResult_URI.TabStop = false;
            this.groupBoxResult_URI.Text = "Вывод:";
            // 
            // textBoxResult_URI
            // 
            this.textBoxResult_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_URI.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_URI.Location = new System.Drawing.Point(3, 20);
            this.textBoxResult_URI.Multiline = true;
            this.textBoxResult_URI.Name = "textBoxResult_URI";
            this.textBoxResult_URI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_URI.Size = new System.Drawing.Size(476, 530);
            this.textBoxResult_URI.TabIndex = 0;
            // 
            // chartFunction_URI
            // 
            this.chartFunction_URI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction_URI.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_URI.Legends.Add(legend1);
            this.chartFunction_URI.Location = new System.Drawing.Point(488, 0);
            this.chartFunction_URI.Name = "chartFunction_URI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_URI.Series.Add(series1);
            this.chartFunction_URI.Size = new System.Drawing.Size(760, 550);
            this.chartFunction_URI.TabIndex = 1;
            this.chartFunction_URI.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "TitleF(X)";
            title1.Text = "График функции F(x)";
            this.chartFunction_URI.Titles.Add(title1);
            // 
            // panelCondition_URI
            // 
            this.panelCondition_URI.BackColor = System.Drawing.Color.Silver;
            this.panelCondition_URI.Controls.Add(this.groupBoxCondition_URI);
            this.panelCondition_URI.Controls.Add(this.groupBoxInputData_URI);
            this.panelCondition_URI.Controls.Add(this.buttonHelp_URI);
            this.panelCondition_URI.Controls.Add(this.buttonDone_URI);
            this.panelCondition_URI.Controls.Add(this.buttonSave_URI);
            this.panelCondition_URI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_URI.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_URI.Name = "panelCondition_URI";
            this.panelCondition_URI.Size = new System.Drawing.Size(1248, 124);
            this.panelCondition_URI.TabIndex = 6;
            // 
            // panelResultFunction_URI
            // 
            this.panelResultFunction_URI.BackColor = System.Drawing.Color.Red;
            this.panelResultFunction_URI.Controls.Add(this.chartFunction_URI);
            this.panelResultFunction_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultFunction_URI.Location = new System.Drawing.Point(0, 124);
            this.panelResultFunction_URI.Name = "panelResultFunction_URI";
            this.panelResultFunction_URI.Size = new System.Drawing.Size(1248, 553);
            this.panelResultFunction_URI.TabIndex = 7;
            // 
            // panelResult_URI
            // 
            this.panelResult_URI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelResult_URI.Controls.Add(this.groupBoxResult_URI);
            this.panelResult_URI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_URI.Location = new System.Drawing.Point(0, 124);
            this.panelResult_URI.Name = "panelResult_URI";
            this.panelResult_URI.Size = new System.Drawing.Size(482, 553);
            this.panelResult_URI.TabIndex = 8;
            // 
            // splitterResult_URI
            // 
            this.splitterResult_URI.Location = new System.Drawing.Point(482, 124);
            this.splitterResult_URI.Name = "splitterResult_URI";
            this.splitterResult_URI.Size = new System.Drawing.Size(10, 553);
            this.splitterResult_URI.TabIndex = 9;
            this.splitterResult_URI.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 677);
            this.Controls.Add(this.splitterResult_URI);
            this.Controls.Add(this.panelResult_URI);
            this.Controls.Add(this.panelResultFunction_URI);
            this.Controls.Add(this.panelCondition_URI);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1100, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 13 | Улеев Р.И.";
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            this.groupBoxInputData_URI.ResumeLayout(false);
            this.groupBoxInputData_URI.PerformLayout();
            this.groupBoxResult_URI.ResumeLayout(false);
            this.groupBoxResult_URI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_URI)).EndInit();
            this.panelCondition_URI.ResumeLayout(false);
            this.panelResultFunction_URI.ResumeLayout(false);
            this.panelResult_URI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBoxCondition_URI;
        private System.Windows.Forms.GroupBox groupBoxInputData_URI;
        private System.Windows.Forms.Label labelStop_URI;
        private System.Windows.Forms.TextBox textBoxStop_URI;
        private System.Windows.Forms.Label labelStart_URI;
        private System.Windows.Forms.TextBox textBoxStart_URI;
        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.Button buttonSave_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.GroupBox groupBoxResult_URI;
        private System.Windows.Forms.TextBox textBoxResult_URI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_URI;
        private System.Windows.Forms.Panel panelCondition_URI;
        private System.Windows.Forms.Panel panelResultFunction_URI;
        private System.Windows.Forms.Panel panelResult_URI;
        private System.Windows.Forms.Splitter splitterResult_URI;
    }
}

