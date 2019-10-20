using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Schedule.Models;

namespace Schedule.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScheduleRepository _schedule;

        public HomeController(IScheduleRepository schedule)
        {
            _schedule = schedule;
        }

        public IActionResult Index()
        {
            // _schedule.Add();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public bool CheckDateRange(Schedule e)
        {
            var events = _schedule.GetAll().Select(c =>
            new
            {
                c.DtStart,
                c.DtExit
            });

            //retorna caso esteja no mesmo range de marcaçao
            if (events.Any(x => e.DtStart >= x.DtStart && e.DtStart <= x.DtExit || e.DtExit <= x.DtExit && e.DtExit >= x.DtStart))
                return true;

            return false;
        }

        //private bool IsValidDate(Schedule e)
        //{
        //    List<Schedule> events = _schedule.GetAll();
        //    Func<Schedule,bool> existDateInRange = x => e.DtStart >= x.DtStart && e.DtStart <= x.DtExit || e.DtExit <= x.DtExit && e.DtExit >= x.DtStart;
        //    return events.Any(existDateInRange);
        //}

        [HttpPost]
        public async Task<JsonResult> SaveEvent(Schedule calendary)
        {
            try
            {
                List<Schedule> getAllSchedule = _schedule.GetAll();

                foreach (Schedule item in getAllSchedule)
                {
                    if (item.Id == calendary.Id)
                    {
                        getAllSchedule.Remove(item);
                        break;
                    }
                }

                //if (calendary.Id == 0)
                //calendary.IsValidDate(_schedule.GetAll());
                calendary.IsValidDate(getAllSchedule);

                //if (IsValidDate(calendary))
                //    return null;

                bool status = false;

                Schedule scheduleEdit = _schedule.GetById(calendary.Id);
                //ou
                //Schedule getById = _schedule.GetWithCondition(x => x.Id == calendary.Id);
                //get all name = Lucas
                //List<Schedule> getStartDate = _schedule.GetListWithCondition(x => x.Name == "Lucas");

                if (scheduleEdit != null)
                    scheduleEdit.Update(calendary);
                else
                    _schedule.Add(calendary);

                status = await _schedule.Save();

                return new JsonResult(new { status });
            }
            catch (Exception e)
            {
                return new JsonResult(new { msg = e.Message, erro = true });
            }
        }

        public JsonResult GetEvents()
        {
            var events = _schedule.GetAll().ToList();
            return new JsonResult(events);

        }

        [HttpPost]
        public async Task<JsonResult> DeleteEvent(int eventID)
        {
            var status = false;
            var calendar = _schedule.GetById(eventID);

            _schedule.Delete(calendar);

            if (calendar != null)
            {
                _schedule.Delete(calendar);
                status = await _schedule.Save();
            }

            return new JsonResult(new { status });
        }
    }
}