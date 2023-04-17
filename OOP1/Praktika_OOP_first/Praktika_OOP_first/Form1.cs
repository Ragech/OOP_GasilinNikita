using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Praktika_OOP_first
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /* 1) Неявное преобразование простых и ссылочных типов, в виде комментариев внести в программу таблицу неявных преобразований;
         * 
        byte: short, ushort, int, uint, long, ulong, float, double, decimal

        sbyte: short, int, long, float, double, decimal

        short: int, long, float, double, decimal

        ushort: int, uint, long, ulong, float, double, decimal

        int: long, float, double, decimal

        uint: long, ulong, float, double, decimal

        long: float, double, decimal

        ulong: float, double, decimal

        float: double

        char: ushort, int, uint, long, ulong, float, double, decimal 
        */
        // Для ссылочных типов неявное преобразование всегда предусмотрено из класса в любой из его прямых или косвенных базовых классов или интерфейсов.
        public class Base
        {
            public void Nums()
            {
                Console.WriteLine("123");
            }
        }
        public class Derived : Base
        {
            public void Leters()
            {
                Console.WriteLine("abc");
            }
        }
        private void first_taskN()
        {

            Derived d = new Derived();
            Base b = d;
        }

        /* 2) Явное преобразование простых и ссылочных типов, в виде комментариев внести в программу таблицу явных преобразований;

        sbyte: byte, ushort, uint, ulong, char

        byte: sbyte, char

        short: sbyte, byte, ushort, uint, ulong, char

        ushort: sbyte, byte, short, char

        int: sbyte, byte, short, ushort, uint, ulong, char

        uint: sbyte, byte, short, ushort, int, char

        */
        // Для ссылочных типов явное приведение является обязательным, если необходимо преобразовать базовый тип в производный тип.

        public class BaseYa
        {
            public void Nums()
            {
                Console.WriteLine("123");
            }
        }
        public class DerivedYa : BaseYa
        {
            public void Leters()
            {
                Console.WriteLine("abc");
            }
        }
        private void first_taskYa()
        {

            BaseYa d = new BaseYa();
            DerivedYa b = (DerivedYa) d;
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        // 3) Вызвать и обработать исключение преобразования типов; 
        class ThirdTaskBased { }                 // Создаём класс Animal с двумя производными классами: Reptile и Mammal
        class DerivedThirdTask1 : ThirdTaskBased { }
        class DerivedThirdTask2 : ThirdTaskBased { }

        private void third_task(ThirdTaskBased a)
        {
            try
            {
                DerivedThirdTask1 r = (DerivedThirdTask1) a;
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show($"Ошибка {e.Message}");
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // 4) Безопасное приведение ссылочных типов с помощью операторов as и is;

        // Оператор is
        private void fourth1_task()
        {
            int a = 25;
            int b = 33;
            float x = 3.4f; // пременным дожны быть присвоены какие-то значения

            // проверка, есть ли a типа int
            if (a is int) MessageBox.Show("Переменная a есть типа int."); // проверка, a это int или нет
            else MessageBox.Show("Переменная a не имеет типа int");

            // проверка, есть ли переменная b типа float
            if (b is float) MessageBox.Show("Переменная b имеет тип float"); // проверка, b это float или нет
            else MessageBox.Show("Переменная b не имеет тип float");

            // проверка, есть ли выражение типа double
            if ((2.5 + x) is double) MessageBox.Show("Выражение есть типа double"); // Значение , будет ли значение (2.5 + x) float или нет
            else MessageBox.Show("Выражение не имеет тип double");
        }

        // Оператор as

        // базовый класс
        class A
        {
            public int a;
        }

        // класс B наследует A
        class B : A
        {
            public int b;
        }

        // класс C наследует B
        class C : B
        {
            public int c;
        }

        private void fourth2_task()
        {
            // объекты классов A, B, C
            A objA = new A();
            B objB = new B();
            C objC = new C();

            // попробовать выполнить приведение типов, если возможно
            // в obj заносится результат приведения объекта obj
            objB = objA as B;

            if (objB == null)
                MessageBox.Show("Невозможно привести objA к типу B");
            else
                MessageBox.Show("Можно приводить objA к типу B");

            // еще одна попытка привести objC к типу B, результат в objB
            objB = objC as B;

            // вывод результата
            if (objB == null)
                MessageBox.Show("Невозможно привести objC к типу B");
            else
                MessageBox.Show("Можно приводить objC к типу B");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // 5) Пользовательское преобразование типов Implicit, Explicit;

        public class Distance
        {
            public int Feet { get; set; }
            public int Inches { get; set; }

            public Distance(int feet, int inches)
            {
                Feet = feet;
                Inches = inches;
            }

            public static implicit operator double(Distance d)
            {
                return (d.Feet * 12 + d.Inches) * 0.0254;
            }
        }

        public class Temperature
        {
            public double Celsius { get; set; }

            public Temperature(double celsius)
            {
                Celsius = celsius;
            }

            public static explicit operator Fahrenheit(Temperature t)
            {
                return new Fahrenheit(t.Celsius * 9 / 5 + 32);
            }
        }

        public class Fahrenheit
        {
            public double Value { get; set; }

            public Fahrenheit(double value)
            {
                Value = value;
            }
        }

        public void fifth_task()
        {
            // Использование неявного преобразования типа
            Distance distance = new Distance(5, 11);
            double meters = distance; // неявное преобразование типа Distance в double
            MessageBox.Show($"5 футов 11 дюймов в метрах: {meters}");

            // Использование явного преобразования типа
            Temperature temperature = new Temperature(20);
            Fahrenheit fahrenheit = (Fahrenheit)temperature; // явное преобразование типа Temperature в Fahrenheit
            MessageBox.Show($"20 градусов по Фаренгейту - это по Цельсию: {fahrenheit.Value}"); // выводит 68
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // 6) Преобразование с помощью класса Convert и преобразование строки в число с помощью методов Parse, TryParse класса System.Int32.
        private void sixth_task_str_TextChanged(object sender, EventArgs e)
        
        {

        }

        private void button_sixth_task_Click(object sender, EventArgs e)
        {
            string tt = textBox1.Text;
            sixth_task(tt);
        }

        public void sixth_task(string tt)
        {
            string str = "123";
            int a = Int32.Parse(str); // метод Parse
            MessageBox.Show($"Метод Parse работает: {a}");


            int number = 0;
            bool succes = Int32.TryParse(tt, out number); //метод TryParse
            if (succes)
            {
                MessageBox.Show($"{textBox1.Text} конвертировалось в {number}");
            }
            else
            {
                MessageBox.Show($"Не удалось конвертировать.");
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        // 7) Написать программу, позволяющую ввод в текстовое поле TextBox только символов, задающих правильный формат вещественного числа со знаком.

        private void button_seventh_task_Click(object sender, EventArgs e)
        {
            string tt = textBox2.Text;
            seventh_task();
        }

        public void seventh_task()
        {
            bool res_int = Int32.TryParse(textBox2.Text, out var num_int);
            bool res_double = Double.TryParse(textBox2.Text, out var num_bool);
            if (res_int) 
            {
                MessageBox.Show("Число введено неверно");
            }
            else if (res_double)
            {
                MessageBox.Show("Число введено верно");
            }
            else
            {
                MessageBox.Show("Введено не число");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            third_task(new DerivedThirdTask2()); //третье задание
            fourth1_task(); // четвёртое задание про оператор is
            fourth2_task(); // четвёртое задание про оператор as
            fifth_task(); // пятое задание
        }
    }
}