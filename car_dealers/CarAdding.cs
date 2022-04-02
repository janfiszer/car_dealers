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
    public partial class CarAdding : Form
    {
        Form1 form1;
        public CarAdding(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            enginesToComboBox();
        }

        private void enginesToComboBox()
        {
            foreach (Engine e in Enum.GetValues(typeof(Engine)))
            {
                comboBox2.Items.Add(e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            string brand = textBox1.Text;
            string model = textBox2.Text;
            Engine engine = new Engine();
            Color color = colorDialog1.Color;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            string all = brand + " " + model + " " + " " + engine.ToString() + " "  + color;
            MessageBox.Show(all);
            Car car = new Car();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = openFileDialog1.FileName;

        }
    }
}
