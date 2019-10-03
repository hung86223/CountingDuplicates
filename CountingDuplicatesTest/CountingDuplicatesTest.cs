using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingDuplicatesTest
{
    [TestClass]
    public class CountingDuplicatesTest
    {
        [TestMethod]
        public void NoCharactersRepeat()
        {
            var stringService = new StringService();

            var charCounting = stringService.CountDuplicateChar("abcde");

            Assert.AreEqual(0, charCounting);
        }

        [TestMethod]
        public void TwoCharactersRepeat()
        {
            var stringService = new StringService();

            var charCounting = stringService.CountDuplicateChar("aabbcde");

            Assert.AreEqual(2, charCounting);
        }

        [TestMethod]
        public void ManySameCharactersRepeat()
        {
            var stringService = new StringService();

            var charCounting = stringService.CountDuplicateChar("indivisibilities");

            Assert.AreEqual(2, charCounting);
        }

        [TestMethod]
        public void StringIncludeUpperCharacters()
        {
            var stringService = new StringService();

            var charCounting = stringService.CountDuplicateChar("Indiviibilities");

            Assert.AreEqual(1, charCounting);
        }
    }

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