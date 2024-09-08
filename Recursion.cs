using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresEx
{
    internal class Recursion
    {
        //ex 1
        public static int Multiply(int a, int b)
        {
            if (a == 0)
            {
                return a;
            }
            return b + Multiply(a - 1, b);
        }

        //ex 2
        public static int SumOfDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return n % 10 + SumOfDigits(n / 10);
        }

        //ex 3
        public static int Power(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a * Power(a, b - 1);
        }

        //ex 4
        public static string Reversed(int n)
        {
            if (n < 10)
            {
                return n.ToString();
            }
            return (n % 10).ToString() + Reversed(n / 10);
        }

        //ex 5
        public static int FindSum(int[] n, int len)
        {
            if (len == 0)
            {
                return len;
            }
            return n[len - 1] + FindSum(n, len - 1);
        }

        // ex 6 
        public static float Divide(float a, float b)
        {

            if (a < b)
            {
                return 0;
            }
            return 1 + Divide(a - b, b);
        }

        //ex 7
        //public static bool IsPalindrome(string str)
        //{
            
        //}
    }
}

