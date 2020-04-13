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
            Type type = typeof(Mood);
            Console.WriteLine("Class : " + type.Name);
            return type.Name;
        }
    }
}