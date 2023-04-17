using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_OOP_third
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
        /// <summary>
        /// Кнопка, которая делает все дела в коде
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int reminder = 0; // Остаток от деления
            StringBuilder ost = new StringBuilder(); // строка, в которую будут записываться 0 и 1 
            bool isNum = Int32.TryParse(textBox1.Text, out var num); // Проверка, является ли введённый текст числом
            if (isNum)
            {
                if(num < 0)
                {
                    MessageBox.Show("Введите положительное число или 0"); // Если число отрицательное, то выводится этот текст
                    return;
                }
                else if (num == 0) // Если введён 0, то выведется 0
                {
                    label1.Text = $"Результат перевода: {num}";
                    return;
                }
                while (num > 0)
                {
                    while (num > 0)
                    {
                        reminder = num % 2; //Сохраняем остаток
                        num = num / 2; // делим число на 2
                        ost.Insert(0, reminder); // Добавляем строке остаток
                    }
                    label1.Text = $"Результат перевода: {ost}";
                }
            }
            else
            {
                MessageBox.Show("Введите число типа Int");
            }
        }
    }
}
