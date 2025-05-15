using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursLAN
{
    internal class Department
    {
        private string name;
        private string faculty;
        private string phone;
        private string specialty;
        private int semesterload;// Семестровая нагрузка, часы

        public string Name { get => name; set => name = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public int Semesterload { get => semesterload; set => semesterload = value; }

        public Department(string name, string faculty, string phone, string specialty, int semesterload)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.Phone = phone;
            this.Specialty = specialty;
            this.Semesterload = semesterload;
        }

        public override string ToString()
        {
            return $"Кафедра: {Name}, Факультет: {Faculty}, Телефон: {Phone}, Специальность: {Specialty}, Семестровая нагрузка кафедры по специальности: {Semesterload} hrs";
        }
    }
}
