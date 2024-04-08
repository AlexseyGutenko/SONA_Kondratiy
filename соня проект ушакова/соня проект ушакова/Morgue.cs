using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace соня_проект_ушакова
{
    internal class Morgue
    {
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
               MessageBox.Show("Морг переполнен, нельзя добавить новые трупы.");
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
                MessageBox.Show("Труп не найден");
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
                        writer.WriteLine($"ID: {corpse.ID}, Имя: {corpse.Name}, Возраст: {corpse.Age}, Пол: {corpse.Gender}, Причина смерти: {corpse.CauseOfDeath}");
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
