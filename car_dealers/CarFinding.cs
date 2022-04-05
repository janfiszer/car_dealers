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
    public partial class CarFinding : Form
    {
        Form1 form1;
        Car selectedCar;
        public Car SelectedCar
        {
            get { return selectedCar; }
        }
        public CarFinding(Form1 form1)
        {
            this.Location = form1.Location;
            this.Size = form1.Size;
            this.form1 = form1;

            InitializeComponent();

            InitCombobox_brand();
            button_rentIt.Visible = false;
            label5.Visible = false;
        }

        private void InitCombobox_brand()
        {
            comboBox_model.Enabled = false;
            comboBox_engine.Enabled = false;
            comboBox_color.Enabled = false;
            button_showCar.Enabled = false;

            if (form1.Cars != null)
            {
                foreach (Car c in form1.Cars)
                {
                    if (!comboBox_brand.Items.Contains(c.Brand))
                    {
                        comboBox_brand.Items.Add(c.Brand);
                    }
                }
            }
        }


        // COMBOBOXES brand -> model -> color -> engine
        private void comboBox_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_model.Items.Clear();
            foreach (Car c in form1.Cars)
            {
                // if a model suit brand and haven't been added before
                if (c.Brand.Equals(comboBox_brand.SelectedItem) && !comboBox_model.Items.Contains(c.Model))
                {
                    comboBox_model.Items.Add(c.Model);
                    comboBox_model.Enabled = true;
                    //MessageBox.Show(c.Model);
                }
            }
        }
        private void comboBox_model_IndexChanged(object sender, EventArgs e)
        {
            comboBox_color.Items.Clear();
            foreach (Car c in form1.Cars)
            {
                if (c.Model.Equals(comboBox_model.SelectedItem) && !comboBox_color.Items.Contains(c.Color))
                {
                    comboBox_color.Items.Add(c.Color);
                    comboBox_color.Enabled = true;
                }
            }
        }
        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_engine.Items.Clear();
            foreach(Car c in form1.Cars)
            {
                // TODO: FIX COMBOBOXES if white two white cars comboBox_enginge doesn't work well
                if (c.Model.Equals(comboBox_model.SelectedItem) && c.Color.Equals(comboBox_color.SelectedItem) && !comboBox_engine.Items.Contains(c.Engine))
                {
                    comboBox_engine.Items.Add(c.Engine);
                    comboBox_engine.Enabled = true;
                    selectedCar = c;
                }
            }
        }
        private void comboBox_engine_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_showCar.Enabled = true;
        }

        private void button_showCar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(selectedCar.ImagePath);
            button_rentIt.Visible = true;
            label5.Visible = true;
        }

        private void button_rentIt_Click(object sender, EventArgs e)
        {
            CarRenting carRenting = new CarRenting(this, selectedCar.ImagePath);
            carRenting.Show();
        }
    }
}
