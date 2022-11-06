using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public abstract class Grain
    {
        public Grain()
        {
            Name = string.Empty;
        }

        public Grain(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
