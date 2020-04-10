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
            Mood mood = new Mood(input);
            Console.WriteLine(mood.analyserMood());
        }
    }
    public class Mood
    {
        String message;
        public Mood()
        {
        }
        public Mood(String message)
        {
            this.message = message;
        }
        public String analyserMood()
        {
            try
            {
                if (message.Length == 0)
                {
                    throw new Exception();
                }

                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
}
