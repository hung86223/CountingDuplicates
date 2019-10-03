﻿using System.Collections.Generic;
using System.Linq;

namespace CountingDuplicatesTest
{
    public class StringService
    {
        public int CountDuplicateChar(string question)
        {
            return question.ToLower().GroupBy(c => c).Count(g => g.Count<char>() > 1);
        }
    }
}