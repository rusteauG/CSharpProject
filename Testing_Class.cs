using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create two Person objects  with different states
            Person person1 = new Person { Name="Neville",Age=30};
            Person person2 = new Person { Name = "Laura" ,Age = 24 };
            person1.Greet();
            person2.Greet();

            double sum = MathHelper.Add(4, 5);
            Console.WriteLine($"Sum : {sum}");
            double areaCir = MathHelper.CalculateArea(sum);
            Console.WriteLine(areaCir.ToString("F2"));
            Console.WriteLine($"{areaCir,10:F2}"); // Right-align with 10 total spaces
            //OR
            string formattedArea = areaCir.ToString("F2").PadLeft(10); // Pad with 8 spaces to the left
            Console.WriteLine(formattedArea);


        }
    }
}


//class
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClasses
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello, my name is {0} and I'm {1} years old.", Name, Age);
        }
    }
    public static class MathHelper
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
