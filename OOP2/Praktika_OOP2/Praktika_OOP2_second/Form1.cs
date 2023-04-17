using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_OOP2_second
{
    public partial class Form1 : Form
    {
        int number1, number2, number3, number4, number5 = 0;
        public static int NOD(int a, int b)//метод Евклида для двух чисел
        {
            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public static int NOD(int a, int b, int c)//метод Евклида для трёх чисел
        {
            int x = NOD(a, b);
            return NOD(x, c);
        }
        public static int NOD(int a, int b, int c, int d)//метод Евклида для четырёх чисел
        {
            int x = NOD(a, b, c);
            return NOD(x, d);
        }

        public static int NOD(int a, int b, int c, int d, int e)//метод Евклида для пяти чисел
        {
            int x = NOD(a, b, c, d);
            return NOD(x, e);
        }

        public static int NOD(params int[] rightData) //метод Евклида для списка чисел
        {
            int first = NOD(rightData[0], rightData[1]);
            if (rightData.Length > 2)
            {
                for (int n = 2; n < rightData.Length; n++)
                {
                    first = NOD(first, rightData[n]);
                }
                return first;
            }
            else return first;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox6.Text.Split(' ');
            int[] rightData = Array.ConvertAll(data, int.Parse);
            label2.Text = "NOD списка чисел: " + NOD(rightData).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool succes1 = Int32.TryParse(textBox1.Text, out number1); //метод TryParse
            bool succes2 = Int32.TryParse(textBox2.Text, out number2); //метод TryParse
            bool succes3 = Int32.TryParse(textBox3.Text, out number3); //метод TryParse
            if (succes1 && succes2 && succes3)
            {
                label1.Text = $"NOD трёх чисел: " + NOD(number1, number2, number3);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool succes1 = Int32.TryParse(textBox1.Text, out number1); //метод TryParse
            bool succes2 = Int32.TryParse(textBox2.Text, out number2); //метод TryParse
            bool succes3 = Int32.TryParse(textBox3.Text, out number3); //метод TryParse
            bool succes4 = Int32.TryParse(textBox4.Text, out number4); //метод TryParse
            if (succes1 && succes2 && succes3 && succes4)
            {
                label1.Text = $"NOD четырёх чисел: " + NOD(number1, number2, number3, number4);
            }
            else
            {
                MessageBox.Show("Введены неверные значения");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool succes1 = Int32.TryParse(textBox1.Text, out number1); //метод TryParse
            bool succes2 = Int32.TryParse(textBox2.Text, out number2); //метод TryParse
            bool succes3 = Int32.TryParse(textBox3.Text, out number3); //метод TryParse
            bool succes4 = Int32.TryParse(textBox4.Text, out number4); //метод TryParse
            bool succes5 = Int32.TryParse(textBox5.Text, out number5); //метод TryParse
            if (succes1 && succes2 && succes3 && succes4 && succes5)
            {
                label1.Text = $"NOD пяти чисел: " + NOD(number1, number2, number3, number4, number5);
            }
            else
            {
                MessageBox.Show("Введены неверные значения");
            }
        }
    }
}
