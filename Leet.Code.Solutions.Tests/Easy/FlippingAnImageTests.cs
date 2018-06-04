using FluentAssertions;
using Leet.Code.Solutions.Easy;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Easy
{
    [TestFixture]
    public class FlippingAnImageTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new FlippingAnImageSolution();
        }

        private FlippingAnImageSolution _solution;

        [Test]
        public void ShouldReturnFlippedImage()
        {
            var image = new[]
            {
                new[] {1, 1, 0},
                new[] {1, 0, 1},
                new[] {0, 0, 0}
            };

            var result = _solution.FlipAndInvertImage(image);

            object[] flippedAndInvertedImage = {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {1, 1, 1}
            };

            result.Should().BeEquivalentTo(flippedAndInvertedImage);
        }
    }
}