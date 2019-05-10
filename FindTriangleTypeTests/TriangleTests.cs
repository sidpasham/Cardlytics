using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTriangleType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTriangleType.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetTriangleTypeTestEqual()
        {
            var resultEquilateral = Triangle.GetTriangleType(1, 1, 1);
            var resultIsosceles = Triangle.GetTriangleType(1, 1, 2);
            var resultScalene = Triangle.GetTriangleType(1, 2, 3);

            Assert.IsTrue(resultEquilateral == TriangleType.Equilateral);
            Assert.IsTrue(resultIsosceles == TriangleType.Isosceles);
            Assert.IsTrue(resultScalene == TriangleType.Scalene);
        }

        [TestMethod()]
        public void GetTriangleTypeTestInvalid()
        {
            var resultError = Triangle.GetTriangleType(0, 0, 0);
            var resultError1 = Triangle.GetTriangleType(1, 0, 0);
            var resultError2 = Triangle.GetTriangleType(1, 1, 0);

            Assert.IsTrue(resultError == TriangleType.Error);
            Assert.IsTrue(resultError1 == TriangleType.Error);
            Assert.IsTrue(resultError2 == TriangleType.Error);

        }
    }
}