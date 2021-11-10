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
    public partial class Form1 : Form
    {
        Form2 frm2;
        List<Person> student;
        public Form1()
        {
            student = new List<Person>();
            InitializeComponent();
        }
        public class GG
        {

        }
        public class Button
        {

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

            public bool Count()
            {
                
                if (this.oop >2 && this.vvpi > 2 && this.asd > 2 && this.trpo > 2 && this.rysski > 2) return true;
                return false;
            }

            public bool Count2()
            {
                if (this.oop >= 2000 && this.oop < 3500) return true;
                return false;
            }
            public bool Count3()
            {
                if (this.oop < 1) return true;
                return false;
            }
            
        }
        List<string> names = new List<string>();
        //List<string> group = new List<string>();

        private void Generate(int n)
        {
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
            
            int[] ball = { 2,3,4,5 };
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;

                button1.Enabled = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    student.Add(new Person
                         (dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(),
                         dataGridView1[2, i].Value.ToString(), dataGridView1[3, i].Value.ToString(),
                         dataGridView1[4, i].Value.ToString(), dataGridView1[5, i].Value.ToString(), dataGridView1[6, i].Value.ToString()
                         ));
                    if (dataGridView1[0, i] != null)
                    { count++; }
                    textBox3.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Queue<string> students = new Queue<string>();
            foreach (Person z in student)
            {
                if (z.Count())
                {
                    students.Enqueue(z.FIO);
                }
            }
            foreach (string temp in students)
            {
                comboBox1.Items.Add(temp);
            }
            Queue<string> students2 = new Queue<string>();
            foreach (Person z in student)
            {
                if (z.Count2())
                {
                    students2.Enqueue(z.FIO);
                }
            }
            foreach (string temp in students2)
            {
                //comboBox2.Items.Add(temp);
            }
            Queue<string> students3 = new Queue<string>();
            foreach (Person z in student)
            {
                if (z.Count3())
                {
                    students3.Enqueue(z.FIO);
                }
            }
            foreach (string temp in students3)
            {
                //comboBox3.Items.Add(temp);
            }
        }
        public void Button4()
        {
            string[] a = new string[dataGridView1.RowCount];
            string[] b = new string[dataGridView1.RowCount];
            string[] c = new string[dataGridView1.RowCount];
            string[] d = new string[dataGridView1.RowCount];
            string[] g = new string[dataGridView1.RowCount];
            string[] f = new string[dataGridView1.RowCount];
            string[] k = new string[dataGridView1.RowCount];
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                a[i] = dataGridView1[0, i].Value.ToString();
                b[i] = dataGridView1[1, i].Value.ToString();
                c[i] = dataGridView1[2, i].Value.ToString();
                d[i] = dataGridView1[3, i].Value.ToString();
                g[i] = dataGridView1[4, i].Value.ToString();
                f[i] = dataGridView1[5, i].Value.ToString();
                k[i] = dataGridView1[6, i].Value.ToString();
                int count = dataGridView1.DisplayedRowCount(true);
                if (a[i].Equals(textBox2.Text))
                {
                    richTextBox1.Text += "\t\nФИО:   " + a[i] + "\t Группа:   " + b[i] + "\t ООП:   " + c[i] + "\t ТРПО:   " + d[i] + "\t АСД:   " + g[i] + "\t ВВПИ:   " + f[i] + "\t Русский:   " + k[i];
                    //richTextBox1.Text += "\nФамилия: Кулабухов" + "\n Группа: 2020" + "\n ООП: 4" + "\n ТРПО: 5" + "\n АСД: 4" + "\n ВВПИ: 3" + "\n Русский: 3";
                }

                 
                

            }

            //return richTextBox1.Text += "\nФамилия: Кулабухов" + "\n Группа: 2020" + "\n ООП: 4" + "\n ТРПО: 5" + "\n АСД: 4" + "\n ВВПИ: 3" + "\n Русский: 3";
        }
        public string Button6()
        {
            Convert.ToString(dataGridView1.Rows.Add("Кулябака А.А", "2020", "4", "5", "4", "3", "3"));
           
            return Convert.ToString(dataGridView1.Rows.Add());

        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button4();
        }
        

        private void сериализироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < names.Count(); i++)
            {
                list.Add(names[i].ToString());
            }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Serialize file(*.bin)|*.bin|Все файлы(*.*)|*.*";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            FileStream stream = new FileStream(save.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, list);
            stream.Close();
        }

        private void сохранитьВДвоичномВидеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            List<string> list = new List<string>();
            StreamWriter write = new StreamWriter(save.FileName);
            StringBuilder sb = new StringBuilder();
            string combindedString = string.Join(",", names.ToArray());
            string str = combindedString;
            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(str))
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(' ');
            string binaryStr = sb.ToString();
            list.Add(Convert.ToString(binaryStr));
            foreach (var item in list)
            {
                write.Write(item);
            }
            write.Close();
        }

        private void синхронизироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            List<string> list = new List<string>();
            StreamWriter write = new StreamWriter(save.FileName);
            //StringBuilder sb = new StringBuilder();
            //string combindedString = string.Join(",", names.ToArray());
            //string str = combindedString;
            //foreach (byte b in System.Text.Encoding.Unicode.GetBytes(str))
            //    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(' ');
            //string binaryStr = sb.ToString();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                
                dataGridView1[0, i].Value = String.Format("{0}",
                    names[i]
                    );
                list.Add("\t\nФИО: " + Convert.ToString(dataGridView1[0,i].Value) + "\t\nСтипендия:   " + Convert.ToString(dataGridView1[1, i].Value));
            }
            foreach (var item in list)
            {
                write.Write(item);
            }
            write.Close();
        }

        public string button51()
        {
            //for (int i = 0; i < dataGridView1.RowCount ; i++)
            //{
            int a = dataGridView1.CurrentRow.Index;

            dataGridView1.Rows.Remove(dataGridView1.Rows[a]); 
               
            //}
            return " # ";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button51();
            //for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //{

            //    int a = dataGridView1.CurrentRow.Index;
            //    //if (Convert.ToString(dataGridView1[1, i]) > Convert.ToString(2) || Convert.ToString(dataGridView1[2, i]) > Convert.ToString(2) || Convert.ToString(dataGridView1[3, i]) > Convert.ToString(2) || Convert.ToString(dataGridView1[4, i]) > Convert.ToString(2) || Convert.ToString(dataGridView1[5, i]) > Convert.ToString(2)
            //    dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button6();
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
        private void button7_Click(object sender, EventArgs e)
        {
            //    bool found = false;
            //int nameCount = 1;
            //if (dataGridView1 != null)
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Cells[0].Value != null && row.Cells[0].Value == Column2)
            //        {
            //            found = true;
            //            row.Cells[1].Value = Convert.ToInt32(row.Cells[1].Value) + 1;
            //        }
            //    }
            //    if (!found)
            //    {
            //        dataGridView2.Rows.Add(new object[] { Column2, nameCount });
            //    }
            //}
            var list = dataGridView1.Rows.OfType<DataGridViewRow>()
                    .Select(x => x.Cells["Column2"].Value);

            var q = from x in list
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Column2 = g.Key, Count = count };

            foreach (var item in q)
            {
                dataGridView2.Rows.Add(new object[] { item.Column2, item.Count });
            }
            var list1 = dataGridView1.Rows.OfType<DataGridViewRow>()
                    .Select(x1 => x1.Cells["Column3"].Value);

            var q1 = from x1 in list1
                    group x1 by x1 into g1
                    let count1 = g1.Count()
                    orderby count1 descending
                    select new { Column3 = g1.Key, Count1 = count1 };

            foreach (var item1 in q1)
            {
                dataGridView3.Rows.Add(new object[] { item1.Column3, item1.Count1 });
            }
            var list2 = dataGridView1.Rows.OfType<DataGridViewRow>()
                    .Select(x2 => x2.Cells["Column4"].Value);

            var q2 = from x2 in list2
                     group x2 by x2 into g2
                     let count2 = g2.Count()
                     orderby count2 descending
                     select new { Column4 = g2.Key, Count2 = count2 };

            foreach (var item2 in q2)
            {
                dataGridView4.Rows.Add(new object[] { item2.Column4, item2.Count2 });
            }
            var list3 = dataGridView1.Rows.OfType<DataGridViewRow>()
                    .Select(x3 => x3.Cells["Column5"].Value);

            var q3 = from x3 in list3
                    group x3 by x3 into g3
                    let count3 = g3.Count()
                    orderby count3 descending
                    select new { Column5 = g3.Key, Count3 = count3 };

            foreach (var item3 in q3)
            {
                dataGridView5.Rows.Add(new object[] { item3.Column5, item3.Count3 });
            }
            var list4 = dataGridView1.Rows.OfType<DataGridViewRow>()
                    .Select(x4 => x4.Cells["Column6"].Value);

            var q4 = from x4 in list4
                    group x4 by x4 into g4
                    let count4 = g4.Count()
                    orderby count4 descending
                    select new { Column6 = g4.Key, Count4 = count4 };

            foreach (var item4 in q4)
            {
                dataGridView6.Rows.Add(new object[] { item4.Column6, item4.Count4 });
            }
            //bool found = false;
            //int nameCount = 1;
            //if (dataGridView1 != null)
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == )
            //        {
            //            found = true;
            //            row.Cells[1].Value = Convert.ToInt32(row.Cells[1].Value) + 1;
            //        }
            //    }
            //    if (!found)
            //    {
            //        dataGridView1.Rows.Add(new object[] { Матан, nameCount });
            //    }
            //}
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    //Form2.view.Rows.Add(row.Cells["Column1"].Value = String.Format("{0}", dataGridView1.Rows));
            //    Form2.view.Rows.Add(row.Cells["Column2"].Value);
            //    Form2.view.Rows.Add(row.Cells["Column3"].Value);
            //    Form2.view.Rows.Add(row.Cells["Column4"].Value);
            //    Form2.view.Rows.Add(row.Cells["Column5"].Value);
            //    Form2.view.Rows.Add(row.Cells["Column6"].Value);
            //    Form2.view.Rows.Add(row.Cells["Column7"].Value);
              
            //}
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        public string But8()
        {

            string[] s = { "Кулябака А.А", "2020", "4", "5", "4", "3", "3" };
            //string s1 = "Кулябака А.А";
            //string s2 = "2020";
            //string s4 = "4"; string s3 = "5";
            //string s5 = "4";
            //string s6 = "3";
            //string s7 = "3";
            string one = string.Join(Convert.ToString(' '), s);
            return one;
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
           
            //But8();

            frm2 = new Form2();
            frm2.Show();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
