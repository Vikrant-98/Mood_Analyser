using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Mood_Analysis
{
    public class MoodAnalyserFactory
    {
        public string Reflection()
        {
            try
            {
                Type type = typeof(Mood);
                Console.WriteLine("Class : " + type.Name);
                if (type.Name != "Mooo")
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No Such Class");
                }
                return type.Name;
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
            
        }
    }
}