//reverse
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("How many Inputs Required: ");
            //int num = int.Parse(Console.ReadLine());
            //ArrayClass.DisplayArr(num);

            //print an array in rev order
            int[] ints = new int[] { 34, 56, 54, 32, 67, 89, 90, 32, 21 };
            ints.Reverse();
            Console.WriteLine(string.Join(", ", ints)); // Output:  4, 3, 2, 1

            foreach (int i in ints)
            {
                Console.Write($"{i,-4:0}"); // Corrected formatting string

            }
            Console.WriteLine();
            // reverse the elements for display or other purposes without modifying the original ints
            //Create a new reversed array:
            //create a new array to hold  the rev elements
            int[] reversedInt = new int[ints.Length];
            // Copy elements from the original array in reverse order
            for (int i = ints.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedInt[j] = ints[i];
            }

            Console.Write("RevArray COPY: ");
            foreach (int i in reversedInt)
            {

                Console.Write($"{i,-4:0}"); // Corrected formatting string
            }
            Console.WriteLine();
            //Now REV the Array
            // Array.Reverse(ints) also modifies 'ints' in place
            Array.Reverse(reversedInt); //OR reversedInt.Reverse()  Same in place reverse Original array is rev 
            Console.Write("RevArray: ");
            Console.WriteLine(string.Join(", ", reversedInt)); // Output:

            //Sort
            Array.Sort(reversedInt);
            Console.WriteLine("Sorting:---");
            foreach (int i in reversedInt)
            {
                Console.Write($"{i,-4:0}"); // Corrected formatting string
            }




            Console.WriteLine();
        }

    }
}



//ArrayClass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("How many Inputs Required: ");
            //int num = int.Parse(Console.ReadLine());
            //ArrayClass.DisplayArr(num);

            //print an array in rev order
            int[] ints = new int[] { 34, 56, 54, 32, 67, 89, 90, 32, 21 };
            ints.Reverse();
            Console.WriteLine(string.Join(", ", ints)); // Output:  4, 3, 2, 1

            foreach (int i in ints)
            {
                Console.Write($"{i,-4:0}"); // Corrected formatting string

            }
            Console.WriteLine();
            // reverse the elements for display or other purposes without modifying the original ints
            //Create a new reversed array:
            //create a new array to hold  the rev elements
            int[] reversedInt = new int[ints.Length];
            // Copy elements from the original array in reverse order
            for (int i = ints.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedInt[j] = ints[i];
            }

            Console.Write("RevArray COPY: ");
            foreach (int i in reversedInt)
            {

                Console.Write($"{i,-4:0}"); // Corrected formatting string
            }
            Console.WriteLine();
            //Now REV the Array
            // Array.Reverse(ints) also modifies 'ints' in place
            Array.Reverse(reversedInt); //OR reversedInt.Reverse()  Same in place reverse Original array is rev 
            Console.Write("RevArray: ");
            Console.WriteLine(string.Join(", ", reversedInt)); // Output:

            //Sort
            Array.Sort(reversedInt);
            Console.WriteLine("Sorting:---");
            foreach (int i in reversedInt)
            {
                Console.Write($"{i,-4:0}"); // Corrected formatting string
            }




            Console.WriteLine();
        }

    }
}


