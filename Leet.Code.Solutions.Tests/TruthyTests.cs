using FluentAssertions;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests
{
    [TestFixture]
    public class TruthyTests
    {
        [SetUp]
        public void SetUp()
        {
            _isTrue = true;
        }

        private bool _isTrue;

        [Test]
        public void ShouldBeTrue()
        {
            _isTrue.Should().BeTrue();
        }
    }
}