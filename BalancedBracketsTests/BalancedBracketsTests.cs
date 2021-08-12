using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void StringIncasedInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void BracketsBeforeStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void BracketsCanBreakUpAStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void BracketsFacingOppositeWayReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void TwoSetsOfBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        [TestMethod]
        public void OnlyOneBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void DoubleLeftBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }

        [TestMethod]
        public void DoubleRightBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        [TestMethod]
        public void BracketsFacingOppositeWayEncasingAWordReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

    }
}
