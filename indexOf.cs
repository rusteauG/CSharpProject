            int[] numbers = { 10, 20, 30, 20, 40 };
            int index = 0; // Start searching from the beginning
            do
            {
                index = Array.IndexOf(numbers, 20, index); // Search for 20 starting from "index"
                if (index != -1)
                {
                    Console.WriteLine("Value found at index: {0}", index);
                    index++; // Increment index to start search from the next element
                }
            } while (index != -1); // Continue searching until "index" becomes -1 (not found)