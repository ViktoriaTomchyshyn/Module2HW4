using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class HerbalPlant : Plant, IGrow, IFade
    {
        public HerbalPlant(string name, float price, int height)
            : base(name, price)
        {
            Height = height;
        }

        public int Height { get; set; }

        public string Fade()
        {
            return "I`m fading";
        }

        public string Grow()
        {
            Height++;
            return "My new height is " + Height.ToString() + "\n";
        }
    }
}
