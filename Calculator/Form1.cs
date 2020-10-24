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
        public string action;
        public string number1;
        public bool flag; // Флаг, который используется для указания начала набора второго числа

        public Form1()
        {
            flag = false;
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e) // Кнопки цифр
        {
            if (flag == true) // После нажатия действия происходит стирание поля, а также обнуление флага
            {
                flag = false;
                textBox1.Text = "0";
            }

            Button A = (Button)sender; // Объявляем, что нажатой кнопкой становится А
            if (textBox1.Text=="0") // Заменяет 0 новыми данными при начале работы
            {
                textBox1.Text = A.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + A.Text; // К текущему тексту прибавляется текст, расположенный на нажатой кнопке
            }
            
        }

        private void button4_Click(object sender, EventArgs e) // Кнопка обнуления текста 
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e) // Кнопка простых действий
        {
            Button A = (Button)sender;
            action = A.Text; // Запись нажатой кнопки действия 
            number1 = textBox1.Text; // Запоминание числа, которое было заиписано 
            flag = true; // стирание поля перед началом второй цифры
        }

        private void button24_Click(object sender, EventArgs e) // Кнопка равно
        {
            double dNumber1, dNumber2, result;
            dNumber1 = Convert.ToDouble(number1); // форматирование в double числа для работы с ним
            dNumber2 = Convert.ToDouble(textBox1.Text); // вторая переменная - это число в текстбоксе
            if(action == "+") // Создание действий по принимаемым значениям для простых действий
            {
                result = dNumber1 + dNumber2;
            } else if (action == "-")
            {
                result = dNumber1 - dNumber2;
            } else if (action == "×")
            {
                result = dNumber1 * dNumber2;
            } else if (action == "÷")
            {
                result = dNumber1 / dNumber2;
            }
        }





        //b = Convert.ToDouble(textBox1.Text);
        //switch (sign)
        //{
        //    case '+': c = a + b;
        //        break;
        //    case '-': c = a - b;
        //        break;
        //    case '÷': c = a / b;
        //        break;
        //    case '×': c = a * b;
        //        break;
        //    case '√': c = Math.Sqrt(b);
        //        break;
        //    case '²': c = a * a;
        //        break;
        //}
        //textBox1.Text = c.ToString(); // Присваивание текстбоксу C в стринге


    }
}
