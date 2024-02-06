namespace CPRG211E_Lab_03_Part_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dog name: ");
            string dogName = Console.ReadLine();
            Dog dog1 = new Dog();
            dog1.Name = dogName;
            dog1.Colour = "White";
            dog1.Age = 14;

            Console.WriteLine($"Name: {dog1.Name}");
            Console.WriteLine($"Colour: {dog1.Colour}");
            Console.WriteLine($"Age: {dog1.Age}");
            dog1.Eat();

            Console.Write("Enter cat name: ");
            string catName = Console.ReadLine();
            Cat cat1 = new Cat();
            cat1.Name = catName;
            cat1.Colour = "Black";
            cat1.Age = 4;
            Console.WriteLine($"Name: {cat1.Name}");
            Console.WriteLine($"Colour: {cat1.Colour}");
            Console.WriteLine($"Age: {cat1.Age}");
            cat1.Eat();
        }
    }
}
