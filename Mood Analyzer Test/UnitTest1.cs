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

        /*
        [TestMethod]
        public void TestCase3()
        {
            NullReferenceException ex = new NullReferenceException();
            string actual;

            try
            {
                Mood_Analyze mood = new Mood_Analyze();

                actual = mood.AnalyzeMood();

            }
            catch
            {
                actual = ex.Message;
            }

            string expected = ex.Message;

            Assert.AreEqual(actual, expected);
        }
        */

        // Given NULL Mood Should Throw MoodAnalysisException

        [TestMethod]
        public void TestCase4()
        {
            MoodAnalysisException ex = new MoodAnalysisException();
            string actual;

            try
            {
                Mood_Analyze mood = new Mood_Analyze();

                actual = mood.AnalyzeMood();
            }
            catch
            {
                actual = ex.Message;
            }

            string expected = ex.Message;

            Assert.AreEqual(actual, expected);
        }
    }
}