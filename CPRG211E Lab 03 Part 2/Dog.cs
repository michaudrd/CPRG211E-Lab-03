using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_03_Part_2
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }

        public Dog()
        {

        }
        public Dog(string name, string colour, double height, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }
    }
}
