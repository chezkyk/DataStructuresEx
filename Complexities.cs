using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresEx
{
    public class Complexities
    {
        //ex 1
        public static int CalculateOddSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        //ex 2
        public static int[] FindMaximumTwo(int[] array)
        {
            int[] towLargestInArray = new int[2];
            int sum = array[0] + array[1];
            int max1 = array[0];
            int max2 = array[1];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] + array[i + 1] > sum)
                {
                    max1 = array[i];
                    max2 = array[i + 1];
                    sum += max1 + max2;
                }
            }
            towLargestInArray[0] = max1;
            towLargestInArray[1] = max2;
            return towLargestInArray;
        }

        // ex 3
        public static bool ContainsNumber(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        // ex 4
        public static int[] SumOfAllTriplets(int[] array)
        {
            int[] helpArr = new int[3];
            int first = array[0];
            int second = array[1];
            int third = array[2];
            int sum = first + second + third;
            int temp = 0;
            for (int i = 1; i < array.Length - 2; i++)
            {
                temp = array[i] + array[i + 1] + array[i + 2];
                if (temp > sum)
                {
                    first = array[i];
                    second = array[i + 1];
                    third = array[i + 2];
                    sum = first + second + third;
                }
            }
            helpArr[0] = first;
            helpArr[1] = second;
            helpArr[2] = third;
            return helpArr;
        }

        // ex 5
        public static int[] FindLastClosePairWithProduct(int[] array, int product)
        {
            int[] productArr = new int[2];
            int first = 0;
            int second = 0;
            int sumProduct = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sumProduct = array[i] * array[i + 1];
                if (sumProduct == product)
                {
                    first = array[i];
                    second = array[i + 1];
                }
            }
            productArr[0] = first;
            productArr[1] = second;
            return productArr;
        }

        // ex 6
        public static int CountEvenNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        // ex 7
        public static int[] MergeSortedArraysUnique(int[] array1, int[] array2)
        {
            
        }
    }
}
