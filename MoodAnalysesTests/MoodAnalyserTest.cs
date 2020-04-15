using System;
using Xunit;
using Mood_Analysis;

namespace MoodAnalysesTests
{
    public class MoodAnalyserTest
    {
        /// <summary>
        /// Test for Sad message
        /// </summary>
        [Fact]
        public void MoodAnalyserSadTest()
        {
            Mood mood = new Mood("I am in Sad mood");
            String actual = mood.analyserMood();
            Assert.Equal("SAD", actual);
        }
        /// <summary>
        /// Test for Happy message
        /// </summary>
        [Fact]
        public void MoodAnalyserHappyTest()
        {
            Mood mood = new Mood("I am Happy");
            String actual = mood.analyserMood();
            Assert.Equal("HAPPY", actual);
        }
        /// <summary>
        /// Test Exception message for Null string
        /// </summary>
        [Fact]
        public void MoodAnalysisExceptionTest()
        {
            Mood mood = new Mood("");
            String actual = mood.analyserMood();
            Assert.Equal("Attempt to Enter NULL String", actual);
        }
        /// <summary>
        /// Test for Objects are Equal
        /// </summary>
        [Fact]
        public void MoodAnalysisObjectTest()
        {
            MoodAnalyses mood = new MoodAnalyses();
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            Assert.Equal(fact.PassObject1().GetType(), mood.PassObject().GetType());
        }
        /// <summary>
        /// Test for Valid class
        /// </summary>
        [Fact]
        public void MoodAnalysisClassFail()
        {
             MoodAnalyserFactory fact = new MoodAnalyserFactory();
             String actual = fact.Reflection();
             Assert.Equal("No Such Class", actual);
        }
        /// <summary>
        /// Test for Default Constructor
        /// </summary>
        [Fact]
        public void MoodAnalysisConstructorFail()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectionConstructor();
            Assert.Equal("There is no such method", actual);
        }
        /// <summary>
        /// Test for Parameteric Object are Equal
        /// </summary>
        [Fact]
        public void MoodAnalysisParametericobject()
        {
            MoodAnalyses mood = new MoodAnalyses();
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            Assert.Equal(fact.PassMoodObject2().GetType(), mood.PassMoodObject1().GetType());
        }
        /// <summary>
        /// Test for Valid class
        /// </summary>
        [Fact]
        public void MoodAnalysisParametericClassFail()
        {
            MoodAnalyserFactory parameter = new MoodAnalyserFactory();
            String actual = parameter.Reflection();
            Assert.Equal("No Such Class", actual);
        }
        /// <summary>
        /// Test for Parametric Constructor
        /// </summary>
        [Fact]
        public void MoodAnalysisParametericConstructorFail()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectionConstructor();
            Assert.Equal("There is no such method", actual);
        }
        /// <summary>
        /// Test for Method Invocation and HAPPY message
        /// </summary>
        [Fact]
        public void MoodAnalysisMethod()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual1 = fact.ReflectionMethod1();
            String actual2 = fact.ReflectionMethod2();
            Assert.Equal("analyserMood", actual1);
            Assert.Equal("HAPPY",actual2);
        }
        /// <summary>
        ///  Test for Method is valid or not
        /// </summary>
        [Fact]
        public void MoodAnalysisInvalidMethod()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual1 = fact.ReflectionMethod1();
            Assert.Equal("There is no such method", actual1);
        }
        /// <summary>
        ///  Test for HAPPY Message
        /// </summary>
        [Fact]
        public void MoodAnalysisMethodDynamically()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectorMessageInvocation("I am in Happy mood");
            Assert.Equal("HAPPY", actual);
        }
        /// <summary>
        ///  Test for Exception for no such field
        /// </summary>
        [Fact]
        public void MoodAnalysisMethodDynamicallyException()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectorMessageInvocation("I am in Sad mood");
            Assert.Equal("There is no such field", actual);
        }
        /// <summary>
        ///  Test for Exception for Null String 
        /// </summary>
        [Fact]
        public void MoodAnalysisMethodDynamicallyNullException()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectorMessageInvocation("");
            Assert.Equal("Attempt to Enter NULL String", actual);
        }
    }
}
