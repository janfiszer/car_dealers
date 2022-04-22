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

        public List<Car> Cars
            { get { return cars; } }
        public Form1()
        {
            InitializeComponent();

            getCarsFromFile();
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
            try
            {
                foreach (string line in System.IO.File.ReadLines("all-cars.csv"))
                {
                    string[] split = line.Split(';');
                    // WARNING: not sure if the third input is rigth

                    Car carToAdd = new Car(split[0], split[1], (Engine)Enum.Parse(typeof(Engine), split[2]), split[3], split[4]);
                    cars.Add(carToAdd);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("haven't loaded all cars succesfully" + e);
            }
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
    }
}
