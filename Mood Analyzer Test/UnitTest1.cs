using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzer;
using Newtonsoft.Json.Linq;
using System.Security.Claims;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        // TC4.1 - Given MoodAnalyser Class Name Should Return MoodAnalyser Object

        [TestMethod]
        public void TestCase1()
        {
            try
            {
                object expected = new Mood_Analyze(null);
                object actual = MoodAnalyserFactory.ReflectionForDefaultConstructor("MoodAnalyzer.Mood_Analyze", "Mood_Analyze"); ;
                expected.Equals(actual);
            }
            catch (CustomMoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // TC4.2 - Given Class Name When Improper Should Throw MoodAnalysisException

        [TestMethod]
        public void TestCase2()
        {
            try
            {
                object expected = new Mood_Analyze(null);
                object actual = MoodAnalyserFactory.ReflectionForDefaultConstructor("MoodAnalyzer.Mood_Analyze1", "Mood_Analyze"); ;
            }
            catch (CustomMoodAnalysisException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        // UC4.3 - Given Class When Constructor Not Proper Should Throw MoodAnalysisException

        [TestMethod]
        public void TestCase3()
        {
            try
            {
                object expected = new Mood_Analyze(null);
                object actual = MoodAnalyserFactory.ReflectionForDefaultConstructor("MoodAnalyzer.Mood_Analyze1", "Mood_Analyze1"); ;
            }
            catch (CustomMoodAnalysisException ex)
            {
                Assert.AreEqual("Constructor is not found", ex.Message);
            }
        }

    }
}