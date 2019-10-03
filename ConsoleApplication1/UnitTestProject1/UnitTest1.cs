using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsContain5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result1 = Program.IsContain5or6(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4 };
            bool result2 = Program.IsContain5or6(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 5 };
            bool result3 = Program.IsContain5or6(Arr3);
            Assert.AreEqual(true, result3);

        }
        public void TestIsContain5And6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result1 = Program.IsContain5And6(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool result2 = Program.IsContain5And6(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 5 };
            bool result3 = Program.IsContain5And6(Arr3);
            Assert.AreEqual(false, result3);

            int[] Arr4 = new int[] { 1, 2, 3, 4, };
            bool result4 = Program.IsContain5And6(Arr4);
            Assert.AreEqual(false, result4);
        }
        public void Count5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.IsContain5And6(Arr1);
            Assert.AreEqual(1, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5,5 };
            bool result2 = Program.IsContain5And6(Arr2);
            Assert.AreEqual(2, result2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 6 };
            bool result3 = Program.IsContain5And6(Arr3);
            Assert.AreEqual(0, result3);
        }
        public void TestCount5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            int result1 = Program.Count5or6(Arr1);
            Assert.AreEqual(0, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5 };
            int result2 = Program.Count5or6(Arr2);
            Assert.AreEqual(1, result2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 6, 6};
            int result3 = Program.Count5or6(Arr3);
            Assert.AreEqual(2, result3);

            int[] Arr4 = new int[] { 1, 2, 3, 4, 5, 6, 6 };
            int result4 = Program.Count5or6(Arr4);
            Assert.AreEqual(3, result4);
        }
        public void Testsum()
        {
            int[] Arr1 = new int[0];
            int result1 = Program.Sum(Arr1);
            Assert.AreEqual(0, result1);
        }
    }
}
