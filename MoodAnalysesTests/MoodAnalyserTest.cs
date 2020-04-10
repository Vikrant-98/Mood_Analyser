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
            Mood mood = new Mood();
            String actual = mood.analyserMood("I am in Sad Mood");
            Assert.Equal("SAD", actual);
        }

    }
}
