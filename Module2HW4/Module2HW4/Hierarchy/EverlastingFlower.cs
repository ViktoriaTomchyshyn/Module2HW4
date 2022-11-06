using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class EverlastingFlower : Flower
    {
        public EverlastingFlower(string name, float price, int height, ColorEnum color)
            : base(name, price, height, color)
        {
        }

        public string Operation()
        {
            return ToString();
        }

        public override string ToString()
        {
            return Name.ToString() + ", price: " + Price.ToString() + ", height: " + Height.ToString() + ", color: " + Color.ToString() + "\n";
        }

        public new string Grow()
        {
            return "I cannot grow. My current height is " + Height + "\n";
        }

        public new string Fade()
        {
            return "I cannot fade again, I`m everlasting flower";
        }
    }
}
