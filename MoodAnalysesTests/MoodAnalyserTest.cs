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
    }
}
