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
            button_addCar.Enabled = false;
        }

        private void enginesToComboBox()
        {
            foreach (Engine e in Enum.GetValues(typeof(Engine)))
            {
                comboBox2.Items.Add(e);
            }
        }

        // BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = openFileDialog1.FileName;
        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            string brand = textBox1.Text;
            string model = textBox2.Text;
            Engine engine = new Engine();
            engine = (Engine)Enum.Parse(typeof(Engine), comboBox2.SelectedItem.ToString(), true);
            Color color = colorDialog1.Color;
            string imagePath = openFileDialog1.FileName;

            pictureBox1.Image = Image.FromFile(imagePath);
            string all = brand + ";" + model + ";" + engine.ToString() + ";"  + color.Name + ";" + imagePath + "\n";

            MessageBox.Show(all);

            Car car = new Car(brand, model, engine, color.Name, imagePath);
            form1.addToCarList(car);
            // TODO: adding to brandList
            // TODO: don't do that every time after adding a car
            form1.carListToFile("all-cars.csv");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_addCar.Enabled = true;
        }
    }
}
