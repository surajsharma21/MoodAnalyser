using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            string mood = "I am very Happy";
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(mood);
            System.Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
