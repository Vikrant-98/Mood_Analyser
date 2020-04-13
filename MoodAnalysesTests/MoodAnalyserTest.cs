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
            MoodAnalyserFactory fact = new MoodAnalyserFactory();
            String actual = fact.Reflection();
            Assert.Equal("Mood", actual);
        }
        [Fact]
        public void MoodAnalysisClassFail()
        {
             MoodAnalyserFactory fact = new MoodAnalyserFactory();
             String actual = fact.Reflection();
             Assert.Equal("No Such Class", actual);
        }
    }
}
