using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursLAN
{
    internal class Program
    {
        static string SpecialtyFile = "C:\\Users\\Hitech\\OneDrive\\Рабочий стол\\КУРСОВАЯ\\KOD\\txt\\Specialty.txt";
        static string DepartmenFile = "C:\\Users\\kab-35-17\\Desktop\\ConsoleApp9\\txt\\Song.txt\\Department.txt";
        static string DisciplineFile = "C:\\Users\\kab-35-17\\Desktop\\ConsoleApp9\\txt\\Tour.txt\\Discipline.txt";
        static void Main(string[] args)
        {
           

            Metodist metodist = new Metodist();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("============== МЕНЮ ==============");
                Console.WriteLine(" 1. Ввести специальности");
                Console.WriteLine(" 2. Показать специальности");
                Console.WriteLine(" 3. Поиск лабораторных часов");
                Console.WriteLine(" 4. Удалить специальность");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" 5. Ввести кафедры");
                Console.WriteLine(" 6. Показать кафедры");
                Console.WriteLine(" 7. Семестровая нагрузка по спец.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" 8. Ввести дисциплины");
                Console.WriteLine(" 9. Показать дисциплины");
                Console.WriteLine("10. Дисциплины по кафедре");
                Console.WriteLine("11. Мин/Макс продолжительность");
                Console.WriteLine("12. Экзамены/Зачёты/Курсовые");
                Console.WriteLine("==================================");
                Console.WriteLine("13. Выход");
                Console.WriteLine("==================================");
                Console.Write("Введите номер действия: ");

                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine(); // Отступ


                switch (choice)
                {
                    case 1:
                        metodist.VvodDannykh(); // ввод специальностей
                        break;
                    case 2:
                        metodist.VyvodDannykh();
                        break;
                    case 3:
                        metodist.PoiskLaboratornykhChasov();
                        break;
                    case 4:
                        metodist.RemoveSpecialty();
                        break;
                    case 5:
                        metodist.InputDepartments();
                        break;
                    case 6:
                        metodist.ShowDepartments();
                        break;
                    case 7:
                        metodist.ShowSemesterLoadBySpecialty();
                        break;
                    case 8:
                        metodist.InputDisciplines();
                        break;
                    case 9:
                        metodist.ShowDisciplines();
                        break;
                    case 10:
                        metodist.FindByDepartment();
                        break;
                    case 11:
                        metodist.ShowMinMaxDuration();
                        break;
                    case 12:
                        metodist.ShowExamAndCreditStatsByDepartment();
                        break;
                    case 13:
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
