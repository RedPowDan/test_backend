using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTestForBackend
{
    [TestClass]
    public class UnitTestOnTrueAnswer
    {
        int _count_min_numbers = 2;

        [TestMethod]
        public void TestMethod1()
        {
            int[] test_mass = new[] { 4, 0, 3, 19, 492, -10, 1 };

            var result = test_backend.Program.get_sum_min_numbers(test_mass, _count_min_numbers);
            var Expected = -10;

            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] test_mass = new[] { 4, 0, 3, 19, 492, -10, 1, 3, 19,3432, -2000, 1, 456, -1000, 492, -10, 1 };

            var result = test_backend.Program.get_sum_min_numbers(test_mass, _count_min_numbers);
            var Expected = -3000;

            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] test_mass = new[] { 4, 0, 3, 19, 492, 1, 19, 492, 19, 492, 1 };

            var result = test_backend.Program.get_sum_min_numbers(test_mass, _count_min_numbers);
            var Expected = 1;

            Assert.AreEqual(Expected, result);
        }
    }


    [TestClass]
    public class UnitTestOnCritical
    {
        int _count_min_numbers = 2;

        [TestMethod]
        public void EmptyMass()
        {
            int[] test_mass = new int[0];
            try
            {
                var result = test_backend.Program.get_sum_min_numbers(test_mass, _count_min_numbers);
            }
            catch (ArgumentException)
            {
                
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void NullMass()
        {
            int[] test_mass = null;
            try
            {
                var result = test_backend.Program.get_sum_min_numbers(test_mass, _count_min_numbers);
            }
            catch (ArgumentNullException)
            {

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void EmptyNumbersMass()
        {

            int[] test_mass = new int[100];

            var result = test_backend.Program.get_sum_min_numbers(test_mass, _count_min_numbers);
            var Expected = 0;

            Assert.AreEqual(Expected, result);
        }
    }
}
