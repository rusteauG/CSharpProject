//SubString
           string str = "Hello, World!";
           //Extract first 5 chars
           string subsstring1 = str.Substring(0,5);
           Console.WriteLine(subsstring1);
           // Extract from the 7th character to the end:
           string substring2 = str.Substring(7,str.Length-7);
           Console.WriteLine(substring2);
           //OR
           substring2 =str.Substring(7);
           Console.WriteLine(substring2);
           str = "The quick brown fox jumps over the lazy dog.";
           // Extract everything after the first space:
           int spaceIndex = str.IndexOf(' ');  
           substring2 = str.Substring(spaceIndex+1);
           Console.WriteLine(substring2);
           //Extract everything between two characters: 
           // Extract everything between 'i' and 'g':

           string str1 = "This is an example string.";
           int startIndex = str1.IndexOf('i');
           int endIndex = str1.IndexOf('g');
           string substring3 = str1.Substring(startIndex+1,endIndex-startIndex -1);
           Console.WriteLine(substring3);