using System;

namespace Nedarving_eksempler
{
    class Meal  // parent class 
    {
        public string type = "Pizza";  // Meal field
        public void yummy()             // Meal method 
        {
            Console.WriteLine("Nam, nam!");
        }
    }

    class Dinner : Meal  // child class
    {
        public string typePizza = "Kebab";  // Dinner field
    }


    class Bird  // parent class 
    {
        public virtual void birdSound()
        {
            Console.WriteLine("Fuglen laver en lyd");
        }
    }

    class Blackbird : Bird  // child class) 
    {
        public override void birdSound()
        {
            Console.WriteLine("Solsorten fløjter en smuk lyd");
        }
    }

    class Seagul : Bird  // child class 
    {
        public override void birdSound()
        {
            Console.WriteLine("Havmågen siger nogle mega trælse lyde");
        }
    }

   
    
    class Program_nedarving
    {
        static void Main(string[] args)
        {
            // Create a myDinner object
            Dinner myDinner = new Dinner();

            // Call the yummy() method (From the Meal class) on the myDinner object
            myDinner.yummy();

            // Display the value of the type field (from the Meal class) and the value of the typePizza from the Meal class
            Console.WriteLine(myDinner.type + " " + myDinner.typePizza);

            //overeride example
            Bird myBird = new Bird();  // Create a Bird object
            Bird myBlackbird = new Blackbird();  // Create a Blackbird object
            Bird mySeagul = new Seagul();  // Create a Seagul object

            myBird.birdSound();
            myBlackbird.birdSound();
            mySeagul.birdSound();

        }
    }
}
