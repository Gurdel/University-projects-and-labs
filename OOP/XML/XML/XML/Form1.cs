using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XML
{
    public partial class Form1 : Form
    {
        public string path = "table.xml";
        XmlDocument doc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            doc.Load(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
