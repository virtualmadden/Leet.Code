using FluentAssertions;
using Leet.Code.Solutions.Medium;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Medium
{
    [TestFixture]
    public class KeepCitySkylineTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new KeepCitySkylineSolution();
        }

        private KeepCitySkylineSolution _solution;

        [Test]
        public void DoSomething()
        {
            var cityGrid = new[]
            {
                new[] {3, 0, 8, 4},
                new[] {2, 4, 5, 7},
                new[] {9, 2, 6, 3},
                new[] {0, 3, 1, 0}
            };

            _solution.MaxIncreaseKeepingSkyline(cityGrid).Should().Be(35);
        }
    }
}