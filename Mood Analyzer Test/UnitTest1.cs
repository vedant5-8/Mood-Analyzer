using MoodAnalyzer;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1()
        {
            Mood_Analyze mood = new Mood_Analyze();

            string message = "I am in sad mood.";

            string ExpectedResult = mood.AnalyzeMood(message);
            string ActualResult = "Sad";

            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}