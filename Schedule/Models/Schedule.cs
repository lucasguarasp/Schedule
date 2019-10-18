using System;

namespace Schedule
{
    public class Schedule
    {
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
    }
}
