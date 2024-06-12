# WordFrequencyAnalyser
Analysing text data by calculating the frequency of words within a given input.

This is a .NET framework class library designed to analyze strings and determine the frequency of words within them. The primary goal of this library is to identify the most frequent words in a given text, disregarding letter case and alphanumeric characters.The words are splitted based on space character.

Overview
The library consists of  interfaces and a classes:

Interface: IWordFrequency

Defines properties for a word and its frequency.

Class: WordFrequencyAnalyzer

Implements the IWordFrequencyAnalyzer interface.

Provides methods for calculating word frequencies and identifying the most frequent words in a text.
# Features
Calculate Highest Frequency: Determine the highest frequency of any word in the input text.

Calculate Frequency for Word: Find the frequency of a specific word within the input text.

Calculate Most Frequent Words: Identify the most frequently occurring words in the input text, with options to specify the number of words to return.

Added Console App to enter the string 

Uses MSTest For Testing automated use cases
