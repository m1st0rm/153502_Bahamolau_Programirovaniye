using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class HotelNumber
    {
        private string NameOfNumber;
        private ICostOfLiving CostOfLiving;
        public HotelNumber (string NameOfNumber, ICostOfLiving CostOfLiving)
        {
            this.NameOfNumber = NameOfNumber;
            this.CostOfLiving = CostOfLiving;
        }
        public double GetCostOfLiving()
        {
            return this.CostOfLiving.GetCostOfLiving();
        }
    }
}
