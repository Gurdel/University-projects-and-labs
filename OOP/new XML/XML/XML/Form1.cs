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
using System.Xml.Xsl;

namespace XML
{
    public partial class Form1 : Form
    {
        string path = "";
        string xslPath = "convertToHTML.xsl";
        List<Phone> final = new List<Phone>();
        

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Output(List<Phone> final)
        {
            int i = 1;
            foreach(Phone p in final)
            {
                richTextBox1.AppendText(
                    i + ".\n" +
                    "Виробник: \t\t" + p.Firm + "\n" +
                    "Модель: \t\t\t" + p.Model + "\n" +
                    "Оперативна пам'ять: \t" + p.Ram + "\n" +
                    "Вбудована пам'ять: \t" + p.Rom + "\n" +
                    "Ємність акумулятора: \t" + p.Battery + "\n" +
                    "Процесор: \t\t" + p.Processor + "\n" +
                    "Встановлена ОС: \t\t" + p.Os + "\n" +
                    "Діагональ екрану: \t" + p.Diagonal + "\n" +
                    "Роздільна здатність: \t" + p.Resolution + "\n" +
                    "Тип матриці: \t\t" + p.Matrix + "\n"
                    );
                richTextBox1.AppendText("---------------------------------------------------------------------------------------------------------------\n");
                ++i;
            }
        }

        private Phone OurPhone()
        {
            string[] data = new string[10];
            if (checkBox1.Checked) data[0] = Convert.ToString(comboBox1.Text);
            if (checkBox2.Checked) data[1] = Convert.ToString(comboBox2.Text);
            if (checkBox3.Checked) data[2] = Convert.ToString(comboBox3.Text);
            if (checkBox4.Checked) data[3] = Convert.ToString(comboBox4.Text);
            if (checkBox5.Checked) data[4] = Convert.ToString(comboBox5.Text);
            if (checkBox6.Checked) data[5] = Convert.ToString(comboBox6.Text);
            if (checkBox7.Checked) data[6] = Convert.ToString(comboBox7.Text);
            if (checkBox8.Checked) data[7] = Convert.ToString(comboBox8.Text);
            if (checkBox9.Checked) data[8] = Convert.ToString(comboBox9.Text);
            if (checkBox10.Checked) data[9] = Convert.ToString(comboBox10.Text);

            Phone returnPhone = new Phone(data);
            return returnPhone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                richTextBox1.Clear();
                Phone phone = OurPhone();

                if (radioButton1.Checked)
                {
                    IStrategy CurrentStrategy = new LINQ(path);
                    final = CurrentStrategy.Algorithm(phone, path);
                    Output(final);
                }

                if (radioButton2.Checked)
                {
                    IStrategy CurrentStrategy = new SAX(path);
                    final = CurrentStrategy.Algorithm(phone, path);
                    Output(final);
                }

                if (radioButton3.Checked)
                {
                    IStrategy CurrentStrategy = new DOM(path);
                    final = CurrentStrategy.Algorithm(phone, path);
                    Output(final);
                }
            }
            else
            {
                MessageBox.Show("Select the file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;

            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            comboBox8.Text = null;
            comboBox9.Text = null;
            comboBox10.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                XslCompiledTransform xsl = new XslCompiledTransform();

                xsl.Load(xslPath);

                xsl.Transform(path, @"Phone.html");
                MessageBox.Show("HTML created");
            }
            else
            {
                MessageBox.Show("Select the file");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            path = openFileDialog1.FileName;

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            comboBox10.Items.Clear();
            richTextBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement xElement = doc.DocumentElement;
            XmlNodeList xNodes = xElement.SelectNodes("phone");

            foreach (XmlNode n in xNodes)
            {
                if (!comboBox1.Items.Contains(n.SelectSingleNode("@FIRM").Value)) comboBox1.Items.Add(n.SelectSingleNode("@FIRM").Value);
                if (!comboBox2.Items.Contains(n.SelectSingleNode("@MODEL").Value)) comboBox2.Items.Add(n.SelectSingleNode("@MODEL").Value);
                if (!comboBox3.Items.Contains(n.SelectSingleNode("@RAM").Value)) comboBox3.Items.Add(n.SelectSingleNode("@RAM").Value);
                if (!comboBox4.Items.Contains(n.SelectSingleNode("@ROM").Value)) comboBox4.Items.Add(n.SelectSingleNode("@ROM").Value);
                if (!comboBox5.Items.Contains(n.SelectSingleNode("@BATTERY").Value)) comboBox5.Items.Add(n.SelectSingleNode("@BATTERY").Value);
                if (!comboBox6.Items.Contains(n.SelectSingleNode("@PROCESSOR").Value)) comboBox6.Items.Add(n.SelectSingleNode("@PROCESSOR").Value);
                if (!comboBox7.Items.Contains(n.SelectSingleNode("@OS").Value)) comboBox7.Items.Add(n.SelectSingleNode("@OS").Value);
                if (!comboBox8.Items.Contains(n.SelectSingleNode("@DIAGONAL").Value)) comboBox8.Items.Add(n.SelectSingleNode("@DIAGONAL").Value);
                if (!comboBox9.Items.Contains(n.SelectSingleNode("@RESOLUTION").Value)) comboBox9.Items.Add(n.SelectSingleNode("@RESOLUTION").Value);
                if (!comboBox10.Items.Contains(n.SelectSingleNode("@MATRIX").Value)) comboBox10.Items.Add(n.SelectSingleNode("@MATRIX").Value);
            }
            
            Phone phone = OurPhone();
            IStrategy CurrentStrategy = new LINQ(path);
            final = CurrentStrategy.Algorithm(phone, path);
            Output(final);

            radioButton1.Checked = true;

            MessageBox.Show("File open");
        }

        private void changeXSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "(*.xsl)|*.xsl";
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            xslPath = openFileDialog2.FileName;
            MessageBox.Show("XSL style changed");
        }
    }
}
