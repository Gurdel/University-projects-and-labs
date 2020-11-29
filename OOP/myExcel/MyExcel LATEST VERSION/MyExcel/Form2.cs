using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace MyExcel
{
    public partial class Form2 : Form
    {
        string shortHelp = "У вкладці File ви можете зберегти свою таблицю або відкрити раніше збережену.\n" +
            "У вкладці Mode можна змінити, що буде відображатися в клітинках: Expression - вираз, Value - значення.\n" +
            "У вкладці Edit можна видалити або додати нові рядки й стовпчики.\n\n" +
            "Головне правило побудови виразу: змінні відокремлюються пробілами.\n" +
            "Наприклад:\n" +
            "А1 +34\n" +
            "А0 -23/12* В4\n" +
            "А0 * В0\n" +
            "not( A5 -3)\n\n" +
            "Арифметичні операції:\n" +
            "а+b - додавання\n" +
            "a-b - віднімання\n" +
            "a*b - множення\n" +
            "a/b - ділення\n" +
            "a^b - піднесення у степінь" +
            "a=b - рівність\n" +
            "a<b - менше\n" +
            "a>b - більше\n" +
            "a<=b - менше або дорівнює\n" +
            "a>=b - більше або дорівнює\n" +
            "a<>b - не дорівнює\n" +
            "not(a) - заперечення\n" +
            "Також є багато інших ф-цій. Синуси, косинуси, інтеграли...";


        public Form2()
        {
            InitializeComponent();
            richTextBox1.Text = shortHelp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
