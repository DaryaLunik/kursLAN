using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursLAN
{
    internal class Metodist
    {
        public List<Specialty> Svedeniya = new List<Specialty>();
        public List<Department> Departments = new List<Department>();
        public List<Discipline> Disciplines = new List<Discipline>();

        //public Metodist()
        //{
        //    Svedeniya = new List<Specialty>();
        //    Departments = new List<Department>();
        //    Disciplines = new List<Discipline>();
        //}
        //СПЕЦИАЛЬНОСТЬ



        public void VvodDannykh()
        {
            Console.Write("Сколько специальностей вы хотите ввести? ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Ошибка: введите корректное положительное число.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВвод специальности #{i + 1}:");

                Console.Write("ID (целое число): ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Неверный формат ID. Пропускаем эту специальность.");
                    continue;
                }

                Console.Write("Название: ");
                string name = Console.ReadLine();

                Console.Write("Специальность (код): ");
                string special = Console.ReadLine();

                Console.Write("Форма обучения (Очная/Очно-заочная/Заочная): ");
                string formstudy = Console.ReadLine();

                Console.Write("Количество лабораторных часов: ");
                if (!int.TryParse(Console.ReadLine(), out int laboratorywork))
                {
                    Console.WriteLine("Неверный формат часов. Пропускаем эту специальность.");
                    continue;
                }

                Specialty spec = new Specialty(id, name, special, formstudy, laboratorywork);
                Svedeniya.Add(spec);

                Console.WriteLine("✅ Добавлено: " + spec);
            }
        }



        public void VyvodDannykh()
        {
            Console.WriteLine("\n📋 Итоговый список специальностей:");
            foreach (var s in Svedeniya)
            {
                Console.WriteLine(" - " + s);
            }
        }

        public void PoiskLaboratornykhChasov()
        {
            Console.Write("\nВведите название специальности для поиска лабораторных часов: ");
            string zapros = Console.ReadLine();

            bool found = false;
            foreach (var spec in Svedeniya)
            {
                if (spec.Name.Equals(zapros, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Специальность: {spec.Name} — Лабораторных часов: {spec.Laboratorywork}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Специальность не найдена.");
            }
        }


        //КАФЕДРА

       

        public void InputDepartments()
        {
            Console.Write("Сколько специальностей вы хотите ввести? ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Ошибка: введите корреткное число");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВведите кафедру #{i + 1}");

                Console.Write("Название: ");
                string name = Console.ReadLine();

                Console.Write("Факультет: ");
                string faculty = Console.ReadLine();

                Console.Write("Телефон: ");
                string phone = Console.ReadLine();

                Console.Write("Специальность: ");
                string specialty = Console.ReadLine();

                Console.Write("Семестровая нагрузка кафедры: (hours): ");
                if (!int.TryParse(Console.ReadLine(), out int load))
                {
                    Console.WriteLine("Ошибка: введите корреткное число.\n");
                    continue;
                }

                Department dept = new Department(name, faculty, phone, specialty, load);
                Departments.Add(dept);
            }
        }

        public void ShowDepartments()
        {
            Console.WriteLine("\nDepartment Information:");
            foreach (var dept in Departments)
            {
                Console.WriteLine(dept);
            }
        }

        public void ShowSemesterLoadBySpecialty()
        {
            Console.Write("\nВведите специальность чтобы увидеть семестровую нагрузку: ");
            string input = Console.ReadLine();

            bool found = false;
            foreach (var dept in Departments)
            {
                if (dept.Specialty.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Department {dept.Name} (Faculty {dept.Faculty}) — Load: {dept.Semesterload} hrs");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Не найдено кафедры по введенной специальности.");
            }
        }

        //ДИСЦИПЛИНА

       

        public void InputDisciplines()
        {
            Console.Write("Сколько дисциплин вы хотите ввести? ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Некорректное число.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВвод дисциплины #{i + 1}");

                Console.Write("Название дисциплины: ");
                string name = Console.ReadLine();

                Console.Write("Семестр: ");
                if (!int.TryParse(Console.ReadLine(), out int semester))
                {
                    Console.WriteLine("Некорректный семестр. Пропускаем...\n");
                    continue;
                }

                Console.Write("Количество часов: ");
                if (!int.TryParse(Console.ReadLine(), out int hours))
                {
                    Console.WriteLine("Некорректное значение часов. Пропускаем...\n");
                    continue;
                }

                Console.Write("Кафедра (структура): ");
                string structure = Console.ReadLine();

                Console.Write("Вид отчетности (экзамен, зачет, курсовая и т.д.): ");
                string report = Console.ReadLine();

                Disciplines.Add(new Discipline(name, semester, hours, structure, report));
            }
        }

        public void ShowDisciplines()
        {
            Console.WriteLine("\nСписок всех дисциплин:");
            foreach (var d in Disciplines)
            {
                Console.WriteLine(d);
            }
        }

        public void FindByDepartment()
        {
            Console.Write("\nВведите название кафедры для поиска дисциплин: ");
            string dept = Console.ReadLine();

            var result = Disciplines
                .Where(d => d.Structure.Equals(dept, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("Нет дисциплин, преподаваемых данной кафедрой.");
                return;
            }

            Console.WriteLine($"\nДисциплины, которые ведёт кафедра \"{dept}\":");
            foreach (var d in result)
            {
                Console.WriteLine(d);
            }
        }

        public void ShowMinMaxDuration()
        {
            if (Disciplines.Count == 0)
            {
                Console.WriteLine("\nНет дисциплин для анализа.");
                return;
            }

            int minHours = Disciplines.Min(d => d.Hours);
            int maxHours = Disciplines.Max(d => d.Hours);

            Console.WriteLine($"\nДисциплины с минимальной продолжительностью занятий ({minHours} ч.):");
            foreach (var d in Disciplines.Where(d => d.Hours == minHours))
            {
                Console.WriteLine(d);
            }

            Console.WriteLine($"\nДисциплины с максимальной продолжительностью занятий ({maxHours} ч.):");
            foreach (var d in Disciplines.Where(d => d.Hours == maxHours))
            {
                Console.WriteLine(d);
            }
        }

        //ПОДСЧЕТ 

        public void ShowExamAndCreditStatsByDepartment()
        {
            if (Disciplines.Count == 0)
            {
                Console.WriteLine("Нет данных о дисциплинах.");
                return;
            }

            var stats = Disciplines
                .GroupBy(d => d.Structure)
                .Select(g => new
                {
                    Department = g.Key,
                    Exams = g.Count(d => d.ReportType.ToLower().Contains("экзамен")),
                    Credits = g.Count(d => d.ReportType.ToLower().Contains("зачет")),
                    Courseworks = g.Count(d => d.ReportType.ToLower().Contains("курсовая"))
                });

            Console.WriteLine("\nОбщее количество экзаменов, зачетов и курсовых по кафедрам:");
            foreach (var stat in stats)
            {
                Console.WriteLine($"Кафедра: {stat.Department} — Экзамены: {stat.Exams}, Зачёты: {stat.Credits}, Курсовые: {stat.Courseworks}");
            }
        }


        public void RemoveSpecialty()
        {
            Console.Write("\nВведите код специальности для удаления: ");
            string code = Console.ReadLine();
            var s = Svedeniya.Find(sp => sp.Special.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (s != null)
            {
                Svedeniya.Remove(s);
                Console.WriteLine("Удалено.");
            }
            else
            {
                Console.WriteLine("Специальность не найдена.");
            }
        }

        public void ShowSpecialties()
        {
            Console.WriteLine("\nСписок специальностей:");
            foreach (var s in Svedeniya)
            {
                Console.WriteLine(s);
            }
        }
    }
}
