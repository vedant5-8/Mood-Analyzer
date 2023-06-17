using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzer;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        // TC1.1 - Given “I am in sad mood” message Should Return SAD
        
        [TestMethod]
        public void TestCase1()
        {
            string MoodMSG = "I am in sad mood.";

            Mood_Analyze mood = new Mood_Analyze();

            string actual = mood.AnalyzeMood(MoodMSG);

            string expected = "Sad";

            Assert.AreEqual(expected, actual);
            
        }

        // TC1.2 - Given “I am in any mood” message Should Return Happy

        [TestMethod]
        public void TestCase2()
        {
            string MoodMSG = "I am in any mood.";

            Mood_Analyze mood = new Mood_Analyze();

            string actual = mood.AnalyzeMood(MoodMSG);

            string expected = "Happy";

            Assert.AreEqual(expected, actual);
        }

    }
}