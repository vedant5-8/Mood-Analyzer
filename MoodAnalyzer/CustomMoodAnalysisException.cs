using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class CustomMoodAnalysisException : Exception
    {
        public enum MoodType
        {
            Empty_Message,
            Null_Message
        }

        public readonly MoodType type;
        public CustomMoodAnalysisException(MoodType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
