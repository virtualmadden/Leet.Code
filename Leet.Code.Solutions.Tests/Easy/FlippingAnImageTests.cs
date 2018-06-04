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
            _flippingAnImage = new FlippingAnImage();
        }

        private FlippingAnImage _flippingAnImage;

        [Test]
        public void ShouldReturnFlippedImage()
        {
            var image = new[]
            {
                new[] {1, 1, 0},
                new[] {1, 0, 1},
                new[] {0, 0, 0}
            };

            var result = _flippingAnImage.FlipAndInvertImage(image);

            object[] flippedAndInvertedImage = {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {1, 1, 1}
            };

            result.Should().BeEquivalentTo(flippedAndInvertedImage);
        }
    }
}