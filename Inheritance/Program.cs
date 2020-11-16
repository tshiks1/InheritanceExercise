using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var tweety = new Bird() { CanFly = true, HasWings = true, LaysEggs = true, Legs = 2, LivesOnLand = false, Weight = 2 };
            
            var lizard = new Reptile()
            {
                LivesOnLand = true,
                LegsCount = 4,
                CanFly = false,
                CanGrowTail = true,
                IsColdBlooded = true,
                IsScaly = true,
                Weight = 3

            };
           ///Console.WriteLine($"{tweety} is a yellow bird ,that  has {tweety.HasWings} & {tweety.LaysEggs} often\n" +
                //$"but only weighs {tweety.Weight} lbs");


             var myAnimal = new Animal[]{tweety, lizard};
             foreach( var animal in myAnimal)
            {
                Console.Write($" Can Fly:{animal.CanFly}");
                Console.Write($" Lives on land:{animal.LivesOnLand}");
                Console.Write($" Weighs {animal.Weight} lbs");
                Console.Write($"\n");
 }
            
            
            
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
