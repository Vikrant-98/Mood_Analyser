﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Mood_Analysis
{
    public class MoodAnalyserFactory
    {
        public MoodAnalyses PassObject1()
        {
            MoodAnalyses mood1 = new MoodAnalyses();
            return mood1;
        }
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
        public void demo()
        {
            Type type = typeof(MoodAnalyses);

            PropertyInfo[] propertyInfo = type.GetProperties();

            Console.WriteLine("The list of properties of the Customer class are:--");

            foreach (PropertyInfo pInfo in propertyInfo)
            {
                Console.WriteLine(pInfo.Name);
            }
        }
    }
}