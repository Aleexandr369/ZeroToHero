using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroToHero.@class;

namespace ZeroToHero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void Click_Convert(object sender, EventArgs e)
        {
            var obj = new ZeroToHero.@class.Convert();
            string language = comboBox1.Text;   // aici se citeste din chooseBox
            string lchoose = "no"; // limba care se transmite ca parametru pentru CultureInfo
            switch (language)
            {
                case "Rusa":
                    lchoose = "ru"; break;
                case "Engleza":
                    lchoose = "en-US"; break;
                case "Franceza":
                    lchoose = "fr-FR"; break;
                case "Germana":
                    lchoose = "de"; break;
                case "Spaniola":
                    lchoose = "es-ES"; break;
                default:
                    lchoose = "no"; break;
            }
            int number = 0;
            string result; // rezultatul obtinut in urma conversiei
            if (textBox1.Text != "")
            {
                if (Int32.TryParse(textBox1.Text, out number) != false && lchoose != "no")
                {
                    result = obj.mConvert(number, lchoose);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Number or language incorrect !");
                }
            }
        }
    }
}
