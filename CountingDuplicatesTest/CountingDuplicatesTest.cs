using System;
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
    }

    public class StringService
    {
        public int CountDuplicateChar(string question)
        {
            int duplicateCharCount = 0;
            for (int i = 0; i < question.Length; i++)
            {
                for (int j = i + 1; j < question.Length; j++)
                {
                    if (question[j].Equals(question[i]))
                    {
                        duplicateCharCount++;
                    }
                }
            }

            return duplicateCharCount;
        }
    }
}