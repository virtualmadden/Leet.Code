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
            _jewelsAndStones = new JewelsAndStones();
        }

        private JewelsAndStones _jewelsAndStones;

        [TestCase("aA", "aAAbbbb", 3)]
        [TestCase("z", "ZZ", 0)]
        public void ShouldOutputCorrectNumberOfJewels(string jewels, string stones, int result)
        {
            _jewelsAndStones.NumJewelsInStones(jewels, stones).Should().Be(result);
        }
    }
}