using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursLAN
{
    internal class Discipline
    {
        private string name;
        private int semester;
        private int hours;
        private string structure;
        private string reportType;

        public string Name { get => name; set => name = value; }
        public int Semester { get => semester; set => semester = value; }
        public int Hours { get => hours; set => hours = value; }
        public string Structure { get => structure; set => structure = value; }
        public string ReportType { get => reportType; set => reportType = value; }

        public Discipline(string name, int semester, int hours, string structure, string reportType)
        {
            Name = name;
            Semester = semester;
            Hours = hours;
            Structure = structure;
            ReportType = reportType;
        }

        public override string ToString()
        {
            return $"Дисциплина: {Name}, Семестр: {Semester}, Часы: {Hours}, Кафедра: {Structure}, Отчетность: {ReportType}";
        }

    }
}
