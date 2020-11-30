using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_6;

namespace Практическая_работа__7_Алешина_Дарья
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Алешина Дарья гр.ИСП-31" +
              "Вариант 6" +
              "Использовать класс Triad (тройка положительных чисел)." +
              "Определить производный класс Triangle с полями - сторонами." +
              "Определить методы вычисления углов и площади треугольника");
        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        //Создаем объект
        Triangle triang = new Triangle();

        //Кнопка Задать
        private void button3_Click(object sender, EventArgs e)
        {
            //Первое число
            if (Int32.TryParse(textBox1.Text, out int n1))
            {
                if (n1 >= 0)
                {
                    triang.num1 = n1;
                    textBox1.Text = triang.num1.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }

            //Второе число
            if (Int32.TryParse(textBox2.Text, out int n2))
            {
                if (n2 >= 0)
                {
                    triang.num2 = n2;
                    textBox2.Text = triang.num2.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }

            //Третье число
            if (Int32.TryParse(textBox3.Text, out int n3))
            {
                if (n3 >= 0)
                {
                    triang.num3 = n3;
                    textBox3.Text = triang.num3.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Рассчитать углы треугольника
        private void button4_Click(object sender, EventArgs e)
        {
            triang.Corner();

            if ((triang.num1 + triang.num2 > triang.num3) && (triang.num2 + triang.num3 > triang.num1) && (triang.num1 + triang.num3 > triang.num2))
            {
                textBox4.Text = triang.angle1.ToString();
                textBox5.Text = triang.angle2.ToString();
                textBox6.Text = triang.angle3.ToString();
            }
            else
            {
                MessageBox.Show("Треугольник с такими сторонами не существует");
            }
        }

        //Кнопка Рассчитать для площади треугольника
        private void button1_Click(object sender, EventArgs e)
        {
            triang.Ar();
            textBox7.Text = triang.Ar().ToString();
        }
    }
}
