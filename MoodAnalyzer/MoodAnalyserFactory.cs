using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string NameSapceAndclassName, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            bool result = Regex.IsMatch(NameSapceAndclassName, pattern);

            if (result)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(NameSapceAndclassName);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomMoodAnalysisException(CustomMoodAnalysisException.MoodType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new CustomMoodAnalysisException(CustomMoodAnalysisException.MoodType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }



    }
}
