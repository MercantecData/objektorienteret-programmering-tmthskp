using System;
using System.Collections.Generic;
using System.Text;

namespace Gæt_et_tal_spil
{
    public class NumberGuessClass
    {
        public void Guess_a_number()
        {
            //randomizer number start
            Random random = new Random(); //number randomizer
            while (true)
            {
                int randomNumber = random.Next(1, 10); // randomly  picks a number between chosen range (1, 6)
                int counter = 1;
                bool retry = true; // declares variables to store the Boolean values: true and false varibel true run while loop
                while (true)
                {
                    Console.Write("Gæt et tal imellem 1 and 10: ");
                    int input = Convert.ToInt32(Console.ReadLine()); // convert input to a 32 bit int

                    if (input < randomNumber) // lower than varibel 
                    {
                        Console.WriteLine("For lav, prøv igen. ");
                        counter++; // increment the value of a variable before using it
                        continue; // continue forces the next state of while loop
                    }

                    else if (input > randomNumber) // higher than varibel
                    {
                        Console.WriteLine("For høj, prøv igen. ");
                        counter++;
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Tillykke. godt gættet!");
                        Console.WriteLine("vil du prøve igen? j/n");
                        string answer = Console.ReadLine();
                        if (answer != "j") // if anwers not equal to j 
                        {
                            retry = false; // statement false 
                        }
                        break; // forces state to stop
                    }

                }
                if (!retry) break; // if retry false end program. !retry = not true


            }//randomizer number stop
        }
    }
}

