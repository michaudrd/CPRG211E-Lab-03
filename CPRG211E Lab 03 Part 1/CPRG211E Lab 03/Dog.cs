using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_03_Part_1
{
    public class Dog : Animal
    {
        public Dog()
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
