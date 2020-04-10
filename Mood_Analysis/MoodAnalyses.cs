using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analysis
{
    public static class MoodAnalyses
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Mood mood = new Mood();
            Console.WriteLine(mood.analyserMood(input));
        }
    }
    public class Mood
    {
        public String analyserMood(String message)
        {
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }   
        }
    }
}
