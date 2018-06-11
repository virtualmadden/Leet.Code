using FluentAssertions;
using Leet.Code.Solutions.Easy;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Easy
{
    [TestFixture]
    public class MaximumSubarrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new MaximumSubarraySolution();
        }

        private MaximumSubarraySolution _solution;

        [Test]
        public void ShouldReturnTheLargestSum()
        {
            var array = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            _solution.MaxSubArray(array).Should().Be(6);
        }
    }
}