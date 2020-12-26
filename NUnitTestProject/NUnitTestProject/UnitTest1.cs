using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [Test, TestCaseSource("TestValuesPlus")]
        public void TestPlus(int x, int y, int z)
        {
            int result = Calc.Plus(x, y);
            Assert.IsTrue(z == result, "z = {0} and result = {1}", z, result);
        }
        static object[] TestValuesPlus =
        {
            new object[]{33,33,66},
            new object[]{18,2,20},
            new object[]{-7,7,0},
            new object[]{10,11,20},
        };
        [Test, TestCaseSource("TestValuesMinus")]
        public void TestMinus(int x, int y, int z)
        {
            int result = Calc.Minus(x, y);
            Assert.IsTrue(z == result, "z = {0} and result = {1}", z, result);
        }
        static object[] TestValuesMinus =
        {
            new object[]{-3,-3,0},
            new object[]{60,60,0},
            new object[]{60,10,50},
            new object[]{3,10,-6},
        };
        [Test, TestCaseSource("TestValuesMult")]
        public void TestMult(int x, int y, int z)
        {
            int result = Calc.Mult(x, y);
            Assert.IsTrue(z == result, "z = {0} and result = {1}", z, result);
        }
        static object[] TestValuesMult =
        {
            new object[]{6,6,36},
            new object[]{33,0,0},
            new object[]{6,-3,-18},
            new object[]{60,0,60},
        };
        [Test, TestCaseSource("TestValuesDiv")]
        public void TestDiv(int x, int y, int z)
        {
            int result = Calc.Div(x, y);
            Assert.IsTrue(z == result, "z = {0} and result = {1}", z, result);
        }
        static object[] TestValuesDiv =
        {
            new object[]{4,4,1},
            new object[]{54,0,0},
            new object[]{45,0,null},
            new object[]{39,-13,3},
        };
    }
}