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
    /// <summary>
    /// New Mood Analysis Exception class is defined and Extended the Exception Class
    /// </summary>
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_FILE, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        ExceptionType type;
        public MoodAnalysisException(ExceptionType type, String message) : base(message)
        {
        }
    }
    /// <summary>
    /// Mode class check the moode of the user wether he is happy or sad
    /// Two condtructor are defined one is parameter and other is default
    /// Analyser mood method returning the mood of user
    /// User defined Exception Mood Analysis Exception is used to handle
    /// </summary>
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
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_NULL, "Attempt to Enter NULL String");
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
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }
    }
}
