//ref

    internal class Program
    {
        static void Main(string[] args)
        {
            int localValue = 5;
            calculate(ref localValue);
            Console.WriteLine(localValue);

            // Converting a string to a specific culture's double format
            string moneyString = "$1,234.56";


            decimal moneyValue = decimal.Parse(moneyString, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));

            Console.WriteLine(moneyValue.ToString());
            Console.WriteLine();
        }
        public static void calculate( ref int localValue)
        {
            localValue *= 100;
        }

    }
}