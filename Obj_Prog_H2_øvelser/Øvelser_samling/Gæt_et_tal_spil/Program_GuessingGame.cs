using System;
using System.Threading.Tasks;


namespace Gæt_et_tal_spil
{
    class Program_GuessingGame
    {
        static void Main(string[] args)
        {
            NumberGuessClass numberGuessClass = new NumberGuessClass();

            var task = Timer.CreateWriteTimer(1, 10, "\nHurtiger! Tiden går");
             
            numberGuessClass.Guess_a_number();



        }

       

    }
}
