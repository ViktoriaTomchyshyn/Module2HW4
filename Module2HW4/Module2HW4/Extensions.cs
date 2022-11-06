using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public static class Extensions
    {
        public static HerbalPlant[] FindHerbalPlantsWithLowerPrice(this Bouquet bouquet)
        {
            int quantity = 0;
            foreach (var item in bouquet.Plants)
            {
                if (item.Price < bouquet.Plants.GetAveragePrice())
                {
                    quantity++;
                }
            }

            HerbalPlant[] result = new HerbalPlant[quantity];

            int k = 0;

            foreach (var item in bouquet.Plants)
            {
                if (item.Price < bouquet.Plants.GetAveragePrice())
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static HerbalPlant[] GetByName(this Bouquet bouquet, string name)
        {
            int quantity = 0;
            foreach (var item in bouquet.Plants)
            {
                if (item.Name.CompareTo(name) == 0)
                {
                    quantity++;
                }
            }

            HerbalPlant[] result = new HerbalPlant[quantity];

            int k = 0;

            foreach (var item in bouquet.Plants)
            {
                if (item.Name.CompareTo(name) == 0)
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static string FormatHerbalPlantsArray(this HerbalPlant[] plants)
        {
            string result = string.Empty;
            foreach (var item in plants)
            {
                result += item.ToString();
            }

            return result;
        }

        public static double GetAveragePrice(this HerbalPlant[] plants)
        {
            float sum = 0;
            foreach (var p in plants)
            {
                sum += p.Price;
            }

            return Math.Round(sum / plants.Length, 2);
        }

        public static double GetTotalPrice(this HerbalPlant[] plants)
        {
            float sum = 0;
            foreach (var p in plants)
            {
                sum += p.Price;
            }

            return sum;
        }
    }
}
