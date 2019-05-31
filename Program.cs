using System;

namespace FruitClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string PName;

            Console.WriteLine("Hello Magicians of the World. Welcome to your online reality.");
            Console.WriteLine("What is your name?");
            PName = Console.ReadLine();
            

            Fruit Fruit1 = new Fruit("Cali", "Summer");
            Fruit1.SepcialAbility();

            MagicFruit Fruit2 = new MagicFruit("Super", "Spring", "blue");
            Fruit2.AcidityLevel(2);






        }
    }
}
