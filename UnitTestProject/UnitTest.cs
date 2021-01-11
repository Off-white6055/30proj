using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp1;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        
        [TestMethod]
        public void TestMeth()
        {
            


            DB db = new DB();
            var a = db.openConnection();
            Assert.AreEqual(1, a);
        }
    }
}
