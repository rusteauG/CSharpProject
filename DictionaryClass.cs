using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class WordFrequency
    {
        // Input sentence
       public static string sentence = "This is an example sentence. This sentence is just an example.";
        public static void GetWord()
        {
            // Split the sentence into words
            string[] words = sentence.Split(' ');
            // Create a dictionary to store word frequencies
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            // Convert the word to lowercase to ensure case-insensitive counting
            foreach (string word in words)
            {
                string cleanWords = word.ToLower();



                // Increment the count if the word is already in the dictionary
                if (wordFrequency.ContainsKey(cleanWords))
                {

                    wordFrequency[cleanWords]++;

                    // Add the word to the dictionary with a count of 1 if it's not present
                }
                else
                {
                    wordFrequency[cleanWords] = 1;
                }

            }


            // Display word frequencies
            foreach (var kvp in wordFrequency)
            {
                Console.WriteLine($"Key: {kvp.Key}, Frequency: {kvp.Value} ");
            }

        }

        public static void GetChar()
        {
            // Create a dictionary to store character frequencies
            Dictionary<char, int> charFrequencies = new Dictionary<char, int>();
            foreach(char character in sentence)
            {
                char cleanedChar = char.ToLower(character);
                if(char.IsLetter(cleanedChar) )
                {
                   if( charFrequencies.ContainsKey(cleanedChar))
                    {
                        charFrequencies[cleanedChar]++;
                    }
                    else
                    {
                        charFrequencies[cleanedChar] = 1;
                    }
                }
            }
            // Display character frequencies
            foreach (var pair in charFrequencies)
            {
                Console.WriteLine($"Character: {pair.Key}, Frequency: {pair.Value}");
            }

        }
    }
    
}
