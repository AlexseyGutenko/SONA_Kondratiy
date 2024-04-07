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
        /* private string First_name;
         private string Last_name;
         private string Patronymic;
         private string Cause_of_deat;
         private string DateTime_of_Dead;

         public Corpse(string first_name, string last_name, string patronymic, string cause_of_death, string date_time_of_dead)
         {
             First_name = first_name;
             Last_name = last_name;
             Patronymic = patronymic;
             Cause_of_deat = cause_of_death;
             DateTime_of_Dead = date_time_of_dead;
         }

         public void EditFirstName(string newFirstName)
         {
             First_name = newFirstName;
         }

         public void EditLastName(string newLastName)
         {
             Last_name = newLastName;
         }

         public void EditPatronymic(string newPatronymic)
         {
             Patronymic = newPatronymic;
         }

         public void EditCauseOfDeath(string newCauseOfDeath)
         {
             Cause_of_deat = newCauseOfDeath;
         }

         public void EditDateTimeOfDead(string newDateTimeOfDead)
         {
             DateTime_of_Dead = newDateTimeOfDead;
         }


         public string DisplayData()
         {
             return ("Name: " + First_name + " " + Last_name
                 + "Patronymic: " + Patronymic+ "Cause of Death: " + Cause_of_deat
                 + "Date and Time of Death: " + DateTime_of_Dead);
         }
         public string SaveToFile(string path)
         {
             string fileName = $"{path}\\corpse_{First_name}_{Last_name}.txt";
             using (StreamWriter sw = new StreamWriter(fileName))
             {
                 sw.WriteLine("Name: " + First_name + " " + Last_name);
                 sw.WriteLine("Patronymic: " + Patronymic);
                 sw.WriteLine("Cause of Death: " + Cause_of_deat);
                 sw.WriteLine("Date and Time of Death: " + DateTime_of_Dead);
                 sw.WriteLine();
             }
             return ($"Corpse information has been saved to file: {fileName}");
         }*/
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
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Gender: {Gender}, Cause of Death: {CauseOfDeath}";
        }
    }
}
