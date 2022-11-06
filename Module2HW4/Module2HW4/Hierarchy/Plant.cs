using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class Plant : Grain, IComparable<Plant>
    {
        public Plant()
            : base()
        {
            Price = 0;
        }

        public Plant(string name, float price)
            : base(name)
        {
            Price = price;
        }

        public float Price { get; set; }

        public int CompareTo(Plant other)
        {
            if (other == null)
            {
                return 1;
            }

            return Price.CompareTo(other.Price);
        }
    }
}
