using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

           
             var myBird = new Bird();
            myBird.IsLarge = true;
            myBird.Migrate = true;
            myBird.WingColor = "Red";
            myBird.LandSeaAir = "Air";
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Snake = new Reptile();
            Snake.CanFly = false;
            Snake.NumLegs = 0;
            Snake.Habitat = "Warm";
            Snake.IsColdBlooded = true;
            Snake.HasScales = true;

            var myAnimals = new Animal[] { myBird, Snake };


            int i = 0;
            do
            {
                Console.WriteLine($"This bird can fly :{myBird.CanFly}");
                Console.WriteLine($"My birds wing color is: {myBird.WingColor}");
                Console.WriteLine($"my repile has legs: {Snake.NumLegs}");
                Console.WriteLine($"my snake can fly: {Snake.CanFly}");
                Console.WriteLine($"my snakes favorite habitat is {Snake.Habitat}");
                i++;

            } while (i < 1);
        }
    }
}

