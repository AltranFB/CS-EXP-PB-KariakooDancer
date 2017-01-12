using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ProblemSolving1()
        {
            var pos = Solution.GetPositionAt(3);
            Check.That(pos).Equals(-4);
        }

        [TestMethod]
        public void ProblemSolving2()
        {
            var pos = Solution.GetPositionAt(100000);
            Check.That(pos).Equals(-5);
        }

        [TestMethod]
        public void ProblemSolving3()
        {
            var pos = Solution.GetPositionAt(2147483647);
            Check.That(pos).Equals(1);
        }
    }
}