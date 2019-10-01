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

            var charCounting = stringService.CharCounting("question");

            Assert.AreEqual(0, charCounting);
        }
    }

    public class StringService
    {
        public int CharCounting(string question)
        {
            throw new NotImplementedException();
        }
    }
}