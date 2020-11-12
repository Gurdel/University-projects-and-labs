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
    public partial class FormS4 : Form
    {
        public FormS4(int year)
        {
            InitializeComponent();
            s4TableAdapter.Fill(dSFilms.S4, year);
        }

        private void FormS4_Load(object sender, EventArgs e)
        {

        }
    }
}
