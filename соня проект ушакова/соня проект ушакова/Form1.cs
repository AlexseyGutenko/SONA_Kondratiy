using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace соня_проект_ушакова
{
    public partial class Form1 : Form
    {
      private  Morgue morg;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//открытие окна по центру экрана
            morg = new Morgue(40);
            listBoxCorpses.Items.Clear();
            Corpse[] corpses = morg.GetCorpses();
            for (int i = 0; i < corpses.Length; i++)
            {
                if (corpses[i] != null)
                {
                    listBoxCorpses.Items.Add(corpses[i].ToString());
                }
            }
        }
  
        private void Add_corpse_Click(object sender, EventArgs e)
        { 
            int id =int.Parse( First_name.Text);
            string last_name= Last_name.Text;
            int age = int.Parse(Patronymic.Text);
            string cause_of_deat=Cause_of_deat.Text;
            string datetime_of_dead = DateTime_of_Dead.Text;
            morg.AddCorpse(new Corpse(id, last_name, age, cause_of_deat, datetime_of_dead));
            listBoxCorpses.Items.Clear();
            Corpse[] corpses = morg.GetCorpses();
            for (int i = 0; i < corpses.Length; i++)
            {
                if (corpses[i] != null)
                {
                    listBoxCorpses.Items.Add(corpses[i].ToString());
                }
            }
            MessageBox.Show("Добавлен");
        }

        private void drop_courpse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(First_name.Text);
            morg.RemoveCorpse(id);
            listBoxCorpses.Items.Clear();
            Corpse[] corpses = morg.GetCorpses();
            for (int i = 0; i < corpses.Length; i++)
            {
                if (corpses[i] != null)
                {
                    listBoxCorpses.Items.Add(corpses[i].ToString());
                }
            }
        }

        private void save_corpse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                morg.SaveToFile(saveFileDialog.FileName);
                MessageBox.Show("Данные сохранены в файл");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(First_name.Text);
            string name = Last_name.Text;
            int age = Convert.ToInt32(Patronymic.Text);
            string gender = Cause_of_deat.Text;
            string causeOfDeath = DateTime_of_Dead.Text;
            morg.EditCorpse(id, name, age, gender, causeOfDeath);
            listBoxCorpses.Items.Clear();
            Corpse[] corpses = morg.GetCorpses();
            for (int i = 0; i < corpses.Length; i++)
            {
                if (corpses[i] != null)
                {
                    listBoxCorpses.Items.Add(corpses[i].ToString());
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void First_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cause_of_deat_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTime_of_Dead_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCorpses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
