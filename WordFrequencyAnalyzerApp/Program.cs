using System;
using WordFrequencyAnalyzerLibrary;
using WordFrequencyAnalyzerLibrary.Interfaces;
using System.Collections.Generic;

namespace WordFrequencyAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var analyzer = new WordFrequencyAnalyzer();

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            try
            {
                int highestFrequency = analyzer.CalculateHighestFrequency(input);
                Console.WriteLine($"Highest Frequency: {highestFrequency}");

                Console.WriteLine("Enter a word to check its frequency:");
                string word = Console.ReadLine();
                int wordFrequency = analyzer.CalculateFrequencyForWord(input, word);
                Console.WriteLine($"Frequency for '{word}': {wordFrequency}");


                Console.WriteLine("Enter the number of most frequent words to display:");
               
                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    throw new ArgumentException("Please enter a valid number.");
                }
                var mostFrequentWords = analyzer.CalculateMostFrequentWords(input, number);
                Console.WriteLine("Most Frequent Words:");
                foreach (var wordFreq in mostFrequentWords)
                {
                    Console.WriteLine($"Word: {wordFreq.Word}, Frequency: {wordFreq.Frequency}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
