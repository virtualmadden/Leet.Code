using FluentAssertions;
using Leet.Code.Solutions.Medium;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Medium
{
    [TestFixture]
    public class NumberOfIslandsTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new NumberOfIslandsSolution();
        }

        private NumberOfIslandsSolution _solution;

        [Test]
        public void ShouldReturnNumberOfIslands()
        {
            var map = new[,]
            {
                {'1', '1', '1', '1', '0'},
                {'1', '1', '0', '1', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '0', '0', '0'}
            };

            _solution.NumIslands(map).Should().Be(1);

            map = new[,]
            {
                {'1', '1', '0', '0', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '1', '0', '0'},
                {'0', '0', '0', '1', '1'}
            };

            _solution.NumIslands(map).Should().Be(3);
        }
    }
}