using System;

namespace MoodAnalyzer
{
    public class Mood_Analyze
    {
        public string HappyMood = "Happy";
        public string SadMood = "Sad";

        public string AnalyzeMood(string Mood)
        {
            if (Mood.Contains("sad"))
            {
                return SadMood;
            } 
            else
            {
                return HappyMood;
            }
        }
    }
}
