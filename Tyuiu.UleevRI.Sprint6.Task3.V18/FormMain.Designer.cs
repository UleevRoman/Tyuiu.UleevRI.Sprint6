
namespace Tyuiu.UleevRI.Sprint6.Task3.V18
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
            this.groupBoxCondition_URI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_URI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_URI = new System.Windows.Forms.GroupBox();
            this.buttonHelp_URI = new System.Windows.Forms.Button();
            this.buttonDone_URI = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_URI = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixResult_URI = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_URI.SuspendLayout();
            this.groupBoxResult_URI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_URI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_URI
            // 
            this.groupBoxCondition_URI.Controls.Add(this.dataGridViewMatrix_URI);
            this.groupBoxCondition_URI.Controls.Add(this.textBoxCondition_URI);
            this.groupBoxCondition_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_URI.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_URI.Name = "groupBoxCondition_URI";
            this.groupBoxCondition_URI.Size = new System.Drawing.Size(658, 403);
            this.groupBoxCondition_URI.TabIndex = 0;
            this.groupBoxCondition_URI.TabStop = false;
            this.groupBoxCondition_URI.Text = " Условие";
            // 
            // textBoxCondition_URI
            // 
            this.textBoxCondition_URI.Location = new System.Drawing.Point(6, 23);
            this.textBoxCondition_URI.Multiline = true;
            this.textBoxCondition_URI.Name = "textBoxCondition_URI";
            this.textBoxCondition_URI.ReadOnly = true;
            this.textBoxCondition_URI.Size = new System.Drawing.Size(297, 380);
            this.textBoxCondition_URI.TabIndex = 0;
            this.textBoxCondition_URI.Text = resources.GetString("textBoxCondition_URI.Text");
            // 
            // groupBoxResult_URI
            // 
            this.groupBoxResult_URI.Controls.Add(this.dataGridViewMatrixResult_URI);
            this.groupBoxResult_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_URI.Location = new System.Drawing.Point(691, 24);
            this.groupBoxResult_URI.Name = "groupBoxResult_URI";
            this.groupBoxResult_URI.Size = new System.Drawing.Size(326, 333);
            this.groupBoxResult_URI.TabIndex = 1;
            this.groupBoxResult_URI.TabStop = false;
            this.groupBoxResult_URI.Text = "Вывод данных";
            // 
            // buttonHelp_URI
            // 
            this.buttonHelp_URI.BackColor = System.Drawing.Color.Silver;
            this.buttonHelp_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_URI.Location = new System.Drawing.Point(691, 363);
            this.buttonHelp_URI.Name = "buttonHelp_URI";
            this.buttonHelp_URI.Size = new System.Drawing.Size(75, 53);
            this.buttonHelp_URI.TabIndex = 2;
            this.buttonHelp_URI.Text = "?";
            this.buttonHelp_URI.UseVisualStyleBackColor = false;
            this.buttonHelp_URI.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_URI
            // 
            this.buttonDone_URI.BackColor = System.Drawing.Color.Silver;
            this.buttonDone_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_URI.Location = new System.Drawing.Point(810, 364);
            this.buttonDone_URI.Name = "buttonDone_URI";
            this.buttonDone_URI.Size = new System.Drawing.Size(201, 52);
            this.buttonDone_URI.TabIndex = 3;
            this.buttonDone_URI.Text = "Выполнить";
            this.buttonDone_URI.UseVisualStyleBackColor = false;
            this.buttonDone_URI.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // dataGridViewMatrix_URI
            // 
            this.dataGridViewMatrix_URI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_URI.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_URI.Location = new System.Drawing.Point(329, 23);
            this.dataGridViewMatrix_URI.Name = "dataGridViewMatrix_URI";
            this.dataGridViewMatrix_URI.ReadOnly = true;
            this.dataGridViewMatrix_URI.RowHeadersVisible = false;
            this.dataGridViewMatrix_URI.RowHeadersWidth = 51;
            this.dataGridViewMatrix_URI.RowTemplate.Height = 24;
            this.dataGridViewMatrix_URI.Size = new System.Drawing.Size(323, 380);
            this.dataGridViewMatrix_URI.TabIndex = 1;
            // 
            // dataGridViewMatrixResult_URI
            // 
            this.dataGridViewMatrixResult_URI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_URI.ColumnHeadersVisible = false;
            this.dataGridViewMatrixResult_URI.Location = new System.Drawing.Point(7, 24);
            this.dataGridViewMatrixResult_URI.Name = "dataGridViewMatrixResult_URI";
            this.dataGridViewMatrixResult_URI.ReadOnly = true;
            this.dataGridViewMatrixResult_URI.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_URI.RowHeadersWidth = 51;
            this.dataGridViewMatrixResult_URI.RowTemplate.Height = 24;
            this.dataGridViewMatrixResult_URI.Size = new System.Drawing.Size(313, 303);
            this.dataGridViewMatrixResult_URI.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.buttonDone_URI);
            this.Controls.Add(this.buttonHelp_URI);
            this.Controls.Add(this.groupBoxResult_URI);
            this.Controls.Add(this.groupBoxCondition_URI);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Улеев Р.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_URI.ResumeLayout(false);
            this.groupBoxCondition_URI.PerformLayout();
            this.groupBoxResult_URI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_URI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_URI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_URI;
        private System.Windows.Forms.TextBox textBoxCondition_URI;
        private System.Windows.Forms.GroupBox groupBoxResult_URI;
        private System.Windows.Forms.Button buttonHelp_URI;
        private System.Windows.Forms.Button buttonDone_URI;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_URI;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_URI;
    }
}

