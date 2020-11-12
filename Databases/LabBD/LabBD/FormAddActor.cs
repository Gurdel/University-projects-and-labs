using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBD
{
    public partial class FormAddActor : Form
    {
        public FormAddActor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                int birth = (int)numericUpDown1.Value;
                int death = (int)numericUpDown2.Value;
                int count = 0;
                if (checkBox1.Checked)
                {
                    count = (int)queriesTableAdapter.SQCount_a_id_by_a_name_birth_InActors(name, birth);
                    if (count == 0)
                    {
                        queriesTableAdapter.InsertActor(name, birth, null);
                        MessageBox.Show("Додано");
                    }
                    else
                    {
                        MessageBox.Show("Такий актор уже є");
                    }
                }
                else
                {
                    if (death < birth)
                    {
                        MessageBox.Show("Некоректні роки");
                    }
                    else
                    {
                        count = (int)queriesTableAdapter.SQCount_a_id_by_a_name_birth_InActors(name, birth);
                        if (count == 0)
                        {
                            queriesTableAdapter.InsertActor(name, birth, death);
                            MessageBox.Show("Додано");
                        }
                        else
                        {
                            MessageBox.Show("Такий актор уже є");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка");
            }
        }
    }
}
