using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text; // К текущему тексту прибавляется текст, расположенный на нажатой кнопке
        }

        double a = 0, b = 0, c = 0;

        char sign = '+';

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text); // Конвертация текста в double 
            sign = (sender as Button).Text[0]; // Присваивание первого символа кнопки
            textBox1.Clear(); // Очистка поля
        }

        private void button24_Click(object sender, EventArgs e) // Знак равенства 
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (sign)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '÷': c = a / b;
                    break;
                case '×': c = a * b;
                    break;
                case '√': c = Math.Sqrt(a);
                    break;
                case '²': c = a * a;
                    break;
            }
            textBox1.Text = c.ToString(); // Присваивание текстбоксу C в стринге
        }


    }
}
