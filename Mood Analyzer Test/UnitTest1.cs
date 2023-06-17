using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzer;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        // TC4.1 - Given NULL Mood Should Throw CustomMoodAnalysisException indicating Null Mood

        [TestMethod]
        public void TestCase1()
        {
            try
            {
                string MoodMSG = string.Empty;

                Mood_Analyze mood = new Mood_Analyze(MoodMSG);

                string actual = mood.AnalyzeMood();

            }
            catch (CustomMoodAnalysisException e)
            {
                string expected = "Mood should not be Empty.";

                Assert.AreEqual(expected, e.Message);
            }

        }

        // TC4.2 - Given Empty Mood Should Throw CustomMoodAnalysisException indicating Empty Mood

        [TestMethod]
        public void TestCase2()
        {

            try
            {
                string MoodMSG = null;

                Mood_Analyze mood = new Mood_Analyze(MoodMSG);

                string actual = mood.AnalyzeMood();

            }
            catch (CustomMoodAnalysisException e)
            {
                string expected = "Mood should not be Null.";

                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}