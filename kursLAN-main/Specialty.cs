using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursLAN
{
    internal class Specialty
    {
        private int id;
        private string name;
        private string special;
        private string formstudy;
        private int laboratorywork;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Special { get => special; set => special = value; }
        public string Formstudy { get => formstudy; set => formstudy = value; }
        public int Laboratorywork { get => laboratorywork; set => laboratorywork = value; }

        public Specialty(int id, string name, string special, string formstudy, int laboratorywork)
        {
            this.Id = id;
            this.Name = name;
            this.Special = special;
            this.Formstudy = formstudy;
            this.laboratorywork = laboratorywork;
        }
        public override string ToString()
        {
            return $"{id}: {Name} 《{Special}⟫, Форма обучения: {Formstudy}, Количество часов лабораторных работ: {Laboratorywork}";
        }
    }
}
