using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealers
{
    public enum Engine
    {
        HYBRID,
        ELECTRICAL,
        DIESEL,
        PETROL
    }
    public class Car
    {
        private string brand;
        private string model;
        private Engine engine;
        private string color;
        private string imagePath;

        public Car(string brand, string model, Engine engine, string color, string imagePath)
        {
            this.brand = brand;
            this.model = model;
            this.engine = engine;
            this.color = color;
            this.imagePath = imagePath;
        }

        public override string ToString()
        {
            return brand + ";" + model + ";" + engine.ToString() + ";" + color.ToString() + ";" + imagePath + "\n";
        }
    }
}
