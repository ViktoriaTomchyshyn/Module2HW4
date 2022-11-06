using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Module2HW4
{
    public class Bouquet
    {
        private static Bouquet _instance;
        private HerbalPlant[] _plants;

        public Bouquet()
        {
            _plants = null;
        }

        public HerbalPlant[] Plants
        {
            get { return _plants; }
            set { _plants = value; }
        }

        public static Bouquet GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Bouquet();
            }

            return _instance;
        }

        public Plant[] GetPlants()
        {
            return _plants;
        }

        public Plant GetPlant(int id)
        {
            return _plants[id - 1];
        }

        public HerbalPlant[] SortByPrice()
        {
            HerbalPlant temp;
            for (int j = 0; j <= _plants.Length - 2; j++)
            {
                for (int i = 0; i <= _plants.Length - 2; i++)
                {
                    if (_plants[i].CompareTo(_plants[i + 1]) > 0)
                    {
                        temp = _plants[i + 1];
                        _plants[i + 1] = _plants[i];
                        _plants[i] = temp;
                    }
                }
            }

            return _plants;
        }

        public override string ToString()
        {
            string result = "---Bouquet---\n";
            foreach (var item in _plants)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
