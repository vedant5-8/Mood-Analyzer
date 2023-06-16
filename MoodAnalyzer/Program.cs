using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");

            try
            {
                Mood_Analyze mood1 = new Mood_Analyze();

                Console.WriteLine(mood1.AnalyzeMood());

            } catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}