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
            string language = "empty"; // aici se citeste din chooseBox
            language = comboBox1.Text;
            string lchoose = "no"; // limba care se transmite ca parametru pentru CultureInfo
            if (language != "empty")
            {
                switch (language)
                {
                    case "Romana":
                        lchoose = "ro-RO"; break;
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
            }

            int number = int.Parse(textBox1.Text);
            var obj = new ZeroToHero.@class.Convert();
            string result; // rezultatul obtinut in urma conversiei
            result = obj.mconvert(number, lchoose);
            MessageBox.Show(result);
        }

        

    }
}
