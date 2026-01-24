namespace teachingRoom111SS.userControll
{
    partial class ucSellingInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Khmer OS Battambang", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(3, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(87, 43);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "label2";
            // 
            // ptbIcon
            // 
            this.ptbIcon.ImageLocation = "https://img.icons8.com/sf-black-filled/1200/image.jpg";
            this.ptbIcon.Location = new System.Drawing.Point(193, 22);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(94, 94);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 2;
            this.ptbIcon.TabStop = false;
            // 
            // ucSellingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbIcon);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ucSellingInformation";
            this.Size = new System.Drawing.Size(306, 142);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.PictureBox ptbIcon;
    }
}
