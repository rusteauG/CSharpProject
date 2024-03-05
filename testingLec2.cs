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