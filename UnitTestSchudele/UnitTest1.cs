using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSchudele
{
    [TestClass]
    public class UnitTestRangeDate
    {
        [TestMethod]
        public void CheckDateRange()
        {
            DateTime DtStart = DateTime.Now;
            DateTime DtEnd = DateTime.Now.AddHours(1);

            //bool expected = DtStart > DtEnd;

            ////Schedule check = new HomeController(DtStart, DtEnd);
            //IScheduleRepository check;


            //// Act
            //check.CheckDateRange(DtEnd);

            //// Assert
            //double actual = check.Balance;
            //Assert.AreEqual(expected, actual, "Não pode adicionar esta data");
        }
    }
}
