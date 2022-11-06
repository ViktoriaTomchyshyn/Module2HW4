using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class Flower : HerbalPlant
    {
        public Flower(string name, float price, int height, ColorEnum color)
            : base(name, price, height)
        {
            Color = color;
        }

        public ColorEnum Color { get; set; }
    }
}
