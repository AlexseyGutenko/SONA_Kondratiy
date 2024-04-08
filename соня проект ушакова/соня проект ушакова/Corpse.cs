using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace соня_проект_ушакова
{
    internal class Corpse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string CauseOfDeath { get; set; }

        public Corpse(int id, string name, int age, string gender, string causeOfDeath)
        {
            ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            CauseOfDeath = causeOfDeath;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Имя: {Name}, Возраст: {Age}, Пол: {Gender}, Причина смерти: {CauseOfDeath}";
        }
    }
}
