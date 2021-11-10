using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            //string s = /*"\nФамилия: Кулабухов" + "\n Группа: 2020" + "\n ООП: 4" + "\n ТРПО: 5" + "\n АСД: 4" + "\n ВВПИ: 3" + "\n Русский: 3"*/;
            //string exp = " ";
            //var f = new MainTable(s);
            //string res = f.Kislyakov11();
            //Form1 c = new Form1();
            Form1 k = new Form1();
            string res2 = k.But9();
            string[] s = { "Кулябака А.А", "2020", "4", "5", "4", "3", "3" };
            string one = string.Join(Convert.ToString(' '), s);
            //string res = c.button51();
            //Assert.AreEqual(exp, res);
            Assert.AreEqual(one, res2);


        }
    }
}
