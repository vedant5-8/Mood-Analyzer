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
            Message = null;
        }

        public Mood_Analyze(string message)
        {
            Message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (this.Message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalysisException(
                        CustomMoodAnalysisException.MoodType.Empty_Message, 
                        "Mood should not be Empty.");
                }
                else if (this.Message.Contains("sad"))
                {
                    return SadMood;
                }
                else
                {
                    return HappyMood;
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalysisException(
                        CustomMoodAnalysisException.MoodType.Null_Message,
                        "Mood should not be Null.");
            }
        }
    }
}
