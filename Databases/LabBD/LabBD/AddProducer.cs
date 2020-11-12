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
    public partial class AddProducer : Form
    {
        public AddProducer()
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
                    count = (int)queriesTableAdapter.SQCount_p_id_by_p_name_birth_inProducers(name, birth);
                    if (count == 0)
                    {
                        queriesTableAdapter.InsertProducer(name, birth, null);
                        MessageBox.Show("Додано");
                    }
                    else
                    {
                        MessageBox.Show("Такий продюсер уже є");
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
                        count = (int)queriesTableAdapter.SQCount_p_id_by_p_name_birth_inProducers(name, birth);
                        if (count == 0)
                        {
                            queriesTableAdapter.InsertProducer(name, birth, death);
                            MessageBox.Show("Додано");
                        }
                        else
                        {
                            MessageBox.Show("Такий продюсер уже є");
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
