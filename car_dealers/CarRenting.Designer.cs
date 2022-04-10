namespace car_dealers
{
    partial class CarRenting
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_rentIt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(375, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button_rentIt
            // 
            this.button_rentIt.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rentIt.Location = new System.Drawing.Point(375, 75);
            this.button_rentIt.Name = "button_rentIt";
            this.button_rentIt.Size = new System.Drawing.Size(209, 46);
            this.button_rentIt.TabIndex = 26;
            this.button_rentIt.Text = "Confirm";
            this.button_rentIt.UseVisualStyleBackColor = true;
            this.button_rentIt.Click += new System.EventHandler(this.button_rentIt_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "It is possible to rent a car 40 days in advance";
            // 
            // button_goback
            // 
            this.button_goback.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_goback.Location = new System.Drawing.Point(375, 127);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(209, 46);
            this.button_goback.TabIndex = 29;
            this.button_goback.Text = "Go back";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button_goback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_rentIt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "CarRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CarRenting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_rentIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_goback;
    }
}