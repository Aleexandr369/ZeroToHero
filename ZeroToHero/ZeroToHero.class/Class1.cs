﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Globalization;

namespace ZeroToHero.@class
{
    public class Convert
    {
        public string mconvert(int number,string language)
        {
            string result;
            result = number.ToWords(new CultureInfo(language));
            return result;
        }
    }
}