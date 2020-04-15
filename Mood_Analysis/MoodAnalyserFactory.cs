using System;
using System.Reflection;

namespace Mood_Analysis
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// MoodAnalyses object created and return object
        /// </summary>
        /// <returns>MoodAnalyses Object</returns>
        public MoodAnalyses PassObject1()
        {
            MoodAnalyses mood1 = new MoodAnalyses();
            return mood1;
        }
        /// <summary>
        /// Mood object created and return object 
        /// </summary>
        /// <returns>Mood object</returns>
        public Mood PassMoodObject2()
        {
            Mood mood1 = new Mood("I am in Happy Mood");
            return mood1;
        }
        /// <summary>
        /// Class Reflection checking
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Constructor Reflection created
        /// </summary>
        /// <returns>Constructor name</returns>
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
        public string ReflectionMethod1()
        {
            MethodInfo[] methodInfo = type.GetMethods();
            
            foreach (MethodInfo temp in methodInfo)
            {
                try
                {
                    if (temp.Name != "analyserMood")
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "There is no such method");
                    }
                    return temp.Name;
                }
                catch (MoodAnalysisException ex)
                {
                    return ex.Message;
                }
            }
            return "Null";
        }
        public string ReflectionMethod2()
        {
            Mood mood = new Mood("I am in Happy Mood");
            return mood.analyserMood();
        }
    }
}