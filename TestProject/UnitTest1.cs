using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using МодТест;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int val = 100;
            string expected = "100";

            MyInt lol = new MyInt();
            string answer = lol.ToStr(val);


            Assert.AreEqual(expected, answer);
        }

        [TestMethod]
        public void TestMethod2() //проверка на max
        {
            MyInt dde = new MyInt(121);
            MyInt tte = new MyInt(323);
            dde = dde.abs().Max(tte.abs());
            Assert.AreEqual(dde.Value, tte.Value);
        }

        [TestMethod]
        public void TestMethod3() //проверка на min
        {
            MyInt dde = new MyInt(100);
            MyInt tte = new MyInt(20);
            dde = dde.Min(tte);
            Assert.AreEqual(dde, tte);
        }

        [TestMethod]
        public void TestMethod4()//проверка на abs
        {
            MyInt dde = new MyInt(-100);
            MyInt tte = new MyInt(100);
            dde = dde.abs();
            Assert.AreEqual(dde.Value, tte.Value);
        }

        [TestMethod]
        public void TestMethod5()//проверка на НОД 100-20-20
        {
            MyInt dde = new MyInt(100);
            MyInt tte = new MyInt(20);
            dde = dde.Gcd(tte);
            Assert.AreEqual(dde.Value, tte.Value);
        }
        [TestMethod]
        public void TestMethod6()//проверка на НОД 1071-462-21
        {
            MyInt dde = new MyInt(462);
            MyInt tte = new MyInt(1071);
            MyInt ans = new MyInt(21);
            dde = dde.Gcd(tte);
            Assert.AreEqual(dde.Value, ans.Value);
        }

        [TestMethod]
        public void TestMethod7()//тест сравнение 24==24
        {
            MyInt a = new MyInt(24);
            MyInt b = new MyInt(24);
            bool c = true;
            if (a.compareTo(b))
            {
                c = true;
            }
            else
            {
                c = false;
            }
            Assert.IsTrue(c);
        }


        [TestMethod]
        public void TestMethod8() // тест сложение (228+322=550)
        {
            MyInt dde = new MyInt(228);
            MyInt tdd = new MyInt(322);
            MyInt answer = new MyInt(550);

            MyInt lol = new MyInt();
            lol = dde.Add(tdd);


            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void TestMethod9() //тест сложение (2+2=4)
        {
            MyInt dde = new MyInt(2);
            MyInt tdd = new MyInt(2);
            MyInt answer = new MyInt(4);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);


            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void TestMethod10() //тест сложение (5+5=10)
        {
            //arrange
            MyInt dde = new MyInt(5);
            MyInt tdd = new MyInt(5);
            MyInt answer = new MyInt(10);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);


            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void TestMethod11() //тест разность (100-55=45)
        {
            MyInt a = new MyInt(100);
            MyInt b = new MyInt(55);
            MyInt ans = new MyInt(45);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }
        [TestMethod]
        public void TestMethod12() //тест разность (100-(-55)=155)
        {
            MyInt a = new MyInt(100);
            MyInt b = new MyInt(-55);
            MyInt ans = new MyInt(155);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }

        [TestMethod]
        public void TestMethod13() //тест разность (55-100=-45)
        {
            MyInt a = new MyInt(55);
            MyInt b = new MyInt(100);
            MyInt ans = new MyInt(-45);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }

        [TestMethod]
        public void TestMethod14() //тест умножение (2*2=4)
        {
            MyInt a = new MyInt(2);
            MyInt b = new MyInt(2);
            MyInt answer = new MyInt(4);

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void TestMethod15() //тест умножение (-20*-20=400)
        {
            MyInt a = new MyInt(-20);
            MyInt b = new MyInt(-20);
            MyInt answer = new MyInt("400");

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void TestMethod16()//тест умножение (2234*-234=-522756)
        {
            MyInt a = new MyInt(2234);
            MyInt b = new MyInt(-234);
            MyInt answer = new MyInt("-522756");

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void TestMethod17() //long
        {
            MyInt ans = new MyInt("123456789");
            long nans = 123456789;

            Assert.AreEqual(ans.longValue(), nans);
        }


    }
}
