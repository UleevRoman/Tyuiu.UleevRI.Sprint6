
namespace Tyuiu.UleevRI.Sprint6.Task6.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxInformation_URI = new System.Windows.Forms.PictureBox();
            this.labelInform_URI = new System.Windows.Forms.Label();
            this.buttonOK_URI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInformation_URI
            // 
            this.pictureBoxInformation_URI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInformation_URI.Image")));
            this.pictureBoxInformation_URI.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxInformation_URI.Name = "pictureBoxInformation_URI";
            this.pictureBoxInformation_URI.Size = new System.Drawing.Size(228, 216);
            this.pictureBoxInformation_URI.TabIndex = 0;
            this.pictureBoxInformation_URI.TabStop = false;
            // 
            // labelInform_URI
            // 
            this.labelInform_URI.AutoSize = true;
            this.labelInform_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInform_URI.Location = new System.Drawing.Point(303, 13);
            this.labelInform_URI.Name = "labelInform_URI";
            this.labelInform_URI.Size = new System.Drawing.Size(384, 162);
            this.labelInform_URI.TabIndex = 1;
            this.labelInform_URI.Text = resources.GetString("labelInform_URI.Text");
            // 
            // buttonOK_URI
            // 
            this.buttonOK_URI.BackColor = System.Drawing.Color.Silver;
            this.buttonOK_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_URI.Location = new System.Drawing.Point(676, 243);
            this.buttonOK_URI.Name = "buttonOK_URI";
            this.buttonOK_URI.Size = new System.Drawing.Size(93, 44);
            this.buttonOK_URI.TabIndex = 2;
            this.buttonOK_URI.Text = "ОК";
            this.buttonOK_URI.UseVisualStyleBackColor = false;
            this.buttonOK_URI.Click += new System.EventHandler(this.buttonOK_URI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.buttonOK_URI);
            this.Controls.Add(this.labelInform_URI);
            this.Controls.Add(this.pictureBoxInformation_URI);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 346);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 346);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation_URI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInformation_URI;
        private System.Windows.Forms.Label labelInform_URI;
        private System.Windows.Forms.Button buttonOK_URI;
    }
}