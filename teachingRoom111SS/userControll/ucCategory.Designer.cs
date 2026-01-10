namespace teachingRoom111SS.userControll
{
    partial class ucCategory
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
            this.tbnCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnCategory
            // 
            this.tbnCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbnCategory.Location = new System.Drawing.Point(0, 0);
            this.tbnCategory.Name = "tbnCategory";
            this.tbnCategory.Size = new System.Drawing.Size(135, 45);
            this.tbnCategory.TabIndex = 0;
            this.tbnCategory.Text = "All";
            this.tbnCategory.UseVisualStyleBackColor = true;
            this.tbnCategory.Click += new System.EventHandler(this.tbnCategory_Click);
            // 
            // ucCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbnCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCategory";
            this.Size = new System.Drawing.Size(135, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbnCategory;
    }
}
