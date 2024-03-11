//decimal or whole number

public static void Main(string[] args)
{
    double intValue = 123.456;
    Console.WriteLine(Math.Floor(intValue));  //10
    int numberOfDigits = intValue.ToString().Length;

    Console.WriteLine($"Number of digits in {intValue}: {numberOfDigits}");

    decimal decimalValue = 123.456m;
    numberOfDigits = (int)Math.Floor(Math.Log10((double)Math.Abs(decimalValue))) + 1;

    Console.WriteLine($"Number of digits in {decimalValue}: {numberOfDigits}");  // Output: 6

    double originalNumber = 123.456;

    // Extract the whole number part
    int wholeNumberPart = (int)originalNumber;

    // Extract the decimal part
    double decimalPart = originalNumber - wholeNumberPart;

    Console.WriteLine($"Original Number: {originalNumber}");
    Console.WriteLine($"Whole Number Part: {wholeNumberPart}");
    Console.WriteLine($"Decimal Part: {decimalPart}");


    //Explicit
    double d = 123.456;
    int a = (int)d;
    d = d - a;

    Console.WriteLine("Explicit Coonversion: " + a);
    Console.WriteLine(d);
    //f you want to remove the decimal part from any double number and convert it to an integer, 
    originalNumber = 123.4503;

    // Convert to integer by multiplying with a power of 10
    int resultInteger = (int)(originalNumber * Math.Pow(10, Math.Floor(Math.Log10(originalNumber) + 1)));

    Console.WriteLine($"Original Number: {originalNumber}");
    Console.WriteLine($"Result Integer: {resultInteger}");


    double number = 123.45;

    // Check if the number is a decimal or whole number
    bool isDecimal = number % 1 != 0;

    if (isDecimal)
    {
        Console.WriteLine($"{number} is a decimal number.");
    }
    else
    {
        Console.WriteLine($"{number} is a whole number.");
    }



    //eXPLICIT Typing
    var num = 12.456m;
    Console.WriteLine(num.GetType());  //System.Decimal
    var num1 =  new object();
    Console.WriteLine(num1.GetHashCode());
    Console.WriteLine();

