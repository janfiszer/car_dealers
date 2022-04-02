namespace car_dealers
{
    partial class Form1
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
            this.button_addCar = new System.Windows.Forms.Button();
            this.button_findCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addCar
            // 
            this.button_addCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_addCar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addCar.Location = new System.Drawing.Point(265, 108);
            this.button_addCar.Name = "button_addCar";
            this.button_addCar.Size = new System.Drawing.Size(159, 68);
            this.button_addCar.TabIndex = 0;
            this.button_addCar.Text = "ADD A CAR";
            this.button_addCar.UseVisualStyleBackColor = true;
            this.button_addCar.Click += new System.EventHandler(this.button_addCar_Click);
            // 
            // button_findCar
            // 
            this.button_findCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_findCar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_findCar.Location = new System.Drawing.Point(265, 182);
            this.button_findCar.Name = "button_findCar";
            this.button_findCar.Size = new System.Drawing.Size(159, 68);
            this.button_findCar.TabIndex = 1;
            this.button_findCar.Text = "FIND A CAR";
            this.button_findCar.UseVisualStyleBackColor = true;
            this.button_findCar.Click += new System.EventHandler(this.button_findCar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_findCar);
            this.Controls.Add(this.button_addCar);
            this.Name = "Form1";
            this.Text = "CarDealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addCar;
        private System.Windows.Forms.Button button_findCar;
        private System.Windows.Forms.Label label1;
    }
}

