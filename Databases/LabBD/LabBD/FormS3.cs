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
    public partial class FormS3 : Form
    {
        public FormS3(int n)
        {
            InitializeComponent();
            s3TableAdapter.Fill(dSFilms.S3, n);
        }

        private void FormS3_Load(object sender, EventArgs e)
        {

        }
    }
}
