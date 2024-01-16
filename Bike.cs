using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes_JuanHernandez
{
    internal class Bike
    {
        // Fields
        string _brand;
        string _type;
        string _color;
        int _numberofwheels;

        // Properties
        public string Brand { get => _brand; set => _brand = value; }
        public string Type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public int Numberofwheels { get => _numberofwheels; set => _numberofwheels = value; }
    }
}
