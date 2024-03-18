//jageed Array

    //var arr = new JaggedArray();
    int[][] jaggedArray = new int[4][];
    jaggedArray[0] = new int[3] { 1, 2, 3 };
    jaggedArray[1] = new int[4] { 1, 2, 3, 4 };
    jaggedArray[2] = new int[5] { 1, 2, 3, 4, 5 };
    jaggedArray[3] = new int[6] { 1, 2, 3, 4, 5, 6 };

    //4   Console.WriteLine(jaggedArray.Length);

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            jaggedArray[i][j] = j;
            Console.Write(j+" ");
        }
        Console.WriteLine();
    }




        int[,] a = new int[,] {
{ 1, 2, 3 },
{ 4, 5, 6 },
{ 7, 8, 9 }};

    int rows = a.GetLength(0); // rows = 3
    int cols = a.GetLength(1); // cols = 3

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }




    //// Declare a jagged array
    //int[][] jaggedArray;

    //// Get the number of rows and columns from the user
    //Console.Write("Enter the number of rows: ");
    //int row = int.Parse(Console.ReadLine());
    //int col = 0;
    //// Initialize the jagged array
    //jaggedArray = new int[row][];

    //// Initialize each row with the specified number of columns
    //for (int i = 0; i < row; i++)
    //{

    //    Console.Write("Enter the number of columns for Row:{0} - ",i);
    //    col = int.Parse(Console.ReadLine());

    //    jaggedArray[i] = new int[col];
    //}

    ////// Now you can access and modify the elements of the jagged array
    ////for (int i = 0; i < row; i++)
    ////{
    ////    for (int j = 0; j < col; j++)
    ////    {
    ////        jaggedArray[i][j] = i * col + j + 1; // Example value assignment
    ////    }
    ////    Console.WriteLine();
    ////}

    //// Print the jagged array
    //for (int i = 0; i < row; i++)
    //{
    //    for (int j = 0; j < jaggedArray[i].Length; j++)
    //    {
    //        Console.Write(jaggedArray[i][j] + " ");
    //    }
    //    Console.WriteLine();
    //}