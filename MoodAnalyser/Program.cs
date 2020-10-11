﻿using System;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string mood = Console.ReadLine();
                MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(mood);
                string result = moodAnalyser.AnalyseMood();
                Console.WriteLine(result);
            }
            catch (MoodAnalysisException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
