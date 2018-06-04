using FluentAssertions;
using Leet.Code.Solutions.Easy;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Easy
{
    [TestFixture]
    public class TwoSumTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new TwoSumSolution();
        }

        private TwoSumSolution _solution;

        [Test]
        public void ShouldReturnCorrectResult()
        {
            _solution.TwoSum(new[] {2, 7, 11, 15}, 9).Should().BeEquivalentTo(new[] {0, 1});
        }
    }
}