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
    public partial class FormChangeProducer : Form
    {
        public FormChangeProducer()
        {
            InitializeComponent();
        }

        private void FormChangeProducer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFilms.Producers' table. You can move, or remove it, as needed.
            this.producersTableAdapter.Fill(this.dSFilms.Producers);
            // TODO: This line of code loads data into the 'dSFilms.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.dSFilms.Films);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(comboBox1.Text);
            int pid = Convert.ToInt32(comboBox3.Text);
            queriesTableAdapter1.Update_f_producer_by_p_id_f_id_InFilms(pid, fid);
            MessageBox.Show("Змінено!");
        }
    }
}
