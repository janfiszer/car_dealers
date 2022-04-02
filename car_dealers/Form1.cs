using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealers
{
    public partial class Form1 : Form
    {
        private int oldHeight = 700;
        private int oldWidth = 500;
        public Form1()
        {
            InitializeComponent();
            //InitBotton();
        }
        private void InitBotton()
        {
            Button button = new Button();

            button.Size = new Size(100, 50);
            button.Location = new Point((this.Width)/2 - button.Width, (this.Height)/2 - button.Height);
            button.Name = "add_car_button";
            button.Text = "ADD A CAR";
            Controls.Add(button);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                // counting in which proportion od the window is the control
                double apparent_x = (double)control.Location.X/(double)oldWidth;
                double apparent_y = (double)control.Location.Y/(double)oldHeight;

                // new location
                // the location is described by top left corner point, thats why the -control.Width
                double final_x = apparent_x * (double)this.Size.Width;
                double final_y = apparent_y * (double)this.Size.Height;
                //MessageBox.Show(apparent_x.ToString() + " " + apparent_y.ToString() + "\n" + final_x.ToString() + "\n" + final_y.ToString() + "\n" + this.Width + " " + this.Height);
                control.Location = new Point((int)final_x, (int)final_y);
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            oldHeight = this.Height;
            oldWidth = this.Width;
        }

        private void button_findCar_Click(object sender, EventArgs e)
        {

        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            CarAdding caradding = new CarAdding(this);
            caradding.Show();
        }
    }
}
