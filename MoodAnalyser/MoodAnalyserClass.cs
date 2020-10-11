﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{

    public class MoodAnalyserClass
    {
        public string message { get; set; }
        public MoodAnalyserClass()
        {
            this.message = "";
        }
        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
