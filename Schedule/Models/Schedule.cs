using System;
using System.Collections.Generic;
using System.Linq;

namespace Schedule
{
    public class Schedule
    {
        public Schedule()
        {

        }

        public Schedule(int id, string name, DateTime dtBirth, DateTime dtStart, DateTime dtExit, string description)
        {
            Id = id;
            Name = name;
            DtBirth = dtBirth;
            DtStart = dtStart;
            DtExit = dtExit;
            Description = description;
        }

        //Nome do paciente, Data de nascimento, Data e hora inicial da consulta, Data e hora final da consulta, e um campo de Observações.
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DtBirth { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtExit { get; set; }
        public string Description { get; set; }

        public bool CheckDate()
        {
            return DtStart > DtExit;
        }

        public void Update(Schedule schedule)
        {
            Name = schedule.Name;
            DtBirth = schedule.DtBirth;
            DtStart = schedule.DtStart;
            DtExit = schedule.DtExit;
            Description = schedule.Description;
        }

        public void IsValidDate(List<Schedule> allSchedules)
        {
            try
            {
                Func<Schedule,bool> existDateInRange = x =>  DtStart >= x.DtStart &&  DtStart <= x.DtExit ||  DtExit <= x.DtExit &&  DtExit >= x.DtStart;
                if (allSchedules.Any(existDateInRange) )
                    throw new InvalidOperationException("Já existe uma consulta nessa data");
            }
            catch (Exception ex)
            {
                //faz nada
                throw ex;
            }
        }
    }
}
