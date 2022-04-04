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
        public CarFinding(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            InitCombobox1();
        }

        private void InitCombobox1()
        {
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
        private void button_showCar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Car c in form1.Cars)
            {
                if (c.Brand.Equals(comboBox_brand.SelectedItem))
                {
                    comboBox_model.Items.Add(c.Model);
                    MessageBox.Show(c.Model);
                }
            }
        }
    }
}
