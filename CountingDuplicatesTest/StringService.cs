using System.Collections.Generic;

namespace CountingDuplicatesTest
{
    public class StringService
    {
        public int CountDuplicateChar(string question)
        {
            var duplicateChars = new List<char>();
            var lowerStr = question.ToLower();
            for (int i = 0; i < lowerStr.Length; i++)
            {
                for (int j = i + 1; j < lowerStr.Length; j++)
                {
                    if (lowerStr[j].Equals(lowerStr[i]) && !duplicateChars.Contains(lowerStr[j]))
                    {
                        duplicateChars.Add(lowerStr[j]);
                    }
                }
            }

            return duplicateChars.Count;
        }
    }
}