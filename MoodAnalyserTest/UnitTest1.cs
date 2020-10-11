using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAnalyseMood_Should_return_SAD()
        {
            //Arrange
            string message = "I am in a Sad Mood";
            MoodAnalyserClass mood = new MoodAnalyserClass(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(result, "SAD");
        }

        [TestMethod]
        public void TestAnalyseMood_Should_return_CustomNullMsgException_When_given_null()
        {
            try
            {
                string message = null;
                MoodAnalyserClass mood = new MoodAnalyserClass(message);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException m)
            {
                Assert.AreEqual("Message should not be null", m.Message);
            }
        }
        [TestMethod]
        public void TestAnalyseMood_Should_return_CustomEmptyMsgException_When_given_empty()
        {
            try
            {
                string message = "";
                MoodAnalyserClass mood = new MoodAnalyserClass(message);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException m)
            {
                Assert.AreEqual("Message should not be empty", m.Message);
            }
        }
    }
}
