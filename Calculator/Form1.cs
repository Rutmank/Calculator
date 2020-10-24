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

        private void button22_Click(object sender, EventArgs e) // Кнопки цифр
        {
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
