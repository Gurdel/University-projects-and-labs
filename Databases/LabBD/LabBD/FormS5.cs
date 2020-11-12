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
    public partial class FormS5 : Form
    {
        public FormS5(int gid)
        {
            InitializeComponent();
            s5TableAdapter.Fill(dSFilms.S5, gid);
        }

        private void FormS5_Load(object sender, EventArgs e)
        {

        }
    }
}
