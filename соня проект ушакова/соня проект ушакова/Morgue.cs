using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace соня_проект_ушакова
{
    internal class Morgue
    {
        /*private Corpse[] corpses;
        private int count;

        public Morgue(int capacity)
        {
            corpses = new Corpse[capacity];
            count = 0;
        }

        public void addCorpse(Corpse corpse)
        {
            corpses[count] = corpse;
            count++;
        }
        *
        public void DisplayCorpses()
        {
            for (int i = 0; i < corpses.Length; i++)
            {
                Corpse currentCorpse = corpses[i];
                if (currentCorpse != null)
                {
                    
                  //  Console.WriteLine(i + 1);
                    currentCorpse.DisplayData();
                }
            }
        }
        public void EditCorpse(int index, string newFirstName, string newLastName, string newPatronymic, string newCauseOfDeath, string newDateTimeOfDead)
        {
            Corpse corpse = corpses[index];
            if (corpse != null)
            {
                corpse.EditFirstName(newFirstName);
                corpse.EditLastName(newLastName);
                corpse.EditPatronymic(newPatronymic);
                corpse.EditCauseOfDeath(newCauseOfDeath);
                corpse.EditDateTimeOfDead(newDateTimeOfDead);
            }
        }
        public void DeleteCorpse(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    corpses[i] = corpses[i + 1];
                }
                count--;
                corpses[count] = null;
            }
        }

        public void SaveAllCorpsesToFile()
        {
            foreach (Corpse corpse in corpses)
            {
                if (corpse != null)
                {
                    string savePath = @"C:\Users\guten\Desktop";
                    corpse.SaveToFile(savePath);
                }
            }
        }*/
        private Corpse[] corpses;
        private int count;

        public Morgue(int capacity)
        {
            corpses = new Corpse[capacity];
            count = 0;
        }

        public void AddCorpse(Corpse corpse)
        {
            if (count < corpses.Length)
            {
                corpses[count] = corpse;
                count++;
            }
            else
            {
                Console.WriteLine("Morgue is full, cannot add more corpses");
            }
        }

        public void RemoveCorpse(int id)
        {
            int index = Array.FindIndex(corpses, c => c?.ID == id);
            if (index != -1)
            {
                corpses[index] = null;
                count--;
            }
            else
            {
                Console.WriteLine("Corpse not found");
            }
        }

        public Corpse[] GetCorpses()
        {
            return corpses;
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Corpse corpse in corpses)
                {
                    if (corpse != null)
                    {
                        writer.WriteLine($"ID: {corpse.ID}, Name: {corpse.Name}, Age: {corpse.Age}, Gender: {corpse.Gender}, Cause of Death: {corpse.CauseOfDeath}");
                    }
                }
            }
        }
        public void EditCorpse(int id, string name, int age, string gender, string causeOfDeath)
        {
            for (int i = 0; i < corpses.Length; i++)
            {
                if (corpses[i]?.ID == id)
                {
                    corpses[i].Name = name;
                    corpses[i].Age = age;
                    corpses[i].Gender = gender;
                    corpses[i].CauseOfDeath = causeOfDeath;
                }
            }
        }
    }
}
