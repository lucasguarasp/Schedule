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


        [HttpPost]
        public async Task<JsonResult> SaveEvent(Schedule e)
        {
            var status = false;

            var events = _schedule.GetAll().Select(c =>
            new
            {
                c.DtStart,
                c.DtExit
            });

            //retorna caso esteja no mesmo range de marcaçao
            if (events.Any(x => e.DtStart >= x.DtStart && e.DtStart <= x.DtExit || e.DtExit <= x.DtExit && e.DtExit >= x.DtStart))
                return null;

            if (e.Id > 0)
            {
                //Update the event
                var v = _schedule.GetAll().Where(a => a.Id == e.Id).FirstOrDefault();
                if (v != null)
                {
                    v.Name = e.Name;
                    v.DtBirth = e.DtBirth;
                    v.DtStart = e.DtStart;
                    v.DtExit = e.DtExit;
                    v.Description = e.Description;
                }
            }
            else
            {
                _schedule.Add(e);
            }

            await _schedule.Save();

            status = true;

            return new JsonResult(status);
            //return new JsonResult { Data = new { status = status } };
        }

        public async Task<JsonResult> GetEvents()
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
                await _schedule.Save();
                status = true;

            }

            return new JsonResult(status);
        }
    }
}