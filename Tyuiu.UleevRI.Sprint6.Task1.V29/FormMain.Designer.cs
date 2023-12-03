
namespace Tyuiu.UleevRI.Sprint6.Task1.V29
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
            this.groupBoxInputData_URI = new System.Windows.Forms.GroupBox();
            this.textBoxVarStart_URI = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_URI = new System.Windows.Forms.TextBox();
            this.labelVarStart_URI = new System.Windows.Forms.Label();
            this.labelVarStop_URI = new System.Windows.Forms.Label();
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_URI = new System.Windows.Forms.TextBox();
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.groupBoxResult_URI = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInputData_URI.SuspendLayout();
            this.groupBoxCondition_URI.SuspendLayout();
            this.groupBoxResult_URI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInputData_URI
            // 
            this.groupBoxInputData_URI.Controls.Add(this.labelVarStop_URI);
            this.groupBoxInputData_URI.Controls.Add(this.labelVarStart_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxVarStop_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxVarStart_URI);
            this.groupBoxInputData_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_URI.Location = new System.Drawing.Point(12, 320);
            this.groupBoxInputData_URI.Name = "groupBoxInputData_URI";
            this.groupBoxInputData_URI.Size = new System.Drawing.Size(293, 100);
            this.groupBoxInputData_URI.TabIndex = 0;
            this.groupBoxInputData_URI.TabStop = false;
            this.groupBoxInputData_URI.Text = "Ввод данных";
            // 
            // textBoxVarStart_URI
            // 
            this.textBoxVarStart_URI.Location = new System.Drawing.Point(7, 58);
            this.textBoxVarStart_URI.Name = "textBoxVarStart_URI";
            this.textBoxVarStart_URI.Size = new System.Drawing.Size(131, 24);
            this.textBoxVarStart_URI.TabIndex = 0;
            // 
            // textBoxVarStop_URI
            // 
            this.textBoxVarStop_URI.Location = new System.Drawing.Point(158, 56);
            this.textBoxVarStop_URI.Name = "textBoxVarStop_URI";
            this.textBoxVarStop_URI.Size = new System.Drawing.Size(131, 24);
            this.textBoxVarStop_URI.TabIndex = 1;
            // 
            // labelVarStart_URI
            // 
            this.labelVarStart_URI.AutoSize = true;
            this.labelVarStart_URI.Location = new System.Drawing.Point(7, 35);
            this.labelVarStart_URI.Name = "labelVarStart_URI";
            this.labelVarStart_URI.Size = new System.Drawing.Size(90, 18);
            this.labelVarStart_URI.TabIndex = 2;
            this.labelVarStart_URI.Text = "Старт шага:";
            // 
            // labelVarStop_URI
            // 
            this.labelVarStop_URI.AutoSize = true;
            this.labelVarStop_URI.Location = new System.Drawing.Point(155, 35);
            this.labelVarStop_URI.Name = "labelVarStop_URI";
            this.labelVarStop_URI.Size = new System.Drawing.Size(92, 18);
            this.labelVarStop_URI.TabIndex = 3;
            this.labelVarStop_URI.Text = "Конец шага:";
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.textBoxCondition_URI);
            this.groupBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(19, 24);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(517, 290);
            this.groupBoxCondition_URI.TabIndex = 1;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = "Условие";
            // 
            // textBoxCondition_URI
            // 
            this.textBoxCondition_URI.Location = new System.Drawing.Point(6, 16);
            this.textBoxCondition_URI.Multiline = true;
            this.textBoxCondition_URI.Name = "textBoxCondition_URI";
            this.textBoxCondition_URI.ReadOnly = true;
            this.textBoxCondition_URI.Size = new System.Drawing.Size(481, 252);
            this.textBoxCondition_URI.TabIndex = 0;
            this.textBoxCondition_URI.Text = "Протабулировать функцию F(x) = cox(x)/(x+1) - cos(x)*1.3 + 3x на заданном диапозо" +
    "не. \r\nРезультат вывести в виде таблицы.";
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_URI.Location = new System.Drawing.Point(311, 330);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(99, 90);
            this.buttonHelp_URI.TabIndex = 2;
            this.buttonHelp_URI.Text = "Справка";
            this.buttonHelp_URI.UseVisualStyleBackColor = false;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_URI_Click);
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_URI.Location = new System.Drawing.Point(416, 330);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(120, 90);
            this.buttonDone_URI.TabIndex = 3;
            this.buttonDone_URI.Text = "Выполнить";
            this.buttonDone_URI.UseVisualStyleBackColor = false;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_URI_Click);
            // 
            // groupBoxResult_URI
            // 
            this.groupBoxResult_URI.Controls.Add(this.label2);
            this.groupBoxResult_URI.Controls.Add(this.textBoxResult);
            this.groupBoxResult_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_URI.Location = new System.Drawing.Point(543, 24);
            this.groupBoxResult_URI.Name = "groupBoxResult_URI";
            this.groupBoxResult_URI.Size = new System.Drawing.Size(394, 396);
            this.groupBoxResult_URI.TabIndex = 4;
            this.groupBoxResult_URI.TabStop = false;
            this.groupBoxResult_URI.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(7, 46);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(381, 344);
            this.textBoxResult.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.groupBoxResult_URI);
            this.Controls.Add(this.buttonDone_URI);
            this.Controls.Add(this.buttonHelp_URI);
            this.Controls.Add(this.groupBoxCondition_URI);
            this.Controls.Add(this.groupBoxInputData_URI);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Улеев Р.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInputData_URI.ResumeLayout(false);
            this.groupBoxInputData_URI.PerformLayout();
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            this.groupBoxResult_URI.ResumeLayout(false);
            this.groupBoxResult_URI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputData_URI;
        private System.Windows.Forms.Label labelVarStop_URI;
        private System.Windows.Forms.Label labelVarStart_URI;
        private System.Windows.Forms.TextBox textBoxVarStop_URI;
        private System.Windows.Forms.TextBox textBoxVarStart_URI;
        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBoxCondition_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.GroupBox groupBoxResult_URI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

