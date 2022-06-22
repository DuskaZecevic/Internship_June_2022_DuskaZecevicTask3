using System;
using Task3.BusinessLogic;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine("Maximimum profit you can achieve from this transaction is: " + Service.maxProfit(price));
        }
    }
}
