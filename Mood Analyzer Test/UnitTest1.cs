using MoodAnalyzer;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestCase1()
        {
            string message = "I am in sad mood.";

            Mood_Analyze mood = new Mood_Analyze(message);

            string ExpectedResult = mood.AnalyzeMood();
            string ActualResult = "Sad";

            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        

        [TestMethod]
        public void TestCase2()
        {
            string message = "I am in happy mood.";

            Mood_Analyze mood = new Mood_Analyze(message);

            string ExpectedResult = mood.AnalyzeMood();
            string ActualResult = "Happy";

            Assert.AreEqual(ExpectedResult, ActualResult);
        }

    }
}