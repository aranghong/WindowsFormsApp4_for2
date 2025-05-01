using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_for2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //foreach
            //int[] scores = { 85, 90, 78, 92, 88 };
            //int sum = 0;

            //foreach (int score in scores) 
            //{
            //    sum += score;
            //}

            //double avg = (double) sum / scores.Length;

            //Console.WriteLine("sum> " + sum);
            //Console.WriteLine("average> " + avg);
            //Console.WriteLine("==================");


            //int.TryParse() 활용하기


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            bool s = int.TryParse(input, out int num);
            Random r = new Random();


            if (s)  //변환 성공
            {
                int[] arr = new int[num];

                for (int i = 0; i < arr.Length; i++)
                {
                    int score = r.Next(1, 101);
                    arr[i] = score;
                }

                textBox2.Text = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    textBox2.Text += "학생" + (i+1) + "의 점수: " + arr[i] + "점 \r\n";
                }
            }
            else
            {
                textBox2.Text = "숫자로 입력해야지";
            }

        }
    }
}
