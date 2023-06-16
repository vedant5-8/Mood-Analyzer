using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");

            /*Mood_Analyze mood1 = new Mood_Analyze("I am in sad mood.");

            Console.WriteLine(mood1.AnalyzeMood());

            Mood_Analyze mood2 = new Mood_Analyze("I am in any mood.");

            Console.WriteLine(mood2.AnalyzeMood());

            Mood_Analyze mood3 = new Mood_Analyze();

            Console.WriteLine(mood3.AnalyzeMood());*/

            try
            {
                Mood_Analyze mood1 = new Mood_Analyze();

                Console.WriteLine(mood1.AnalyzeMood());

            } catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}