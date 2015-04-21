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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            int number=0;
            if (textBox1.Text != "")
                if (obj.mIsDigitsOnly(textBox1.Text) != false)
                    number = int.Parse(textBox1.Text);
            string result; // rezultatul obtinut in urma conversiei

            if (number != 0 && lchoose != "no")
            {
                result = obj.mConvert(number, lchoose);
                MessageBox.Show(result);
            }
            else
                MessageBox.Show("Number or language incorrect !");
        }



    }
}
