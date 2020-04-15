using System;
using Xunit;
using Mood_Analysis;

namespace MoodAnalysesTests
{
    public class MoodAnalyserTest
    {
        [Fact]
        public void MoodAnalyserSadTest()
        {
            Mood mood = new Mood("I am in Sad mood");
            String actual = mood.analyserMood();
            Assert.Equal("SAD", actual);
        }
        [Fact]
        public void MoodAnalyserHappyTest()
        {
            Mood mood = new Mood("I am Happy");
            String actual = mood.analyserMood();
            Assert.Equal("HAPPY", actual);
        }
        [Fact]
        public void MoodAnalysisExceptionTest()
        {
            Mood mood = new Mood("");
            String actual = mood.analyserMood();
            Assert.Equal("Attempt to Enter NULL String", actual);
        }
        [Fact]
        public void MoodAnalysisObjectTest()
        {
            MoodAnalyses mood = new MoodAnalyses();
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            Assert.Equal(fact.PassObject1().GetType(), mood.PassObject().GetType());
        }
        [Fact]
        public void MoodAnalysisClassFail()
        {
             MoodAnalyserFactory fact = new MoodAnalyserFactory();
             String actual = fact.Reflection();
             Assert.Equal("No Such Class", actual);
        }
        [Fact]
        public void MoodAnalysisConstructorFail()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectionConstructor();
            Assert.Equal("There is no such method", actual);
        }
        [Fact]
        public void MoodAnalysisParametericobject()
        {
            MoodAnalyses mood = new MoodAnalyses();
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            Assert.Equal(fact.PassMoodObject2().GetType(), mood.PassMoodObject1().GetType());
        }
        [Fact]
        public void MoodAnalysisParametericClassFail()
        {
            MoodAnalyserFactory parameter = new MoodAnalyserFactory();
            String actual = parameter.Reflection();
            Assert.Equal("No Such Class", actual);
        }
        [Fact]
        public void MoodAnalysisParametericConstructorFail()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectionConstructor();
            Assert.Equal("There is no such method", actual);
        }
        [Fact]
        public void MoodAnalysisMethod()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual1 = fact.ReflectionMethod1();
            String actual2 = fact.ReflectionMethod2();
            Assert.Equal("analyserMood", actual1);
            Assert.Equal("HAPPY",actual2);
        }
        [Fact]
        public void MoodAnalysisInvalidMethod()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual1 = fact.ReflectionMethod1();
            Assert.Equal("There is no such method", actual1);
        }
        [Fact]
        public void MoodAnalysisMethodDynamically()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectorMessageInvocation("I am in Happy mood");
            Assert.Equal("HAPPY", actual);
        }
        [Fact]
        public void MoodAnalysisMethodDynamicallyException()
        {
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.ReflectorMessageInvocation("I am in Sad mood");
            Assert.Equal("There is no such field", actual);
        }
    }
}
