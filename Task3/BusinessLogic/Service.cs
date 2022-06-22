using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.BusinessLogic
{
    public class Service
    {
        public static int maxProfit(int[] price)
        {
            int maxProfit = 0;
            for (int i = 0; i < price.Length; i++)
                for (int j = i + 1; j < price.Length; j++)
                {
                    int newProfit = price[j] - price[i];
                    if (newProfit > maxProfit)
                        maxProfit = newProfit;
                }
            return maxProfit;
        }
    }
}
