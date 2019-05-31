using System;
using System.Collections.Generic;
using System.Text;

namespace FruitClass
{
    public class Fruit
    {
        // properties
        public static string _Name { set; get; }
        public static string _Season { set; get; }


        // constructor
        public Fruit(string Name, string Season)
        {
            _Name = Name;
            _Season = Season;
            Console.WriteLine("Magical Fruit has been obtained: {0} ", _Name);
            Console.WriteLine("You've recieved 100XP");

        }

        // method
        public void SepcialAbility()
        {
            Console.WriteLine("Choose the fruit's special ability.");
            Console.WriteLine("Health, Invisibility, Strength, Speed");
            string SAbility = Console.ReadLine().ToLower();

            switch (SAbility)
            {
                case "health":
                    Console.WriteLine("You have gained Health Points");
                    break;
                case "invidibility":
                    Console.WriteLine("You have gained the ability to be invisible.");
                    break;
                case "strength":
                    Console.WriteLine("You have leveled up in strength");
                    break;
                case "speed":
                    Console.WriteLine("Be fast. You gained fast points");
                    break;
               
                
            }
                
        }

    }

    // new class that inherits the Class Fruit
    public class MagicFruit : Fruit
    {
        // properties
        public static string _Color { set; get; }

        // constructor for the new class
        public MagicFruit (string Name, string Season, string Color) : base (Name, Season)
        {
            _Name = Name;
            _Season = Season;
            _Color = Color;
            Console.WriteLine("{0} is the color {1}", _Name, _Color);
        }

        // method
        public void  AcidityLevel(int ALevel)
        {
            for (int a = 0; a < ALevel; a++)
            {
                Console.WriteLine("Your fruit has leved up in acidityLevel.");
                
            }
            Console.WriteLine("This gives you a stronger fruit acidity");
        }
    }

}
