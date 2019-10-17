using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.BL
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
