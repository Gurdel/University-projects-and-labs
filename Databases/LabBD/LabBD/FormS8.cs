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
    public partial class FormS8 : Form
    {
        public FormS8(int year)
        {
            InitializeComponent();
            s8TableAdapter.Fill(dSFilms.S8, year);
        }

        private void FormS8_Load(object sender, EventArgs e)
        {

        }
    }
}
