using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindIntegersPrimeFactors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIntegersPrimeFactors.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FindFactorsTestEqual()
        {
            var factors = Program.FindFactors(63);
            List<string> strings = factors.ConvertAll(x => x.ToString());
            var output = string.Join(",", strings.ToArray());
            Assert.IsTrue(output == "3,3,7");
        }

        [TestMethod()]
        public void FindFactorsTestNull()
        {
            var factors = Program.FindFactors(null);
            Assert.IsTrue(factors.Count == 0);
        }

        [TestMethod()]
        public void FindFactorsTestNegativeNumber()
        {
            var factors = Program.FindFactors(-5);
            Assert.IsTrue(factors.Count == 0);
        }
    }
}