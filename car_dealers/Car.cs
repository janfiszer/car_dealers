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
        private int id;
        private string brand;
        private string model;
        private Engine engine;
        private Color color;
    }
}
