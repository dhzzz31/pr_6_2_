using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значений из текстового поля textBox
            double x = Convert.ToDouble(textBox1.Text);
            double accuracy = Convert.ToDouble(textBox2.Text);

            double sum = 0;
            double slog = x;
            int colslog = 1;
            // Выполняеются расчеты суммы ряда, пока значение слагаемого больше или равно заданной точности
            while (Math.Abs(slog) >= accuracy)
            {
                // Добавляем текущее слагаемое к общей сумме
                sum += slog;
                // Увеличиваем количество слагаемых на 1
                colslog++;
                // Вычисляем новое значение слагаемого
                slog = x / colslog;
            }
           // Выводится результат
            label4.Text = "sum = " + sum.ToString();
            label5.Text = "quanity" + colslog.ToString();
        }

     
    }
}
