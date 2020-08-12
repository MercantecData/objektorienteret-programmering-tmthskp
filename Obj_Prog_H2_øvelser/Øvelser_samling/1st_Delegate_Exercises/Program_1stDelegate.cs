using System;
using System.Collections.Generic;
using System.Linq;

namespace _1st_Delegate_Exercises
{
    class Program_1stDelegate
    {
       
        
        // A delegate void
        public delegate void DelVoid();
        public delegate void DelFloat();

        public static void test_string()
        {
            Console.WriteLine("tester");
        }

        public static void test_float()
        {
            Console.WriteLine(99f);
        }

        // Int with parametres
        public static void MethodWithCallback(int param1, int param2, int param3, Del callback)
        {
            callback("The number is: " + (param1 + param2 + param3).ToString());
        }

        public static void MethodWithCallback1(float param4, float param5, Del callback)
        {
            callback("The number is: " + (param4 + param5).ToString());
        }


        // A delegate string 
        public delegate void Del(string message);
        // A string method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        public static void DelegateMethod(float FloatNumber)
        {
            Console.WriteLine(FloatNumber);
        }

       

       


        // 3 methods to be wrapped by del instances
        public class MethodClass
        {
            public void Method1(string message) { }
            public void Method2(string message) { }
        }

        static void Main(string[] args)
        {
            //Delegate Handlers.
            DelVoid handler1 = test_string;
            DelVoid handler2 = test_float;
            Del handler = DelegateMethod;

            

            // Call the delegate.
            handler1();
            handler2();
            
            // Int With parametres console call
            MethodWithCallback(1, 2, 3, handler);
            
            // Int With parametres console call
            MethodWithCallback1(2f, 3f, handler);

           
            
            handler("A Delegate String");
            handler("Ill test yah");
            
            //Multicasting more than one message invwoked
            var obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            //Both types of assignment are valid.
            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            // -----------------------------------------------------------------
            //Some Lambda expresion tests
            Console.WriteLine("Here is some lambda exercises");
            Func<int, int> doubleUp = x => x + x;
            Console.WriteLine(doubleUp(5));

            float[] array1 = { 1f, 3f, 5f};
            float sum1 = array1.Sum();
            Console.WriteLine(sum1);

            var numbers = new float[] { 3f, 5f, 1f };
            var result1 = numbers.Sum(x => 3f + 5f + 1f);
            //var result1 = numbers.Sum(x => x == 3f ? 10f : 1f);
            //var result2 = numbers.Sum(x => x == 5f ? 10f : 1f);
            // var result3 = numbers.Sum(x => x == 1f ? 10f : 1f);
            Console.WriteLine(result1);
            //Console.WriteLine(result2);
           // Console.WriteLine(result3);

           

        }




    }
    
}
