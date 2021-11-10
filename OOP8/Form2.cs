using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace OOP8
{
    public partial class Form2 : Form
    {
        //public static DataGridView view { get; set; }
        List<Person> student;
        public Form2()
        {
            student = new List<Person>();
            InitializeComponent();
        }
        public class Person
        {
            private string fio;
            private string group;
            private int asd;
            private int trpo;
            private int vvpi;
            private int rysski;
            private int oop;




            public string FIO
            {
                get { return fio; }
                set { fio = value; }

            }

            public Person(string f, string a, string b, string c, string d, string e, string g)
            {
                group = g;
                vvpi = Int32.Parse(d);
                asd = Int32.Parse(b);
                trpo = Int32.Parse(c);
                rysski = Int32.Parse(e);
                oop = Int32.Parse(a);

                fio = f;
            }

            //public bool Count()
            //{

            //    if (this.oop >= 3500) return true;
            //    return false;
            //}
            //public bool Count2()
            //{
            //    if (this.oop >= 2000 && this.oop < 3500) return true;
            //    return false;
            //}
            //public bool Count3()
            //{
            //    if (this.oop < 1) return true;
            //    return false;
            //}
            
        }
        private void Generate(int n)
        {
            List<string> names = new List<string>();
            Random rand = new Random();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (open.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            StreamReader stream = new StreamReader(open.FileName);
            //List<string> names = new List<string>();
            while (!stream.EndOfStream)
            {
                names.Add(stream.ReadLine());
                //names1.Add(stream.ReadLine());
            }
            //List<string> nick =
            //    "ПолосинН.В. БольшаковА.С. КулабуховА.Н ЗуевИ.М. ДорожкинаС.Ю. ФиллимоновР.С. СлюняевА.Ю ВасильевЕ.Г. ИcраeлянМ.Т ЦатурянС.К"
            //    .Split(' ').ToList();

            int[] ball = { 2, 3, 4, 5 };
            List<string> nick = "2019 2020 2021".Split(' ').ToList();



            for (int k = 0; k < n; k++)
            {
                dataGridView1[1, k].Value = String.Format("{0}",
                    nick[rand.Next(0, nick.Count)]
                    );
                //{
                //    dataGridView1[j, i].Value = group[rand.Next(0, group.Count())];

                //}

            }
            //int sum = 0;
            //int sr = 0;
            //for (int i = 0; i < ball.Length-1; i++)
            //{
            //    sum = sum + ball[i];
            //    sr = sum / ball.Length;

            //}
            Array.Sort(ball);

            for (int i = 0; i < n; i++)
            {

                dataGridView1[0, i].Value = String.Format("{0}",
                names[i]
                );
                for (int j = 2; j < 7; j++)
                {
                    dataGridView1[j, i].Value = ball[rand.Next(0, ball.Count())];
                }

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                dataGridView1.Rows.Add(n);

                Generate(n);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if(dataGridView1[3, i].Value.ToString().Contains(Convert.ToString(2)))
                    {
                        continue;

                        //textBox2.Text = "ошибка";
                    }
                    else
                    {
                        student.Add(new Person

                           (dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(),
                           dataGridView1[2, i].Value.ToString(), dataGridView1[3, i].Value.ToString(),
                           dataGridView1[4, i].Value.ToString(), dataGridView1[5, i].Value.ToString(), dataGridView1[6, i].Value.ToString()
                           ));
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string But9()
        {

            string[] s = { "Кулябака А.А", "2020", "4", "5", "4", "3", "3" };
            //string s1 = "Кулябака А.А";
            //string s2 = "2020";
            //string s4 = "4"; string s3 = "5";
            //string s5 = "4";
            //string s6 = "3";
            //string s7 = "3";
            string one = string.Join(Convert.ToString(' '), s);
            textBox3.Text += one;
            //dataGridView1.Rows.Add(one);
            return one;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            But9();
        }
    }
}
