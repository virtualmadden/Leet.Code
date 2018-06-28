namespace Leet.Code.Solutions.Easy
{
    public class BestTimeToBuyStock
    {
        public int MaxProfit(int[] prices)
        {
            var buy = -1;
            var sell = -1;
            var maxProfit = 0;

            foreach (var price in prices)
            {
                if (buy.Equals(-1) || buy > price)
                {
                    buy = price;
                    sell = price;
                }
                else if (sell < price)
                {
                    sell = price;
                }

                if (maxProfit < sell - buy)
                {
                    maxProfit = sell - buy;
                }
            }

            return maxProfit;
        }
    }
}