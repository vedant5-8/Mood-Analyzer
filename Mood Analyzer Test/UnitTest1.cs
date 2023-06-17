using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzer;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        // TC3.1 - Given Null Mood Should Return Happy

        [TestMethod]
        public void TestCase1()
        {
            string MoodMSG = "";

            Mood_Analyze mood = new Mood_Analyze(MoodMSG);

            string actual = mood.AnalyzeMood();

            string expected = "Happy";

            Assert.AreEqual(expected, actual);
            
        }

    }
}