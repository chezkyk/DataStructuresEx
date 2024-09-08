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
        // o(n)
        public static int CalculateOddSum(int[] array)
        {
            int sum = 0;// 2
            for (int i = 0; i < array.Length; i++)// 2 + (n+1) +n
            {   
                if (array[i] % 2 != 0)// 3* n
                {
                    //2 * n (worst case)
                    sum += array[i];
                }
            }
            return sum;// 1
        }

        //ex 2
        // O(n)
        public static int[] FindMaximumTwo(int[] array)
        {
            int[] towLargestInArray = new int[2];//2
            int sum = array[0] + array[1];// 3
            int max1 = array[0];// 2
            int max2 = array[1];// 2
  
            for (int i = 1; i < array.Length - 1; i++)// 2 + n +(n-1)
            {    
                if (array[i] + array[i + 1] > sum)// 4 *(n-1)
                {      
                    max1 = array[i]; // 2 * (n-1)
                    max2 = array[i + 1];// 3 * (n-1)
                    sum += max1 + max2;// 3 * (n-1)
                }
            }
            towLargestInArray[0] = max1;// 2
            towLargestInArray[1] = max2;// 2
            return towLargestInArray;// 1
        }

        // ex 3
        // O(n)
        public static bool ContainsNumber(int[] array, int number)
        {
                 
            for (int i = 0; i < array.Length; i++)// 2 + (n+1) +n
            {      
                if (array[i] == number)// 2* n
                {
                    return true;// 1
                }
            }
            return false;// 1
        }

        // ex 4
        // O(n)
        public static int[] SumOfAllTriplets(int[] array)
        {
            int[] helpArr = new int[3];// 2
            int first = array[0];// 2
            int second = array[1];// 2 
            int third = array[2];// 2
            int sum = first + second + third;// 4
            int temp = 0;// 2     
            for (int i = 1; i < array.Length - 2; i++)// 2 + (n-2) + (n-3)
            {
                temp = array[i] + array[i + 1] + array[i + 2];// 5*(n-3)

                if (temp > sum)// 1*(n-3)
                {
                    first = array[i];// 2*(n-3)                 
                    second = array[i + 1];// 3*(n-3) 
                    third = array[i + 2];// 3*(n-3) 
                    sum = first + second + third;// 4*(n-3) 
                }
            }
            helpArr[0] = first;//2
            helpArr[1] = second;//2
            helpArr[2] = third;//2

            return helpArr;//1
        }

        // ex 5
        // O(n)
        public static int[] FindLastClosePairWithProduct(int[] array, int product)
        {
            int[] productArr = new int[2];// 2
            int first = 0;// 2
            int second = 0;// 2
            int sumProduct = 0;// 2
            for (int i = 0; i < array.Length - 1; i++)// 2 + n + (n-1)
            {
                sumProduct = array[i] * array[i + 1];// 4 * (n-1)
                if (sumProduct == product)// 1 * (n-1)
                {
                    first = array[i];// 2 * (n-1)
                    second = array[i + 1];// 3 * (n-1)
                }
            }
            productArr[0] = first;//2 
            productArr[1] = second;// 2 
            return productArr;// 1
        }

        // ex 6
        // O(n)
        public static int CountEvenNumbers(int[] array)
        {
            int count = 0;// 2
            for (int i = 0; i < array.Length; i++)// 2 + n+1 + n
            {
                if (array[i] % 2 == 0)//3 * n
                {
                    count++;//1 * n
                }
            }
            return count;// 1
        }

        // ex 7
        //public static int[] MergeSortedArraysUnique(int[] array1, int[] array2)
        //{
            
        //}
    }
}
