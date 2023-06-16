using System;

namespace MoodAnalyzer
{
    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException() { }
        public MoodAnalysisException(string message) : base(message)
        {

        }
    }
}
