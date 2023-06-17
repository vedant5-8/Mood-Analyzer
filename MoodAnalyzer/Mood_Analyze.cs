using System;

namespace MoodAnalyzer
{
    public class Mood_Analyze
    {
        public string HappyMood = "Happy";
        public string SadMood = "Sad";

        public string Message;

        public Mood_Analyze(string message)
        {
            Message = message;
        }

        public string AnalyzeMood()
        {
            if (this.Message.Contains("sad"))
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
