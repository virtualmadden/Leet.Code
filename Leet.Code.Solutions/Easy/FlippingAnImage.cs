namespace Leet.Code.Solutions.Easy
{
    public class FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            var flippedImage = FlipImage(image);

            return InvertImage(flippedImage);
        }

        private static int[][] FlipImage(int[][] image)
        {
            var flippedImage = new int[image.GetLength(0)][];

            for (var i = 0; i < image.GetLength(0); i++)
            {
                flippedImage[i] = new int[image.GetLength(0)];

                for (var j = 0; j < image.GetLength(0); j++)
                {
                    flippedImage[i][j] = image[i][image.GetLength(0) - j - 1];
                }
            }

            return flippedImage;
        }

        private static int[][] InvertImage(int[][] image)
        {
            var invertedImage = new int[image.GetLength(0)][];

            for (var i = 0; i < image.GetLength(0); i++)
            {
                invertedImage[i] = new int[image.GetLength(0)];

                for (var j = 0; j < image.GetLength(0); j++)
                {
                    if (image[i][j].Equals(0))
                    {
                        invertedImage[i][j] = 1;
                    }
                    else
                    {
                        invertedImage[i][j] = 0;
                    }
                }
            }

            return invertedImage;
        }
    }
}