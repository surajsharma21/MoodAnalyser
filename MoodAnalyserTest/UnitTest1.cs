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
        public void TestAnalyseMood_Should_return_HAPPY()
        {
            //Arrange
            string message = "I am in Happy Mood";
            MoodAnalyserClass mood = new MoodAnalyserClass(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(result, "HAPPY");
        }
    }
}
