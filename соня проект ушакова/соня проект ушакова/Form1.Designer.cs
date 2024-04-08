namespace соня_проект_ушакова
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.drop_courpse = new System.Windows.Forms.Button();
            this.Add_corpse = new System.Windows.Forms.Button();
            this.save_corpse = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.First_name = new System.Windows.Forms.TextBox();
            this.Last_name = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Cause_of_deat = new System.Windows.Forms.TextBox();
            this.DateTime_of_Dead = new System.Windows.Forms.TextBox();
            this.listBoxCorpses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // drop_courpse
            // 
            this.drop_courpse.Location = new System.Drawing.Point(109, 294);
            this.drop_courpse.Name = "drop_courpse";
            this.drop_courpse.Size = new System.Drawing.Size(75, 23);
            this.drop_courpse.TabIndex = 1;
            this.drop_courpse.Text = "удалить ";
            this.drop_courpse.UseVisualStyleBackColor = true;
            this.drop_courpse.Click += new System.EventHandler(this.drop_courpse_Click);
            // 
            // Add_corpse
            // 
            this.Add_corpse.Location = new System.Drawing.Point(12, 294);
            this.Add_corpse.Name = "Add_corpse";
            this.Add_corpse.Size = new System.Drawing.Size(75, 23);
            this.Add_corpse.TabIndex = 2;
            this.Add_corpse.Text = "добавить";
            this.Add_corpse.UseVisualStyleBackColor = true;
            this.Add_corpse.Click += new System.EventHandler(this.Add_corpse_Click);
            // 
            // save_corpse
            // 
            this.save_corpse.Location = new System.Drawing.Point(215, 294);
            this.save_corpse.Name = "save_corpse";
            this.save_corpse.Size = new System.Drawing.Size(75, 23);
            this.save_corpse.TabIndex = 3;
            this.save_corpse.Text = "сохранить";
            this.save_corpse.UseVisualStyleBackColor = true;
            this.save_corpse.Click += new System.EventHandler(this.save_corpse_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(336, 294);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 5;
            this.edit.Text = "изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "пол";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Причина смерти";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // First_name
            // 
            this.First_name.Location = new System.Drawing.Point(496, 21);
            this.First_name.Name = "First_name";
            this.First_name.Size = new System.Drawing.Size(100, 20);
            this.First_name.TabIndex = 11;
            this.First_name.TextChanged += new System.EventHandler(this.First_name_TextChanged);
            // 
            // Last_name
            // 
            this.Last_name.Location = new System.Drawing.Point(522, 47);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(100, 20);
            this.Last_name.TabIndex = 12;
            this.Last_name.TextChanged += new System.EventHandler(this.Last_name_TextChanged);
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(522, 74);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(100, 20);
            this.Patronymic.TabIndex = 13;
            this.Patronymic.TextChanged += new System.EventHandler(this.Patronymic_TextChanged);
            // 
            // Cause_of_deat
            // 
            this.Cause_of_deat.Location = new System.Drawing.Point(557, 100);
            this.Cause_of_deat.Name = "Cause_of_deat";
            this.Cause_of_deat.Size = new System.Drawing.Size(100, 20);
            this.Cause_of_deat.TabIndex = 14;
            this.Cause_of_deat.TextChanged += new System.EventHandler(this.Cause_of_deat_TextChanged);
            // 
            // DateTime_of_Dead
            // 
            this.DateTime_of_Dead.Location = new System.Drawing.Point(557, 128);
            this.DateTime_of_Dead.Name = "DateTime_of_Dead";
            this.DateTime_of_Dead.Size = new System.Drawing.Size(100, 20);
            this.DateTime_of_Dead.TabIndex = 15;
            this.DateTime_of_Dead.TextChanged += new System.EventHandler(this.DateTime_of_Dead_TextChanged);
            // 
            // listBoxCorpses
            // 
            this.listBoxCorpses.FormattingEnabled = true;
            this.listBoxCorpses.Location = new System.Drawing.Point(12, 25);
            this.listBoxCorpses.Name = "listBoxCorpses";
            this.listBoxCorpses.Size = new System.Drawing.Size(399, 251);
            this.listBoxCorpses.TabIndex = 16;
            this.listBoxCorpses.SelectedIndexChanged += new System.EventHandler(this.listBoxCorpses_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 329);
            this.Controls.Add(this.listBoxCorpses);
            this.Controls.Add(this.DateTime_of_Dead);
            this.Controls.Add(this.Cause_of_deat);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Last_name);
            this.Controls.Add(this.First_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.save_corpse);
            this.Controls.Add(this.Add_corpse);
            this.Controls.Add(this.drop_courpse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Морг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button drop_courpse;
        private System.Windows.Forms.Button Add_corpse;
        private System.Windows.Forms.Button save_corpse;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox First_name;
        private System.Windows.Forms.TextBox Last_name;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Cause_of_deat;
        private System.Windows.Forms.TextBox DateTime_of_Dead;
        private System.Windows.Forms.ListBox listBoxCorpses;
    }
}

