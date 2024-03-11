//Rounding to nearest 100 , Shifting number around

        double originalNumber = 2612; // Replace with your actual number

        //Shifting number around make 2612 > 2600.12
        double roundedNumber = Math.Round(originalNumber / 100) * 100;
        
        double newNumber= roundedNumber+ (originalNumber - roundedNumber)/100;
        Console.WriteLine("Original number: {0}", originalNumber);
        Console.WriteLine("Rounded to nearest 1000: {0}", roundedNumber);

        Console.WriteLine();
        Console.WriteLine(newNumber);
        // a more explicit check for rounding direction, you can use an if statement:
        originalNumber = 2612; // Replace with your actual number
        double halfThousand = 500;

       
        double distanceToNextThousand = Math.Abs(originalNumber % 1000);

        if (distanceToNextThousand <= halfThousand)
        {
            roundedNumber = Math.Floor(originalNumber / 1000) * 1000;  // Round down if closer to current thousand
        }
        else
        {
            roundedNumber = Math.Ceiling(originalNumber / 1000) * 1000;  // Round up if closer to next thousand
        }

        Console.WriteLine("Original number: {0}", originalNumber);
        Console.WriteLine("Rounded to nearest 1000: {0}", roundedNumber);
    



    //double originalNumber = 2612.34; // Replace with your actual number
    //double baseValue = originalNumber / 1000;
    //Console.WriteLine(baseValue);
    //// Get the remainder after dividing by 1000 (absolute value ensures positive)
    //double remainder = Math.Abs(originalNumber % 1000);

    //// Check if the remainder is closer to 0 or 1000
    //double roundedNumber;
    //if (remainder <= 500)
    //{
    //    roundedNumber = baseValue * 1000;  // Round down if closer to 0
    //}
    //else
    //{
    //    roundedNumber = (baseValue + 1) * 1000;  // Round up if closer to 1000
    //}

    //Console.WriteLine("Original number: {0}", originalNumber);
    //Console.WriteLine("Rounded to nearest 1000: {0}", roundedNumber);



    //test

    //double wholePart = Math.Floor(originalNumber); // Get integer part
    //double decimalPart = originalNumber - wholePart; // Get decimal part

    //// Format decimal part with two decimal places and comma separator
    //string formattedDecimalPart = decimalPart.ToString("C2"); // "C2" for currency format

    //Console.WriteLine("Original number: {0:F2}", originalNumber);
    //Console.WriteLine("Integer part: {0}", Math.Floor(originalNumber));
    //Console.WriteLine("Decimal part formatted with comma: {0}", formattedDecimalPart);
}