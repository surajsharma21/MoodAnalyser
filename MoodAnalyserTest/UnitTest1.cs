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
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        {
            string className = "MoodAnalyser.MoodAnalyserClass";
            string constructorName = "MoodAnalyserClass";
            MoodAnalyserClass expected = new MoodAnalyserClass();
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            expected.Equals(resultObj);
        }
        [TestMethod]
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Class()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {

            //Arrange
            string className = "MoodAnalyser.MoodAnalyserClass";
            string constructorName = "MoodAnalyserClass";
            MoodAnalyserClass expectedObj = new MoodAnalyserClass("HAPPY");
            //Act
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName);
            //Assert
            expectedObj.Equals(resultObj);
        }

        [TestMethod]
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                MoodAnalyserClass expectedObj = new MoodAnalyserClass("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyser.MoodAnalyserClass";
                string constructorName = "WrongConstructorName";
                MoodAnalyserClass expectedObj = new MoodAnalyserClass("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
    }
}
