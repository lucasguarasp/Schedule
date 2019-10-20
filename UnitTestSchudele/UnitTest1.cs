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
            bool expected = false;

            Schedule schedule = new Schedule()
            {
                Name = "Pedrinho",
                DtBirth = Convert.ToDateTime("21/10/1996"),
                DtStart = Convert.ToDateTime("27/10/2019"),
                DtExit = Convert.ToDateTime("28/10/2019"),
                Description = "Note Lucas"
            };

            List<Schedule> scheduleList = new List<Schedule>();
            scheduleList.Add(new Schedule()
            {
                Name = "Lucas",
                DtBirth = Convert.ToDateTime("26/12/1991"),
                DtStart = Convert.ToDateTime("21/10/2019"),
                DtExit = Convert.ToDateTime("22/10/2019"),
                Description = "Note Lucas"
            });
            scheduleList.Add(new Schedule()
            {
                Name = "Pedro",
                DtBirth = Convert.ToDateTime("27/12/1991"),
                DtStart = Convert.ToDateTime("23/10/2019"),
                DtExit = Convert.ToDateTime("24/10/2019"),
                Description = "Note Pedro"
            }); scheduleList.Add(new Schedule()
            {
                Name = "Thiago",
                DtBirth = Convert.ToDateTime("28/12/1991"),
                DtStart = Convert.ToDateTime("25/10/2019"),
                DtExit = Convert.ToDateTime("26/10/2019"),
                Description = "Note Thiago"
            });



            schedule.IsValidDate(scheduleList);

            bool actual = false;
            Assert.AreEqual(expected, actual, "Calendar cannot be created");
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
