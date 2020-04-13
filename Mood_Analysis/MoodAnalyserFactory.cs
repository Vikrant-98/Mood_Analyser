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
        Type type = typeof(Mood);

        public string Reflection()
        {
            try
            {
                if (type.Name != "Mood")
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
        public string ReflectionConstructor()
        {
            ConstructorInfo[] constructorInfo = type.GetConstructors();

            foreach (ConstructorInfo c in constructorInfo)
            {
                try
                {
                    if (c.IsConstructor != false)
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "There is no such method");
                    }
                    return type.Name;
                }
                catch (MoodAnalysisException ex)
                {
                    return ex.Message;
                }
            }
            return type.Name;
        }
    }
}