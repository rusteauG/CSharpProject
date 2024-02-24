List<string> familyList = new List<string>();
string familyName;

do
{

    Console.Write("Enter Family Name: ");
    familyName = Console.ReadLine();
    if (String.IsNullOrEmpty(familyName))
    {
        Console.WriteLine("The input string is empty or null.");
        continue;
    }
    else
    {
        familyList.Add(familyName);
        Console.Clear();
    }
} while (familyName.ToLower() !="!");
Console.WriteLine("Family Members: ");
foreach (var item in familyList)
{
    Console.Write($"{item} , ");
}
Console.WriteLine($"Count: {familyList.Count -1}");

for (int i = 0; i < familyList.Count-1; i++)
{
    Console.Write(familyList[i]);
    if (i != familyList.Count )
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

string output = string.Join(", ", familyList);
Console.Write(output);