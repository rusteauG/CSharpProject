//Arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"How Many Emp you want to Register:  ");
            int len = int.Parse(Console.ReadLine());
            int[] empId = new int[len];
            ArrayEnter(empId);
            DisplayArray(empId);
            CopyArray(empId);
            Console.Write("Find a Number in the Array:\n Enter: ");
            SearchInArray(empId, int.Parse(Console.ReadLine()));
            Console.Write("Find a Number(s) in the Array:\n Enter: ");
            SearchAllArray(empId,int.Parse(Console.ReadLine()));
            ArraySort(empId); //SOrt in place
            Array.Reverse(empId);
            DisplayArray(empId );
            
        }

        public static void ArraySort(int[] arr)
        {
            Array.Sort(arr);

            Console.WriteLine("Sorted array (ascending):");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


        public static void SearchInArray(int[] arr, int searchValue)
        {
            int firstIndex = Array.IndexOf(arr, searchValue);

            if (firstIndex >= 0)
            {
                Console.WriteLine($"The first index of {searchValue} is: {firstIndex}");
            }
            else
            {
                Console.WriteLine($"{searchValue} not found in the array.");
            }

        }

        public static void SearchAllArray(int[] arr, int searchValue)
        {

            List<int> allIndices = new List<int>(); // Store all indices of the value
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchValue)
                {
                    allIndices.Add(i);

                }

            }
            if (allIndices.Count > 0)
            {
                Console.WriteLine("{0} Occurence Found:",allIndices.Count);
                Console.Write("The value {0} was found at indices: ", searchValue);
                foreach (int index in allIndices)
                {
                    Console.Write(index+1 + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{searchValue} not found in the array.");
            }

        }


        public static void CopyArray(int[] arr)
        {
            int[] copiedNumbers = new int[arr.Length]; // Create a destination array with the same size
            Array.Copy(arr, 0, copiedNumbers, 0, arr.Length);


            Console.WriteLine("Original Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nCopied Array:");
            foreach (int num in copiedNumbers)
            {
                Console.Write(num + " ");
            }


        }


        public static void ArrayEnter(int[] empId)
        {

            for (int i = 0; i < empId.Length; i++)
            {
                Console.Write($"Enter ID {i + 1}: ");
                empId[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void DisplayArray(int[] empId)
        {
            for (int i = 0; i < empId.Length; i++)
            {
                Console.Write($"{i + 1}: {empId[i]}\n");
            }
        }

    }
}