using System;
using System.Collections.Generic;
using System.Text;

namespace _1st_Overload_Exercises
{
    public class Maths
    {
        public int Plus(int x, int y)
        {
            return x + y;
        }

        public float Plus(float x, float y)
        {
            return x + y;
        }

        public string Plus(string x, string y)
        {
            var result = Int32.Parse(x) + Int32.Parse(y);
            string result_string = result.ToString();
            return result_string;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public float Minus(float x, float y)
        {
            return x - y;
        }

        public string Minus(string x, string y)
        {
            var result = Int32.Parse(x) - Int32.Parse(y);
            string result_string = result.ToString();
            return result_string;
        }

        public int Gange(int x, int y)
        {
            return x * y;
        }

        public float Gange(float x, float y)
        {
            return x * y;
        }

        public string Gange(string x, string y)
        {
            var result = Int32.Parse(x) * Int32.Parse(y);
            string result_string = result.ToString();
            return result_string;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public float Divide(float x, float y)
        {
            return x / y;
        }

        public string Divide(string x, string y)
        {
            var result = Int32.Parse(x) / Int32.Parse(y);
            string result_string = result.ToString();
            return result_string;
        }
    }
}
