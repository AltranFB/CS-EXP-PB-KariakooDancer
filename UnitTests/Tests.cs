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

        [TestMethod]
        public void ProblemSolving4()
        {
            var pos = Solution.GetPositionAt(4);
            Check.That(pos).Equals(-5);
        }

        [TestMethod]
        public void Reliability1()
        {
            var pos = Solution.GetPositionAt(0);
            Check.That(pos).Equals(0);
        }

        [TestMethod]
        public void Reliability2()
        {
            var pos = Solution.GetPositionAt(1);
            Check.That(pos).Equals(1);
        }

        [TestMethod]
        public void Reliability3()
        {
            var pos = Solution.GetPositionAt(2);
            Check.That(pos).Equals(-1);
        }
    }
}