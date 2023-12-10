
namespace Tyuiu.UleevRI.Sprint6.Task6.V5
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
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.buttonOpenFile_URI = new System.Windows.Forms.Button();
            this.panelCondition_URI = new System.Windows.Forms.Panel();
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_URI = new System.Windows.Forms.TextBox();
            this.panelInputData_URI = new System.Windows.Forms.Panel();
            this.groupBox_URI = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxLoadFile_URI = new System.Windows.Forms.TextBox();
            this.panelResult_URI = new System.Windows.Forms.Panel();
            this.groupBoxСonclusion_URI = new System.Windows.Forms.GroupBox();
            this.textBoxPerform_URI = new System.Windows.Forms.TextBox();
            this.toolTipOpenFile_URI = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipDone_URI = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHelp_URI = new System.Windows.Forms.ToolTip(this.components);
            this.panelFile_URI.SuspendLayout();
            this.panelCondition_URI.SuspendLayout();
            this.groupBoxCondition_URI.SuspendLayout();
            this.panelInputData_URI.SuspendLayout();
            this.groupBox_URI.SuspendLayout();
            this.panelResult_URI.SuspendLayout();
            this.groupBoxСonclusion_URI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFile_URI
            // 
            this.panelFile_URI.Controls.Add(this.buttonHelp_URI);
            this.panelFile_URI.Controls.Add(this.buttonDone_URI);
            this.panelFile_URI.Controls.Add(this.buttonOpenFile_URI);
            this.panelFile_URI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFile_URI.Location = new System.Drawing.Point(0, 0);
            this.panelFile_URI.Name = "panelFile_URI";
            this.panelFile_URI.Size = new System.Drawing.Size(1108, 99);
            this.panelFile_URI.TabIndex = 0;
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_URI.Image")));
            this.buttonHelp_URI.Location = new System.Drawing.Point(986, 15);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(110, 74);
            this.buttonHelp_URI.TabIndex = 2;
            this.toolTipHelp_URI.SetToolTip(this.buttonHelp_URI, "О программе");
            this.buttonHelp_URI.UseVisualStyleBackColor = true;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_URI_Click);
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.BackColor = System.Drawing.Color.Silver;
            this.buttonDone_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_URI.Image")));
            this.buttonDone_URI.Location = new System.Drawing.Point(150, 15);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(105, 74);
            this.buttonDone_URI.TabIndex = 1;
            this.toolTipDone_URI.SetToolTip(this.buttonDone_URI, "Нажмите, чтобы продолжить");
            this.buttonDone_URI.UseVisualStyleBackColor = false;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_URI_Click);
            // 
            // buttonOpenFile_URI
            // 
            this.buttonOpenFile_URI.BackColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_URI.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_URI.Image")));
            this.buttonOpenFile_URI.Location = new System.Drawing.Point(25, 15);
            this.buttonOpenFile_URI.Name = "buttonOpenFile_URI";
            this.buttonOpenFile_URI.Size = new System.Drawing.Size(104, 74);
            this.buttonOpenFile_URI.TabIndex = 0;
            this.toolTipOpenFile_URI.SetToolTip(this.buttonOpenFile_URI, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_URI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_URI.Click += new System.EventHandler(this.buttonOpenFile_URI_Click);
            // 
            // panelCondition_URI
            // 
            this.panelCondition_URI.Controls.Add(this.groupBoxCondition_URI);
            this.panelCondition_URI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_URI.Location = new System.Drawing.Point(0, 99);
            this.panelCondition_URI.Name = "panelCondition_URI";
            this.panelCondition_URI.Size = new System.Drawing.Size(1108, 129);
            this.panelCondition_URI.TabIndex = 1;
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.textBoxCondition_URI);
            this.groupBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(1293, 124);
            this.groupBoxCondition_URI.TabIndex = 0;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = "Условие:";
            // 
            // textBoxCondition_URI
            // 
            this.textBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_URI.Location = new System.Drawing.Point(20, 27);
            this.textBoxCondition_URI.Multiline = true;
            this.textBoxCondition_URI.Name = "textBoxCondition_URI";
            this.textBoxCondition_URI.ReadOnly = true;
            this.textBoxCondition_URI.Size = new System.Drawing.Size(1255, 90);
            this.textBoxCondition_URI.TabIndex = 0;
            this.textBoxCondition_URI.Text = resources.GetString("textBoxCondition_URI.Text");
            // 
            // panelInputData_URI
            // 
            this.panelInputData_URI.Controls.Add(this.groupBox_URI);
            this.panelInputData_URI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputData_URI.Location = new System.Drawing.Point(0, 228);
            this.panelInputData_URI.Name = "panelInputData_URI";
            this.panelInputData_URI.Size = new System.Drawing.Size(544, 455);
            this.panelInputData_URI.TabIndex = 2;
            // 
            // groupBox_URI
            // 
            this.groupBox_URI.Controls.Add(this.splitter1);
            this.groupBox_URI.Controls.Add(this.textBoxLoadFile_URI);
            this.groupBox_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_URI.Location = new System.Drawing.Point(0, 0);
            this.groupBox_URI.Name = "groupBox_URI";
            this.groupBox_URI.Size = new System.Drawing.Size(544, 455);
            this.groupBox_URI.TabIndex = 0;
            this.groupBox_URI.TabStop = false;
            this.groupBox_URI.Text = "Ввод данных:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(538, 20);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 432);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // textBoxLoadFile_URI
            // 
            this.textBoxLoadFile_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFile_URI.Location = new System.Drawing.Point(3, 20);
            this.textBoxLoadFile_URI.Multiline = true;
            this.textBoxLoadFile_URI.Name = "textBoxLoadFile_URI";
            this.textBoxLoadFile_URI.Size = new System.Drawing.Size(538, 432);
            this.textBoxLoadFile_URI.TabIndex = 0;
            // 
            // panelResult_URI
            // 
            this.panelResult_URI.Controls.Add(this.groupBoxСonclusion_URI);
            this.panelResult_URI.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelResult_URI.Location = new System.Drawing.Point(547, 228);
            this.panelResult_URI.Name = "panelResult_URI";
            this.panelResult_URI.Size = new System.Drawing.Size(561, 455);
            this.panelResult_URI.TabIndex = 3;
            // 
            // groupBoxСonclusion_URI
            // 
            this.groupBoxСonclusion_URI.Controls.Add(this.textBoxPerform_URI);
            this.groupBoxСonclusion_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxСonclusion_URI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxСonclusion_URI.Name = "groupBoxСonclusion_URI";
            this.groupBoxСonclusion_URI.Size = new System.Drawing.Size(561, 455);
            this.groupBoxСonclusion_URI.TabIndex = 1;
            this.groupBoxСonclusion_URI.TabStop = false;
            this.groupBoxСonclusion_URI.Text = "Вывод данных:";
            // 
            // textBoxPerform_URI
            // 
            this.textBoxPerform_URI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPerform_URI.Location = new System.Drawing.Point(3, 20);
            this.textBoxPerform_URI.Multiline = true;
            this.textBoxPerform_URI.Name = "textBoxPerform_URI";
            this.textBoxPerform_URI.Size = new System.Drawing.Size(555, 432);
            this.textBoxPerform_URI.TabIndex = 0;
            // 
            // toolTipOpenFile_URI
            // 
            this.toolTipOpenFile_URI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFile_URI.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipDone_URI
            // 
            this.toolTipDone_URI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDone_URI.ToolTipTitle = "Подсказка";
            // 
            // toolTipHelp_URI
            // 
            this.toolTipHelp_URI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_URI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 683);
            this.Controls.Add(this.panelResult_URI);
            this.Controls.Add(this.panelInputData_URI);
            this.Controls.Add(this.panelCondition_URI);
            this.Controls.Add(this.panelFile_URI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 5 | Улеев Р.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelFile_URI.ResumeLayout(false);
            this.panelCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            this.panelInputData_URI.ResumeLayout(false);
            this.groupBox_URI.ResumeLayout(false);
            this.groupBox_URI.PerformLayout();
            this.panelResult_URI.ResumeLayout(false);
            this.groupBoxСonclusion_URI.ResumeLayout(false);
            this.groupBoxСonclusion_URI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFile_URI;
        private System.Windows.Forms.Button buttonOpenFile_URI;
        private System.Windows.Forms.Panel panelCondition_URI;
        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBoxCondition_URI;
        private System.Windows.Forms.Panel panelInputData_URI;
        private System.Windows.Forms.Panel panelResult_URI;
        private System.Windows.Forms.ToolTip toolTipOpenFile_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.GroupBox groupBox_URI;
        private System.Windows.Forms.TextBox textBoxLoadFile_URI;
        private System.Windows.Forms.GroupBox groupBoxСonclusion_URI;
        private System.Windows.Forms.TextBox textBoxPerform_URI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipDone_URI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolTip toolTipHelp_URI;
    }
}

