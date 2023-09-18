using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaGruszka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double cena = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Bekon
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Boczek
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Szynka
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Kukurydza
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Papryka
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Czosnek
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Ogórek 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Czosnkowy
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Słodki
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //Śmietanowy
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mięso
            if (radioButton1.Checked)
            {
                cena += 5;
            }
            if (radioButton2.Checked)
            {
                cena += 5;
            }
            if (radioButton3.Checked)
            {
                cena += 5;
            }
            if (radioButton4.Checked)
            {
                cena += 5;
            }

            //Warzywa
            if (checkBox1.Checked)
            {
                cena += 7;
            }
            if (checkBox2.Checked)
            {
                cena += 7;
            }
            if (checkBox3.Checked)
            {
                cena += 7;
            }
            if (checkBox4.Checked)
            {
                cena += 7;
            }
            //sosy
            if (radioButton5.Checked)
            {
                cena += 3;
            }
            if (radioButton6.Checked)
            {
                cena += 3;
            }
            if (radioButton7.Checked)
            {
                cena += 3;
            }


            //mnożnik rozmiaru
            if (comboBox1.Text == "Mała")
            {
                cena *= 1;
            }
            else if (comboBox1.Text == "Średnia")
            {
                cena *= 1.5;
            }
            else if (comboBox1.Text == "Duża")
            {
                cena *= 1.75;
            }
            else if (comboBox1.Text == "XXL")
            {
                cena *= 2;
            }

            label2.Text = $"Twoja cena wynosi: {cena}";

        }
    }
}
