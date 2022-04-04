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
                    if (!comboBox1.Items.Contains(c.Model))
                    {
                        comboBox1.Items.Add(c.Model);
                    }
                }
            }
        }
        private void button_showCar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach(Car c in Form1.cars)
           {

           }
        }
    }
}
