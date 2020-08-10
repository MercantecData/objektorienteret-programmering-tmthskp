using System;


namespace Delegates_opg1
{
    class Program
    {
        // A delegate string arguement
        public delegate void Del(string message);
        public delegate void Del1();

        // A string method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void test()
        {
            Console.WriteLine("tester");
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


        // 3 methods to be wrapped by del instances
        public class MethodClass
        {
            public void Method1(string message) { }
            public void Method2(string message) { }
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;
            Del1 handler1 = test;

            // Call the delegate.
            handler("A Delegate String");
            handler("Ill test yah");
            handler1();

            // Int With parametres console call
            MethodWithCallback(1, 2, 3, handler);

            // Int With parametres console call
            MethodWithCallback1(2f, 3f, handler);

            //Multicasting more than one message invwoked
            var obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            //Both types of assignment are valid.
            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;
        }
    }
}
