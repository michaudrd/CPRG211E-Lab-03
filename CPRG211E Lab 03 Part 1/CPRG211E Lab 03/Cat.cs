using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_03_Part_1
{
    public class Cat : Animal
    {
        public Cat()
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
