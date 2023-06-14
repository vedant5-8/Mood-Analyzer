using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");

            // UC1 - analyse and Happy or Sad Mood
            Mood_Analyze mood = new Mood_Analyze();

            // TC1.1 - Analyze Sad Mood
            Console.WriteLine(mood.AnalyzeMood("I am in sad mood."));

            // TC1.2 - Analyze any mood
            Console.WriteLine(mood.AnalyzeMood("I am in happy mood."));

        }
    }
}