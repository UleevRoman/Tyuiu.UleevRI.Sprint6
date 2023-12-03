
namespace Tyuiu.UleevRI.Sprint6.Task0.V26
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
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.groupBoxInputData_URI = new System.Windows.Forms.GroupBox();
            this.labelVarX_URI = new System.Windows.Forms.Label();
            this.textBoxVarX_URI = new System.Windows.Forms.TextBox();
            this.groupBoxPrintData_URI = new System.Windows.Forms.GroupBox();
            this.labelResult_URI = new System.Windows.Forms.Label();
            this.textBoxResult_URI = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_URI = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_URI = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_URI.SuspendLayout();
            this.groupBoxPrintData_URI.SuspendLayout();
            this.groupBoxCondition_URI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.Location = new System.Drawing.Point(612, 392);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(166, 46);
            this.buttonDone_URI.TabIndex = 0;
            this.buttonDone_URI.Text = "Выполнить";
            this.buttonDone_URI.UseVisualStyleBackColor = true;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_URI_Click);
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_URI.Location = new System.Drawing.Point(544, 392);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(62, 46);
            this.buttonHelp_URI.TabIndex = 1;
            this.buttonHelp_URI.Text = "?";
            this.buttonHelp_URI.UseVisualStyleBackColor = true;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_URI_Click);
            // 
            // groupBoxInputData_URI
            // 
            this.groupBoxInputData_URI.Controls.Add(this.labelVarX_URI);
            this.groupBoxInputData_URI.Controls.Add(this.textBoxVarX_URI);
            this.groupBoxInputData_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_URI.Location = new System.Drawing.Point(27, 272);
            this.groupBoxInputData_URI.Name = "groupBoxInputData_URI";
            this.groupBoxInputData_URI.Size = new System.Drawing.Size(488, 166);
            this.groupBoxInputData_URI.TabIndex = 2;
            this.groupBoxInputData_URI.TabStop = false;
            this.groupBoxInputData_URI.Text = "Ввод данных";
            // 
            // labelVarX_URI
            // 
            this.labelVarX_URI.AutoSize = true;
            this.labelVarX_URI.Location = new System.Drawing.Point(13, 44);
            this.labelVarX_URI.Name = "labelVarX_URI";
            this.labelVarX_URI.Size = new System.Drawing.Size(135, 20);
            this.labelVarX_URI.TabIndex = 1;
            this.labelVarX_URI.Text = "Переменная X:";
            // 
            // textBoxVarX_URI
            // 
            this.textBoxVarX_URI.Location = new System.Drawing.Point(9, 67);
            this.textBoxVarX_URI.Name = "textBoxVarX_URI";
            this.textBoxVarX_URI.Size = new System.Drawing.Size(139, 27);
            this.textBoxVarX_URI.TabIndex = 0;
            this.textBoxVarX_URI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_URI_KeyPress);
            // 
            // groupBoxPrintData_URI
            // 
            this.groupBoxPrintData_URI.Controls.Add(this.labelResult_URI);
            this.groupBoxPrintData_URI.Controls.Add(this.textBoxResult_URI);
            this.groupBoxPrintData_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPrintData_URI.Location = new System.Drawing.Point(544, 272);
            this.groupBoxPrintData_URI.Name = "groupBoxPrintData_URI";
            this.groupBoxPrintData_URI.Size = new System.Drawing.Size(235, 115);
            this.groupBoxPrintData_URI.TabIndex = 3;
            this.groupBoxPrintData_URI.TabStop = false;
            this.groupBoxPrintData_URI.Text = "Вывод данных";
            // 
            // labelResult_URI
            // 
            this.labelResult_URI.AutoSize = true;
            this.labelResult_URI.Location = new System.Drawing.Point(20, 44);
            this.labelResult_URI.Name = "labelResult_URI";
            this.labelResult_URI.Size = new System.Drawing.Size(102, 20);
            this.labelResult_URI.TabIndex = 1;
            this.labelResult_URI.Text = "Результат:";
            // 
            // textBoxResult_URI
            // 
            this.textBoxResult_URI.Location = new System.Drawing.Point(6, 67);
            this.textBoxResult_URI.Name = "textBoxResult_URI";
            this.textBoxResult_URI.ReadOnly = true;
            this.textBoxResult_URI.Size = new System.Drawing.Size(133, 27);
            this.textBoxResult_URI.TabIndex = 0;
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.pictureBoxFormula_URI);
            this.groupBoxCondition_URI.Controls.Add(this.textBoxCondition_URI);
            this.groupBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(27, 22);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(752, 244);
            this.groupBoxCondition_URI.TabIndex = 4;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = "Условие";
            // 
            // pictureBoxFormula_URI
            // 
            this.pictureBoxFormula_URI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_URI.Image")));
            this.pictureBoxFormula_URI.Location = new System.Drawing.Point(517, 21);
            this.pictureBoxFormula_URI.Name = "pictureBoxFormula_URI";
            this.pictureBoxFormula_URI.Size = new System.Drawing.Size(229, 128);
            this.pictureBoxFormula_URI.TabIndex = 1;
            this.pictureBoxFormula_URI.TabStop = false;
            // 
            // textBoxCondition_URI
            // 
            this.textBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_URI.Location = new System.Drawing.Point(9, 21);
            this.textBoxCondition_URI.Multiline = true;
            this.textBoxCondition_URI.Name = "textBoxCondition_URI";
            this.textBoxCondition_URI.ReadOnly = true;
            this.textBoxCondition_URI.Size = new System.Drawing.Size(479, 204);
            this.textBoxCondition_URI.TabIndex = 0;
            this.textBoxCondition_URI.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.groupBoxCondition_URI);
            this.Controls.Add(this.groupBoxPrintData_URI);
            this.Controls.Add(this.groupBoxInputData_URI);
            this.Controls.Add(this.buttonHelp_URI);
            this.Controls.Add(this.buttonDone_URI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Улеев Р.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInputData_URI.ResumeLayout(false);
            this.groupBoxInputData_URI.PerformLayout();
            this.groupBoxPrintData_URI.ResumeLayout(false);
            this.groupBoxPrintData_URI.PerformLayout();
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_URI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.GroupBox groupBoxInputData_URI;
        private System.Windows.Forms.Label labelVarX_URI;
        private System.Windows.Forms.TextBox textBoxVarX_URI;
        private System.Windows.Forms.GroupBox groupBoxPrintData_URI;
        private System.Windows.Forms.Label labelResult_URI;
        private System.Windows.Forms.TextBox textBoxResult_URI;
        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBoxCondition_URI;
        private System.Windows.Forms.PictureBox pictureBoxFormula_URI;
    }
}

