using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schedule;
using System;
using System.Collections.Generic;

namespace Schedule.Controllers
{
    [TestClass]
    public class UnitTestRangeDate
    {
        [TestMethod]
        public void CheckDateRange()
        {
            DateTime DtStart = DateTime.Now;
            DateTime DtEnd = DateTime.Now.AddHours(1);

            Schedule schedule = new Schedule();
            List<Schedule> scheduleList = new List<Schedule>();
            scheduleList.Add(new Schedule()
            {
                Name = "Lucas",
                DtBirth = Convert.ToDateTime("26/12/1991"),
                DtStart = Convert.ToDateTime("21/10/2019"),
                DtExit = DtStart.AddHours(1),
                Description = "Note Lucas"
            });
            scheduleList.Add(new Schedule()
            {
                Name = "Pedro",
                DtBirth = Convert.ToDateTime("27/12/1991"),
                DtStart = Convert.ToDateTime("21/10/2019"),
                DtExit = DtStart.AddHours(1),
                Description = "Note Pedro"
            }); scheduleList.Add(new Schedule()
            {
                Name = "Thiago",
                DtBirth = Convert.ToDateTime("28/12/1991"),
                DtStart = Convert.ToDateTime("21/10/2019"),
                DtExit = DtStart.AddHours(1),
                Description = "Note Thiago"
            });


            ;

            schedule.IsValidDate(scheduleList);

            var actual = this;
            Assert.AreEqual(this, actual, "Calendar cannot be created");
        }


        [TestMethod]
        public void EndStartDate()
        {
            DateTime DtStart = Convert.ToDateTime("21/10/2019");
            DateTime DtEnd =  Convert.ToDateTime("21/10/2019 01:00:00");
            bool expected = true;

            Schedule schedule = new Schedule();

            bool actual = schedule.CheckDate(DtStart, DtEnd);

            Assert.AreEqual(expected, actual, "Exit Date Greater than Start Date");
        }
    }
}
