using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_03_Part_1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public abstract void Eat();

        public Animal()
        {

        }
    }
}
