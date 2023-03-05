/*
Файл: QuadraticEquation.Tests.cs
Лабораторная робота № 2
Автор: Положий А. С.
Тема: Розробка та дослідження програми вирішення квадратного рівняння.
Дата створення: 23.02.2023
*/

using BuisnessLogic;
using System.Globalization;
using UI;

namespace QuadraticEquation.Tests
{
    [TestClass]
    public class QuadraticEquationTests
    {
        [TestMethod]
        public void Calc_1_3_4_ErrorReturned()
        {
            var user = new DummyUser();
            var presenter = new Presenter(user);

            user.A = "1";
            user.B = "3";
            user.C = "4";
            user.Calc();
            Assert.AreEqual("Дискриминант < 0", user.X1);
            Assert.AreEqual("Дискриминант < 0", user.X2);
        }

        [TestMethod]
        public void Calc_1_3_2_Minus1andMinus2Returned()
        {
            var user = new DummyUser();
            var presenter = new Presenter(user);

            user.A = "1";
            user.B = "3";
            user.C = "2";
            user.Calc();
            Assert.AreEqual("-1", user.X1);
            Assert.AreEqual("-2", user.X2);
        }

        [TestMethod]
        public void Calc_2_4_2_Minus1Returned()
        {
            var user = new DummyUser();
            var presenter = new Presenter(user);

            user.A = "2";
            user.B = "4";
            user.C = "2";
            user.Calc();
            Assert.AreEqual("-1", user.X1);
            Assert.AreEqual("-1", user.X2);
        }

        [TestMethod]
        public void Calc_32dot5_Minus542dot28_17dot10643andMinus0dot42089Returned()
        {
            var user = new DummyUser();
            var presenter = new Presenter(user);

            user.A = "32.5";
            user.B = "-542.28";
            user.C = "-234";
            user.Calc();
            Assert.AreEqual(double.Parse("17,1064327591043"), double.Parse(user.X1), 0.000000001);
            Assert.AreEqual(double.Parse("-0,420894297565813"), double.Parse(user.X2), 0.000000001);
        }

        [TestMethod]
        public void Calc_23_0_5_ErrorReturned()
        {
            var user = new DummyUser();
            var presenter = new Presenter(user);

            user.A = "23";
            user.B = "0";
            user.C = "5";
            user.Calc();
            Assert.AreEqual("Ошибка! Корень < 0", user.X1);
            Assert.AreEqual("Ошибка! Корень < 0", user.X2);
        }

        [TestMethod]
        public void ClearTest()
        {
            var user = new DummyUser();
            var presenter = new Presenter(user);

            user.A = "1";
            user.B = "3";
            user.C = "4";
            user.Calc();
            user.Clear();
            Assert.AreEqual("", user.A);
            Assert.AreEqual("", user.B);
            Assert.AreEqual("", user.C);
            Assert.AreEqual("", user.X1);
            Assert.AreEqual("", user.X2);
        }

        class DummyUser : IView
        {
            public string A { get; set; }
            public string B { get; set; }
            public string C { get; set; }
            public string X1 { get; set; }
            public string X2 { get; set; }
            public bool Radio1 { get; set; }
            public bool Radio2 { get; set; }
            public bool Radio3 { get; set; }

            public event EventHandler CalcAttempted;
            public event EventHandler ClearAttempted;

            public void Calc()
            {
                CalcAttempted?.Invoke(this, EventArgs.Empty);
            }
            public void Clear()
            {
                ClearAttempted?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}