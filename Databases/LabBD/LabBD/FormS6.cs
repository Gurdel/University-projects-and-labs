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
    public partial class FormS6 : Form
    {
        public FormS6(int fid)
        {
            InitializeComponent();
            s6TableAdapter.Fill(dSFilms.S6, fid);
        }

        private void FormS6_Load(object sender, EventArgs e)
        {

        }
    }
}
