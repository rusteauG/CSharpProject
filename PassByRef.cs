internal class Program
{
    private static void Main(string[] args)
    {
        int i =0;
        Console.WriteLine(i);
        PassByRef(ref i);
        Console.WriteLine(i);
    }
    public static void PassByRef(ref int value)
    {
        value++;
        Console.WriteLine(value);
    }

}