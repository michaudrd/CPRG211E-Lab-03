namespace CPRG211E_Lab_03_Part_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dog name: ");
            string dogName = Console.ReadLine();
            Dog dog1 = new Dog();
            dog1.Name = dogName;
            Console.Write("Enter dog height: ");
            dog1.Height = double.Parse(Console.ReadLine());
            Console.Write("Enter dog colour: ");
            dog1.Colour = Console.ReadLine();
            Console.Write("Enter dog age: ");
            dog1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {dog1.Name}");
            Console.WriteLine($"Colour: {dog1.Colour}");
            Console.WriteLine($"Height: {dog1.Height}");
            Console.WriteLine($"Age: {dog1.Age}");

            dog1.Eat();
            Console.WriteLine(dog1.Cry());


            Console.Write("Enter cat name: ");
            string catName = Console.ReadLine();
            Cat cat1 = new Cat();
            cat1.Name = catName;
            Console.Write("Enter cat height: ");
            cat1.Height = double.Parse(Console.ReadLine());
            Console.Write("Enter cat colour: ");
            cat1.Colour = Console.ReadLine();
            Console.Write("Enter cat age: ");
            cat1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {cat1.Name}");
            Console.WriteLine($"Colour: {cat1.Colour}");
            Console.WriteLine($"Height: {cat1.Height}");
            Console.WriteLine($"Age: {cat1.Age}");

            cat1.Eat();
            Console.WriteLine(cat1.Cry());

            List<IAnimal> animals = new List<IAnimal>
            {
            dog1,
            cat1,
            new Dog("Brownie", "Brown", 2.0, 14),
            new Cat("Rufus", "Black and White", 2.0, 17),
            new Cat("Sooty", "Black", 2.5, 4),
            };


            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
