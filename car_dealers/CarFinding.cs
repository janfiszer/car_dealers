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
            //InitComboboxes();
            this.form1 = form1;
        }

        //private void InitComboboxes()
        //{
        //    List<string> brandList = new List<string>();
        //    brandList = form1.BrandList;
        //    if (brandList != null)
        //    {
        //        label5.Text = brandList.Count.ToString();
        //        foreach (string brand in brandList)
        //        {
        //            comboBox1.Items.Add(brand);
        //        }
        //    }
        //    else label5.Text = "cipa";
        //}
        private void button_showCar_Click(object sender, EventArgs e)
        {

        }
    }
}
