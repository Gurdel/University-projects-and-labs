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
    public partial class FormS1 : Form
    {
        public FormS1()
        {
            InitializeComponent();
        }

        public FormS1(int pid)
        {
            InitializeComponent();
            s1TableAdapter.Fill(dSFilms.S1, pid);
        }

        private void FormS1_Load(object sender, EventArgs e)
        {

        }
    }
}
