using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class Mood_Analyze
    {
        public string HappyMood = "Happy";
        public string SadMood = "Sad";

        public string AnalyzeMood(string mood)
        {
            if (mood.Contains("sad"))
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
