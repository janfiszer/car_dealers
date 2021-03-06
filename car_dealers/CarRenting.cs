using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace car_dealers
{
    public partial class CarRenting : Form
    {
        CarFinding carFinding;
        public readonly static int daysInFuture = 40;
        List<(Car, string)> bookedRentingList = new List<(Car, string)> ();


        public CarRenting(CarFinding cf, string ImagePath)
        {
            this.Location = cf.Location;
            this.Size = cf.Size;
            this.carFinding = cf;

            InitializeComponent();
            loadBookedListFromFile("booked-testing-rides.txt");
            InitCombobox();

            pictureBox1.Image = Image.FromFile(ImagePath);
            button_rentIt.Enabled = false;
        }
        private void loadBookedListFromFile(string fileName)
        {
            try
            {
                (Car, string) rent;
                foreach (string line in System.IO.File.ReadLines(fileName))
                {
                    string[] split = line.Split(';');
                    Car carToAdd = new Car(split[1], split[2], (Engine)Enum.Parse(typeof(Engine), split[3]), split[4], split[5]);
                    rent.Item1 = carToAdd;
                    rent.Item2 = split[0];
                    bookedRentingList.Add(rent);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("haven't loaded all booked rides succesfully" + e);
            }
        }
        private void InitCombobox()
        {
            DateTime today = DateTime.Now;
            for (int i = 0; i < daysInFuture; i++)
            {
                string[] split = today.ToString().Split(' ');
                comboBox1.Items.Add(split[0]);
                today = today.AddDays(1);
            }

            // na około bo contains nie działa
            foreach ((Car, string) rent in bookedRentingList)
            {
                Car c = carFinding.SelectedCar;
                if (rent.Item1.Equals(c))
                {
                    comboBox1.Items.Remove(rent.Item2);
                }
            }
        }

        private void button_rentIt_Click(object sender, EventArgs e)
        {
            bookedRentingList.Add((carFinding.SelectedCar, (string)comboBox1.SelectedItem));
            bookedListToFile("booked-testing-rides.txt");
            MessageBox.Show("Car rented for day " + comboBox1.SelectedItem);
            this.Close();
        }

        private void bookedListToFile(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            foreach ((Car, string) rent in bookedRentingList)
            {
                sb.Append(rent.Item2 + ";" + rent.Item1.ToString());
            }
            File.WriteAllText(fileName, sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_rentIt.Enabled = true;
        }
    }
}
