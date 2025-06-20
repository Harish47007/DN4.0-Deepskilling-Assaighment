using System;
using System.Collections.Generic;
using System.Linq;

namespace FinancialForecasting
{
    class Program
    {
        static double CalculateMovingAverage(List<double> incomeData, int period)
        {
            if (incomeData.Count < period)
            {
                Console.WriteLine("Not enough data to forecast.");
                return 0;
            }
            var recentMonths = incomeData.Skip(incomeData.Count - period).ToList();
            double sum = recentMonths.Sum();
            return sum / period;
        }
        static void Main(string[] args)
        {
            List<double> monthlyIncome = new List<double>()
            {
                120.5, 130.0, 110.75, 145.0, 155.25, 160.0, 170.5, 165.75, 180.0, 175.25, 190.0, 200.5
            };
            Console.Write("Enter the number of months for moving average ");
            int period = int.Parse(Console.ReadLine());
            double prediction = CalculateMovingAverage(monthlyIncome, period);
            if (prediction > 0)
            {
                Console.WriteLine($"\n📈 Predicted income for next month: ₹{prediction:0.00}K");
            }
        }
    }
}
