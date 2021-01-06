using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace max_min
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            // объявляю массив с заданной длиной
            float[] myArray = new float[10];
            string s = " ";
            // объявляю метод рандом
            Random rand = new Random();

            float my_max = -100;
            float my_min = 100;
            label1.Text = " ";
            // цикл с условием
            for (int i = 0; i < myArray.Length; i++)
            {
                // присваиваю итому элементу рандомное значение
                myArray[i] = rand.Next(-50, 50);

                if (myArray[i] > my_max)
                {
                    my_max = myArray[i];
                }
                if (myArray[i] < my_min)
                {
                    my_min = myArray[i];
                }
                




            }

            for (int i = 0; i < myArray.Length; i++)
            {
                s += myArray[i] + "\n";
            }
                
            label2.Text = s;

            string str1 = my_max.ToString();
            string str2 = my_min.ToString(); 
            label1.Text += label1.Text + "максимальное значение:  " + str1 + "\n минимальное значение:  " + str2;

        }
    }
}
