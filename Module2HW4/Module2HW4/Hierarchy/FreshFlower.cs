using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class FreshFlower : Flower, ISmell
    {
        public FreshFlower(string name, float price, int height, ColorEnum color)
            : base(name, price, height, color)
        {
        }

        public string Operation()
        {
            return ToString();
        }

        public string Smell()
        {
            return "I smell like a " + Name.ToString();
        }

        public override string ToString()
        {
            return Name.ToString() + ", price: " + Price.ToString() + ", height: " + Height.ToString() + ", color: " + Color.ToString() + "\n";
        }
    }
}
