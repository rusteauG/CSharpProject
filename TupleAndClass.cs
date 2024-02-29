//Tuple and Class retrun values More than one Values
using System.Globalization;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        static (double area, double perimeter) CalculateRectangle(double length, double width)
        {
            double area = length * width;
            double perimeter = 2 * (length + width);
            return (area, perimeter); // Tuple with calculated values
        }

        // Usage
        double rectArea, rectPerimeter;
        (rectArea, rectPerimeter) = CalculateRectangle(5, 3); // Destructuring assignment
        Console.WriteLine($"Area: {rectArea}, Perimeter: {rectPerimeter}");

        RectangleInfo rectInfo = RectangleInfo.Calculate(5, 3);
        Console.WriteLine($"Area: {rectInfo.Area}, Perimeter: {rectInfo.Perimeter}");

    }

    //Using a Class:
    class RectangleInfo
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public static RectangleInfo Calculate(double length, double width)
        {
            double area = length * width;
            double perimeter = 2 * (length + width);
            return new RectangleInfo { Area = area, Perimeter = perimeter }; // Instance with calculated values
        }



    }


}