using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGruszka
{
    public partial class Form1 : Form
    {
        private ColorDialog colorDialog;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                label1.Text = open.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bgcolor
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = Color.FromArgb(colorDialog1.Color.ToArgb()); 
            }
      
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            //font-style
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //save-pic
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
