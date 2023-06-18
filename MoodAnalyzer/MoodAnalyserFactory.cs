using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object ApplyDRYPrincipleOnReflection(string NameSapceAndclassName, string constructorName)
        {
            Type type = typeof(Mood_Analyze);

            if (type.Name.Equals(NameSapceAndclassName) || type.FullName.Equals(NameSapceAndclassName))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "message" });
                    return instance;
                }
                else
                {
                    throw new CustomMoodAnalysisException(CustomMoodAnalysisException.MoodType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new CustomMoodAnalysisException(CustomMoodAnalysisException.MoodType.NO_SUCH_CLASS, "Class not found");
            }
        }

    }
}
