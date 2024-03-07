//Exception , catching thrown exception
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                BadCode();
            }
            catch (Exception EX)
            {

                Console.WriteLine($"2.Caught the thrown Exception Here{EX.Message}");
            }
            Console.ReadLine();
        }

        private static void BadCode() {
            int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {

                    Console.WriteLine(ages[i]);

                }
                catch (Exception ex)
                {

                    // Check if the exception is specifically an IndexOutOfRangeException
                    if (ex is IndexOutOfRangeException)
                    {
                        Console.WriteLine("1.An unexpected exception occurred: {0}", ex.Message);
                        //Better to throw new exception to catch the excat info
                        throw new Exception("::(thrown)There was a prob with the Array",ex);
                    }

                }

            }

        }
    }

}
