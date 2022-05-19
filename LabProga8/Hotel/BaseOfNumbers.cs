using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class BaseOfNumbers
    {
        List<HotelNumber> ListOfNumbers = new List<HotelNumber>();
        public void AddNumberWithoutDiscount(string NameOfNumber, double CostOfLiving)
        {
            HotelNumber newNumber = new HotelNumber(NameOfNumber, new NoDiscount(CostOfLiving));
            ListOfNumbers.Add(newNumber);
        }
        public void AddNumberWithDiscount(string NameOfNumber, double CostOfLiving, int Discount)
        {
            HotelNumber newNumber = new HotelNumber(NameOfNumber, new Discount(CostOfLiving,Discount));
            ListOfNumbers.Add(newNumber);
        }
        public double GetAverageCostOfLiving()
        {
            double result = 0;
            foreach (HotelNumber Number in ListOfNumbers)
            {
                result += Number.GetCostOfLiving();
            }
            result /= ListOfNumbers.Count;
            return result;
        }
    }
}
