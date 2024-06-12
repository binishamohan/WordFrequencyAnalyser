using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WordFrequencyAnalyzerLibrary.Interfaces;

namespace WordFrequencyAnalyzerLibrary
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        public int CalculateHighestFrequency(string text)
        {
            var frequencies = GetWordFrequencies(text);
            return frequencies.Values.Max();
        }

        public int CalculateFrequencyForWord(string text, string word)
        {
            var frequencies = GetWordFrequencies(text);
            return frequencies.ContainsKey(word.ToLower()) ? frequencies[word.ToLower()] : 0;
        }

        public IList<IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {
            var frequencies = GetWordFrequencies(text);

            return frequencies
                .OrderByDescending(f => f.Value)
                .ThenBy(f => f.Key)
                .Take(number)
                .Select(f => new WordFrequency { Word = f.Key, Frequency = f.Value })
                .ToList<IWordFrequency>();
        }

        private Dictionary<string, int> GetWordFrequencies(string text)
        {
            if (!Regex.IsMatch(text, @"^[a-zA-Z\s]+$"))
            {
                throw new ArgumentException("The text contains invalid characters.");
            }

            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(word => word.ToLower());

            var frequencies = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }
    }
}
