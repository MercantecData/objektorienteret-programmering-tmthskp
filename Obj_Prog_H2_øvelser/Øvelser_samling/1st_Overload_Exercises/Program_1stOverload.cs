using System;

namespace _1st_Overload_Exercises
{
    class Program_1stOverload
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();

            int my_numbers_1 = maths.Plus(10, 5);
            float my_numbers_2 = maths.Plus(20, 15);
            string my_numbers_21 = maths.Plus("20", "15");
            Console.WriteLine("Int plus: " + my_numbers_1);
            Console.WriteLine("Float plus: " + my_numbers_2);
            Console.WriteLine("String plus: " + my_numbers_21);

            int my_numbers_3 = maths.Minus(10, 5);
            float my_numbers_4 = maths.Minus(20, 15);
            string my_numbers_22 = maths.Minus("20", "15");
            Console.WriteLine("Int minus: " + my_numbers_3);
            Console.WriteLine("Float minus: " + my_numbers_4);
            Console.WriteLine("String minus: " + my_numbers_22);

            int my_numbers_5 = maths.Gange(10, 5);
            float my_numbers_6 = maths.Gange(20, 15);
            string my_numbers_23 = maths.Gange("20", "15");
            Console.WriteLine("Int gange: " + my_numbers_5);
            Console.WriteLine("Float gange: " + my_numbers_6);
            Console.WriteLine("String gange: " + my_numbers_23);

            int my_numbers_7 = maths.Divide(10, 5);
            float my_numbers_8 = maths.Divide(20, 15);
            string my_numbers_24 = maths.Divide("20", "15");
            Console.WriteLine("Int divider: " + my_numbers_7);
            Console.WriteLine("Float divider: " + my_numbers_8);
            Console.WriteLine("String divider: " + my_numbers_24);
        }
    }
}
