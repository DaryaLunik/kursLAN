using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursLAN
{
    internal class Program
    {
        //static string SpecialtyFile = "C:\\Users\\Hitech\\OneDrive\\Рабочий стол\\КУРСОВАЯ\\KOD\\txt\\Specialty.txt";
        //static string DepartmenFile = "C:\\Users\\kab-35-17\\Desktop\\ConsoleApp9\\txt\\Song.txt\\Department.txt";
        //static string DisciplineFile = "C:\\Users\\kab-35-17\\Desktop\\ConsoleApp9\\txt\\Tour.txt\\Discipline.txt";

        static void Main(string[] args)
        {
            Metodist metodist = new Metodist();

            while (true)
            {
                string i;
                Console.Write(@"============== МЕНЮ ==============
1. Ввести специальности;
2. Показать специальности;
3. Поиск лабораторных часов;
4. Удалить специальность;
----------------------------------;
5. Ввести кафедры;
6. Показать кафедры;
7. Семестровая нагрузка по спец.;
----------------------------------;
8. Ввести дисциплины;
9. Показать дисциплины;
10. Дисциплины по кафедре;
11. Мин/Макс продолжительность;
12. Экзамены/Зачёты/Курсовые;
==================================;
13. Выход;
==================================;
Введите номер действия: ");

                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        metodist.AddSpes(); // ввод специальностей
                        Console.Clear();
                        break;
                    case "2":
                        metodist.GetSpec();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "3":
                        metodist.PoiskLab();
                        Console.Read();
                        Console.Clear();
                        break;
                    //case 4:
                    //    metodist.RemoveSpecialty();
                    //    break;
                    //case 5:
                    //    metodist.InputDepartments();
                    //    break;
                    //case 6:
                    //    metodist.ShowDepartments();
                    //    break;
                    //case 7:
                    //    metodist.ShowSemesterLoadBySpecialty();
                    //    break;
                    //case 8:
                    //    metodist.InputDisciplines();
                    //    break;
                    //case 9:
                    //    metodist.ShowDisciplines();
                    //    break;
                    //case 10:
                    //    metodist.FindByDepartment();
                    //    break;
                    //case 11:
                    //    metodist.ShowMinMaxDuration();
                    //    break;
                    //case 12:
                    //    metodist.ShowExamAndCreditStatsByDepartment();
                    //    break;
                    case "13":
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine(); // отступ перед новым меню
            }
            Console.Read();
        }
     

    }
    
}
