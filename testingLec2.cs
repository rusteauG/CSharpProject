//Lecture#2

 string myStr = 10.ToString();
 Console.WriteLine(myStr + myStr);
     
 //box
 int myInt = 42;
 object boxedObject = myInt;
 //unbox
 int unboxed = (int)boxedObject;
 
 Console.WriteLine( unboxed +1);

 string myFalseString = false.ToString();
 Console.WriteLine(myFalseString);
 Console.WriteLine(10+4-2);

//H/W #3
static void Main(string[] args)
{
    int row = 1;
    int col = 3;
    char n = ',';
    while (row <= 3)
    {
        col = 3;
        Console.Write($"{row}{n}");
        while (col >= 0)
        {
            if (col >=1)  //Or if( col != 0 )
            {
                Console.Write($"{col}{n}");
            }
            else
            {
                Console.Write($"{col}");
            }
            col--;
        }
        Console.WriteLine();
        
        row++;
        
    }
}

/*Ans : 1,3,2,1,0
		2,3,2,1,0
		3,3,2,1,0
	*/


//Ex#2
  Console.WriteLine("How many Names do you want to Enter: ");
  string input = Console.ReadLine();
  if (!int.TryParse(input, out int numberOfNames))
  {
      Console.WriteLine(input + " is Not a Number!");
      Console.ReadKey();
      return;
  }
  Console.WriteLine("Enter  Names: ");
  string[] names = new string[numberOfNames];
  int nameCounter = 0;
  while (nameCounter < numberOfNames)
  {
      Console.WriteLine("Enter  name " + nameCounter);
      names[nameCounter] = Console.ReadLine();
      nameCounter++;
  }
  //Display
  nameCounter = 0;

  while (nameCounter < numberOfNames)
  {
      string name = names[nameCounter];
      if (nameCounter < numberOfNames -1)
      {
          Console.Write(name + ",");
      }else
      {
          Console.Write(name);
      }
      nameCounter++;
  }

  Console.WriteLine();
  //Join back the array to a String
  string namesToString = String.Join(",", names);
  Console.WriteLine(namesToString);

  Console.WriteLine();


