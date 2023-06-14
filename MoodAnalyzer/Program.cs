using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");
            /*
            // UC1 - analyse and Happy or Sad Mood
            Mood_Analyze mood = new Mood_Analyze();

            // TC1.1 - Analyze Sad Mood
            Console.WriteLine(mood.AnalyzeMood("I am in sad mood."));

            // TC1.2 - Analyze any mood
            Console.WriteLine(mood.AnalyzeMood("I am in happy mood."));
            */

            Mood_Analyze mood1 = new Mood_Analyze("I am in sad mood.");

            Console.WriteLine(mood1.AnalyzeMood());

            Mood_Analyze mood2 = new Mood_Analyze("I am in any mood.");

            Console.WriteLine(mood2.AnalyzeMood());

            Mood_Analyze mood3 = new Mood_Analyze();

            Console.WriteLine(mood3.AnalyzeMood());
        }
    }
}