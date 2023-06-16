using System;

namespace MoodAnalyzer
{
    public class Mood_Analyze
    {
        public string HappyMood = "Happy";
        public string SadMood = "Sad";

        public string Message;

        public Mood_Analyze()
        {

        }

        public Mood_Analyze(string message)
        {
            this.Message = message;
        }

        public string AnalyzeMood()
        {
            if (string.IsNullOrEmpty(this.Message))
            {
                throw new MoodAnalysisException("Mood Analysis Exception");
            }
            else if (Message.Contains("sad"))
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
