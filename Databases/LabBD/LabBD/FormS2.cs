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
    public partial class FormS2 : Form
    {
        public FormS2(int aid)
        {
            InitializeComponent();
            s2TableAdapter.Fill(dSFilms.S2, aid);
        }

        private void FormS2_Load(object sender, EventArgs e)
        {

        }
    }
}
