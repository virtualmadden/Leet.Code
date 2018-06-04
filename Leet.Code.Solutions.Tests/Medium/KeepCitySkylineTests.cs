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
            _keepCitySkyline = new KeepCitySkyline();
        }

        private KeepCitySkyline _keepCitySkyline;

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

            _keepCitySkyline.MaxIncreaseKeepingSkyline(cityGrid).Should().Be(35);
        }
    }
}