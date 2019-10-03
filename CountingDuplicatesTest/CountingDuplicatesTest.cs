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

            var charCounting = stringService.CountDuplicateChar("IndIviibilities");

            Assert.AreEqual(1, charCounting);
        }
    }
}