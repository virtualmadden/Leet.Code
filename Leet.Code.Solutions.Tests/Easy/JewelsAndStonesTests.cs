using FluentAssertions;
using Leet.Code.Solutions.Easy;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Easy
{
    [TestFixture]
    public class JewelsAndStonesTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new JewelsAndStonesSolution();
        }

        private JewelsAndStonesSolution _solution;

        [TestCase("aA", "aAAbbbb", 3)]
        [TestCase("z", "ZZ", 0)]
        public void ShouldOutputCorrectNumberOfJewels(string jewels, string stones, int result)
        {
            _solution.NumJewelsInStones(jewels, stones).Should().Be(result);
        }
    }
}