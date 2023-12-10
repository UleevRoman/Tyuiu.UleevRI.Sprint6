
namespace Tyuiu.UleevRI.Sprint6.Task7.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelFile_URI = new System.Windows.Forms.Panel();
            this.buttonSaveFile_URI = new System.Windows.Forms.Button();
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.buttonOpenFile_URI = new System.Windows.Forms.Button();
            this.panelCondition_URI = new System.Windows.Forms.Panel();
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelData_URI = new System.Windows.Forms.Panel();
            this.groupBoxInput_URI = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_URI = new System.Windows.Forms.DataGridView();
            this.panelResult_URI = new System.Windows.Forms.Panel();
            this.groupBoxOutput_URI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_URI = new System.Windows.Forms.DataGridView();
            this.splitterResult_URI = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_URI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_URI = new System.Windows.Forms.SaveFileDialog();
            this.toolTipOpenFile_URI = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDone_URI = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSaveFile_URI = new System.Windows.Forms.ToolTip(this.components);
            this.panelFile_URI.SuspendLayout();
            this.panelCondition_URI.SuspendLayout();
            this.groupBoxCondition_URI.SuspendLayout();
            this.panelData_URI.SuspendLayout();
            this.groupBoxInput_URI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_URI)).BeginInit();
            this.panelResult_URI.SuspendLayout();
            this.groupBoxOutput_URI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFile_URI
            // 
            this.panelFile_URI.Controls.Add(this.buttonSaveFile_URI);
            this.panelFile_URI.Controls.Add(this.buttonDone_URI);
            this.panelFile_URI.Controls.Add(this.buttonHelp_URI);
            this.panelFile_URI.Controls.Add(this.buttonOpenFile_URI);
            this.panelFile_URI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFile_URI.Location = new System.Drawing.Point(0, 0);
            this.panelFile_URI.Name = "panelFile_URI";
            this.panelFile_URI.Size = new System.Drawing.Size(1185, 100);
            this.panelFile_URI.TabIndex = 0;
            // 
            // buttonSaveFile_URI
            // 
            this.buttonSaveFile_URI.BackColor = System.Drawing.Color.Red;
            this.buttonSaveFile_URI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_URI.Image")));
            this.buttonSaveFile_URI.Location = new System.Drawing.Point(271, 13);
            this.buttonSaveFile_URI.Name = "buttonSaveFile_URI";
            this.buttonSaveFile_URI.Size = new System.Drawing.Size(105, 69);
            this.buttonSaveFile_URI.TabIndex = 3;
            this.toolTipSaveFile_URI.SetToolTip(this.buttonSaveFile_URI, "Выберите папку, где сохранить файл");
            this.buttonSaveFile_URI.UseVisualStyleBackColor = false;
            this.buttonSaveFile_URI.Click += new System.EventHandler(this.buttonSaveFile_URI_Click);
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDone_URI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_URI.Image")));
            this.buttonDone_URI.Location = new System.Drawing.Point(143, 13);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(101, 69);
            this.buttonDone_URI.TabIndex = 2;
            this.toolTipDone_URI.SetToolTip(this.buttonDone_URI, "Выполнить\r\nЧтобы продолжить, нажмите на эту кнопку");
            this.buttonDone_URI.UseVisualStyleBackColor = false;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_URI_Click);
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_URI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_URI.Image")));
            this.buttonHelp_URI.Location = new System.Drawing.Point(1079, 13);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(94, 69);
            this.buttonHelp_URI.TabIndex = 1;
            this.buttonHelp_URI.UseVisualStyleBackColor = true;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_URI_Click);
            // 
            // buttonOpenFile_URI
            // 
            this.buttonOpenFile_URI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOpenFile_URI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_URI.Image")));
            this.buttonOpenFile_URI.Location = new System.Drawing.Point(11, 13);
            this.buttonOpenFile_URI.Name = "buttonOpenFile_URI";
            this.buttonOpenFile_URI.Size = new System.Drawing.Size(105, 69);
            this.buttonOpenFile_URI.TabIndex = 0;
            this.toolTipOpenFile_URI.SetToolTip(this.buttonOpenFile_URI, "Открыть файл\r\nВыберите нужный файл для обработки данных");
            this.buttonOpenFile_URI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_URI.Click += new System.EventHandler(this.buttonOpenFile_URI_Click);
            // 
            // panelCondition_URI
            // 
            this.panelCondition_URI.Controls.Add(this.groupBoxCondition_URI);
            this.panelCondition_URI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_URI.Location = new System.Drawing.Point(0, 100);
            this.panelCondition_URI.Name = "panelCondition_URI";
            this.panelCondition_URI.Size = new System.Drawing.Size(1185, 105);
            this.panelCondition_URI.TabIndex = 1;
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.textBox1);
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(11, 10);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(1136, 82);
            this.groupBoxCondition_URI.TabIndex = 0;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1123, 54);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelData_URI
            // 
            this.panelData_URI.Controls.Add(this.groupBoxInput_URI);
            this.panelData_URI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelData_URI.Location = new System.Drawing.Point(0, 205);
            this.panelData_URI.Name = "panelData_URI";
            this.panelData_URI.Size = new System.Drawing.Size(546, 548);
            this.panelData_URI.TabIndex = 2;
            // 
            // groupBoxInput_URI
            // 
            this.groupBoxInput_URI.Controls.Add(this.dataGridViewInMatrix_URI);
            this.groupBoxInput_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_URI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_URI.Name = "groupBoxInput_URI";
            this.groupBoxInput_URI.Size = new System.Drawing.Size(546, 548);
            this.groupBoxInput_URI.TabIndex = 0;
            this.groupBoxInput_URI.TabStop = false;
            this.groupBoxInput_URI.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_URI
            // 
            this.dataGridViewInMatrix_URI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_URI.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_URI.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInMatrix_URI.Name = "dataGridViewInMatrix_URI";
            this.dataGridViewInMatrix_URI.RowHeadersVisible = false;
            this.dataGridViewInMatrix_URI.RowHeadersWidth = 51;
            this.dataGridViewInMatrix_URI.RowTemplate.Height = 24;
            this.dataGridViewInMatrix_URI.Size = new System.Drawing.Size(540, 527);
            this.dataGridViewInMatrix_URI.TabIndex = 0;
            // 
            // panelResult_URI
            // 
            this.panelResult_URI.Controls.Add(this.groupBoxOutput_URI);
            this.panelResult_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_URI.Location = new System.Drawing.Point(546, 205);
            this.panelResult_URI.Name = "panelResult_URI";
            this.panelResult_URI.Size = new System.Drawing.Size(639, 548);
            this.panelResult_URI.TabIndex = 3;
            // 
            // groupBoxOutput_URI
            // 
            this.groupBoxOutput_URI.Controls.Add(this.dataGridViewOutMatrix_URI);
            this.groupBoxOutput_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_URI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_URI.Name = "groupBoxOutput_URI";
            this.groupBoxOutput_URI.Size = new System.Drawing.Size(639, 548);
            this.groupBoxOutput_URI.TabIndex = 0;
            this.groupBoxOutput_URI.TabStop = false;
            this.groupBoxOutput_URI.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_URI
            // 
            this.dataGridViewOutMatrix_URI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_URI.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_URI.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutMatrix_URI.Name = "dataGridViewOutMatrix_URI";
            this.dataGridViewOutMatrix_URI.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_URI.RowHeadersWidth = 51;
            this.dataGridViewOutMatrix_URI.RowTemplate.Height = 24;
            this.dataGridViewOutMatrix_URI.Size = new System.Drawing.Size(633, 527);
            this.dataGridViewOutMatrix_URI.TabIndex = 0;
            // 
            // splitterResult_URI
            // 
            this.splitterResult_URI.Location = new System.Drawing.Point(546, 205);
            this.splitterResult_URI.Name = "splitterResult_URI";
            this.splitterResult_URI.Size = new System.Drawing.Size(10, 548);
            this.splitterResult_URI.TabIndex = 4;
            this.splitterResult_URI.TabStop = false;
            // 
            // openFileDialogTask_URI
            // 
            this.openFileDialogTask_URI.FileName = "openFileDialog1";
            // 
            // toolTipOpenFile_URI
            // 
            this.toolTipOpenFile_URI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFile_URI.ToolTipTitle = "Подсказка";
            // 
            // toolTipDone_URI
            // 
            this.toolTipDone_URI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDone_URI.ToolTipTitle = "Подсказка";
            // 
            // toolTipSaveFile_URI
            // 
            this.toolTipSaveFile_URI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSaveFile_URI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 753);
            this.Controls.Add(this.splitterResult_URI);
            this.Controls.Add(this.panelResult_URI);
            this.Controls.Add(this.panelData_URI);
            this.Controls.Add(this.panelCondition_URI);
            this.Controls.Add(this.panelFile_URI);
            this.MaximumSize = new System.Drawing.Size(2000, 950);
            this.MinimumSize = new System.Drawing.Size(1203, 800);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 18 | Улеев Р.И.";
            this.panelFile_URI.ResumeLayout(false);
            this.panelCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            this.panelData_URI.ResumeLayout(false);
            this.groupBoxInput_URI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_URI)).EndInit();
            this.panelResult_URI.ResumeLayout(false);
            this.groupBoxOutput_URI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_URI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFile_URI;
        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.Button buttonOpenFile_URI;
        private System.Windows.Forms.Panel panelCondition_URI;
        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelData_URI;
        private System.Windows.Forms.Panel panelResult_URI;
        private System.Windows.Forms.Splitter splitterResult_URI;
        private System.Windows.Forms.GroupBox groupBoxInput_URI;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_URI;
        private System.Windows.Forms.GroupBox groupBoxOutput_URI;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_URI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_URI;
        private System.Windows.Forms.Button buttonSaveFile_URI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_URI;
        private System.Windows.Forms.ToolTip toolTipOpenFile_URI;
        private System.Windows.Forms.ToolTip toolTipDone_URI;
        private System.Windows.Forms.ToolTip toolTipSaveFile_URI;
    }
}

