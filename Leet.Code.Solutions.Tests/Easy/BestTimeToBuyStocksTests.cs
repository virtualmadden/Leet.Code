using FluentAssertions;
using Leet.Code.Solutions.Easy;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Easy
{
    [TestFixture]
    public class BestTimeToBuyStocksTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new BestTimeToBuyStock();
        }

        private BestTimeToBuyStock _solution;

        [Test]
        public void ShouldReturnMaxProfit()
        {
            _solution.MaxProfit(new[] {7, 1, 5, 3, 6, 4}).Should().Be(5);
        }
    }
}