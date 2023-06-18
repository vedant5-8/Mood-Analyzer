using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");

            Console.WriteLine("Test Case1- I am in Sad Mood");

            Console.WriteLine("Test Case2- I am in Happy Mood");

            try
            {
                Console.WriteLine(MoodAnalyserFactory.ReflectionForDefaultConstructor("MoodAnalyzer.Mood_Analyze1", "Mood_Analyze"));
            }
            catch (CustomMoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}