using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class Grass : HerbalPlant
    {
        public Grass(string name, float price, int height, bool hasLeaves)
            : base(name, price, height)
        {
            HasLeaves = hasLeaves;
        }

        public bool HasLeaves { get; set; }

        public override string ToString()
        {
            if (HasLeaves)
            {
                return Name.ToString() + ", price: " + Price.ToString() + ", height: " + Height.ToString() + ", has leaves\n";
            }
            else
            {
                return Name.ToString() + ", price: " + Price.ToString() + ", height: " + Height.ToString() + ", doesn`t have leaves\n";
            }
        }
    }
}
