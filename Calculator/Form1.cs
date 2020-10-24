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

            result = 0;
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
            action = "=";
            flag = true;
            textBox1.Text = result.ToString(); // Вывод на экран результата в стринг
        }

        private void button7_Click(object sender, EventArgs e) // Корень
        {
            double dNumber, result; // переменные только для метода

            dNumber = Convert.ToDouble(textBox1.Text); // вывод на экран
            result = Math.Sqrt(dNumber); // Функция корня
            textBox1.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e) // квадрат числа
        {
            double dNumber, result; 

            dNumber = Convert.ToDouble(textBox1.Text); 
            result = Math.Pow(dNumber, 2);  // функция возведения в степень. ( можно писать любую )
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e) // Плюс минус ( замена знака на противоположный )
        {
            double dNumber, result;

            dNumber = Convert.ToDouble(textBox1.Text);
            result = -dNumber;  
            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e) // Точка
        {
            if (!textBox1.Text.Contains(",")) // проверка на наличие точки уже в боксе
            {
                textBox1.Text = textBox1.Text + ","; // Просто возможность добавить точку
            }
        }
    }
}
