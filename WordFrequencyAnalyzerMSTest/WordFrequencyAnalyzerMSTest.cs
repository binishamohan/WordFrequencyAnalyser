using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordFrequencyAnalyzerLibrary;

namespace WordFrequencyAnalyzerMSTest
{
    [TestClass]
    public class WordFrequencyAnalyzerMSTest
    {
        private WordFrequencyAnalyzer _analyzer;

        [TestInitialize]
        public void Initialize()
        {
            _analyzer = new WordFrequencyAnalyzer();
        }

        [TestMethod]
        public void CalculateHighestFrequency_ReturnsCorrectValue()
        {
            string text = "The sun shines over the lake and the lake is beautiful";
            int expectedFrequency = 3;
            int actualFrequency = _analyzer.CalculateHighestFrequency(text);
            Assert.AreEqual(expectedFrequency, actualFrequency);
        }

        [TestMethod]
        public void CalculateFrequencyForWord_ReturnsCorrectValue()
        {
            string text = "The sun shines over the lake and the lake is beautiful";
            string word = "lake";
            int expectedFrequency = 2;
            int actualFrequency = _analyzer.CalculateFrequencyForWord(text, word);
            Assert.AreEqual(expectedFrequency, actualFrequency);
        }

        [TestMethod]
        public void CalculateMostFrequentWords_ReturnsCorrectWords()
        {
            string text = "The sun shines over the lake and the lake is beautiful";
            int number = 3;
            var expectedWords = new string[] { "the", "lake", "and" };
            var mostFrequentWords = _analyzer.CalculateMostFrequentWords(text, number);
            Assert.AreEqual(expectedWords.Length, mostFrequentWords.Count);
            for (int i = 0; i < expectedWords.Length; i++)
            {
                Assert.AreEqual(expectedWords[i], mostFrequentWords[i].Word);
            }
        }
    }
}
