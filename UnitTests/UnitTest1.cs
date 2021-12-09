using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUploadImage()
        {
            bool expected = true;
            bool actual;
            string expectedString = "https://i.ibb.co/";
            var a = XMLSer.modules.uploadImageModule.Upload2imgbb(@"C:\Users\User\Desktop\docs\zRFSIRMDh1I.jpg");
            if (a.Contains(expectedString))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
