using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealers
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();
        private List<string> brandList = new List<string>();
        private List<string> models = new List<string>();


        public List<string> BrandList
        {
            get { return brandList; }
        }
        public Form1()
        {
            InitializeComponent();
            getCarsFromFile();
            label2.Text = cars.Count.ToString();
            label3.Text = brandList.Count.ToString();
        }

        // BUTTONS
        private void button_findCar_Click(object sender, EventArgs e)
        {
            CarFinding carFinding = new CarFinding(this);
            carFinding.Show();
        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            CarAdding caradding = new CarAdding(this);
            caradding.Show();
        }

        // CARS LIST
        public void addToCarList(Car car)
        {
            if (car != null)
            {
                cars.Add(car);
            }    
        }
        private void getCarsFromFile()
        {
            foreach (string line in System.IO.File.ReadLines("all-cars.csv"))
            {
                string [] split = line.Split(';');
                // WARNING: not sure if the third input is rigth

                Car carToAdd = new Car(split[0], split[1], (Engine)Enum.Parse(typeof(Engine), split[2]), split[3], split[4]);
                addToBrandList(split[0]);
                cars.Add(carToAdd);
            }
        }
        private bool addToBrandList(string brand)
        {
            if (brand != null && !brandList.Contains(brand))
            {
                brandList.Add(brand);
                return true;
            }
            return false;
        }

        public void carListToFile(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Car car in cars)
            {
                sb.Append(car.ToString());
            }
            File.WriteAllText(fileName, sb.ToString());
        }

        //public List<string> getBrands()
        //{
        //    List<string> list = new List<string>();
        //    foreach(Car car in cars)
        //    {
       
        //    }
        //}
    }
}
