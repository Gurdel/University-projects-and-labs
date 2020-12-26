using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace itLab1
{
    public partial class FormOpenFile : Form
    {
        public FormOpenFile()
        {
            InitializeComponent();
        }


        public FormOpenFile(string path)
        {
            InitializeComponent();
            this.Text = path;
            StreamReader sr = new StreamReader(path);
            string s = sr.ReadToEnd();
            sr.Close();
            richTextBox1.Text = s;
        }
    }
}
