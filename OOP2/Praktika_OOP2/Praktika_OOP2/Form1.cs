using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textb1 = textBox1.Text;
            string textb2 = textBox2.Text;
            int number1, number2 = 0;
            bool succes1 = Int32.TryParse(textb1, out number1); //метод TryParse
            bool succes2 = Int32.TryParse(textb2, out number2); //метод TryParse
            if(succes1 && succes2)
            {
                label1.Text = $"NOD этих двух чисел: " + NOD1.NOD(number1, number2);
            }
            else if(succes1 == false && succes2) 
            {
                MessageBox.Show("Введите число типа int в TextBox1"); return;
            }
            else if (succes1 && succes2 == false)
            {
                MessageBox.Show("Введите число типа int в TextBox2"); return;
            }
            else
            {
                MessageBox.Show("Введите число типа int в TextBox1 и TextBox2"); return;

            }
        }
    }
}
