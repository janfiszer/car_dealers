namespace car_dealers
{
    partial class CarFinding
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
            this.comboBox_engine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_brand = new System.Windows.Forms.ComboBox();
            this.comboBox_model = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.button_showCar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_rentIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_engine
            // 
            this.comboBox_engine.FormattingEnabled = true;
            this.comboBox_engine.Location = new System.Drawing.Point(97, 133);
            this.comboBox_engine.Name = "comboBox_engine";
            this.comboBox_engine.Size = new System.Drawing.Size(121, 21);
            this.comboBox_engine.TabIndex = 18;
            this.comboBox_engine.SelectedIndexChanged += new System.EventHandler(this.comboBox_engine_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Engine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Brand:";
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.FormattingEnabled = true;
            this.comboBox_brand.Location = new System.Drawing.Point(97, 52);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.Size = new System.Drawing.Size(121, 21);
            this.comboBox_brand.TabIndex = 19;
            this.comboBox_brand.SelectedIndexChanged += new System.EventHandler(this.comboBox_brand_SelectedIndexChanged);
            // 
            // comboBox_model
            // 
            this.comboBox_model.FormattingEnabled = true;
            this.comboBox_model.Location = new System.Drawing.Point(97, 79);
            this.comboBox_model.Name = "comboBox_model";
            this.comboBox_model.Size = new System.Drawing.Size(121, 21);
            this.comboBox_model.TabIndex = 20;
            this.comboBox_model.SelectedIndexChanged += new System.EventHandler(this.comboBox_model_IndexChanged);
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(97, 106);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 21);
            this.comboBox_color.TabIndex = 21;
            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);
            // 
            // button_showCar
            // 
            this.button_showCar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showCar.Location = new System.Drawing.Point(31, 160);
            this.button_showCar.Name = "button_showCar";
            this.button_showCar.Size = new System.Drawing.Size(185, 68);
            this.button_showCar.TabIndex = 22;
            this.button_showCar.Text = "Show that car";
            this.button_showCar.UseVisualStyleBackColor = true;
            this.button_showCar.Click += new System.EventHandler(this.button_showCar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "This is car for You!";
            // 
            // button_rentIt
            // 
            this.button_rentIt.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rentIt.Location = new System.Drawing.Point(581, 160);
            this.button_rentIt.Name = "button_rentIt";
            this.button_rentIt.Size = new System.Drawing.Size(91, 68);
            this.button_rentIt.TabIndex = 25;
            this.button_rentIt.Text = "Rent it";
            this.button_rentIt.UseVisualStyleBackColor = true;
            this.button_rentIt.Click += new System.EventHandler(this.button_rentIt_Click);
            // 
            // CarFinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button_rentIt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_showCar);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_model);
            this.Controls.Add(this.comboBox_brand);
            this.Controls.Add(this.comboBox_engine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarFinding";
            this.Text = "CarFinding";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_engine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_brand;
        private System.Windows.Forms.ComboBox comboBox_model;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Button button_showCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_rentIt;
    }
}