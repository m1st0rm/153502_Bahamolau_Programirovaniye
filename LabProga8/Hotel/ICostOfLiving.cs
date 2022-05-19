using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public interface ICostOfLiving
    {
        double GetCostOfLiving();
    }

    class NoDiscount : ICostOfLiving
    {
        private double CostOfLiving;
        public NoDiscount(double CostOfLiving)
        {
            this.CostOfLiving = CostOfLiving;
        }
        public double GetCostOfLiving()
        {
            return this.CostOfLiving;
        }
    }

    class Discount : ICostOfLiving
    {
        private double CostOfLiving;
        private int PercentsOfDiscount;
        public Discount(double CostOfLiving, int PercentsOfDicount)
        {
            this.CostOfLiving = CostOfLiving;
            this.PercentsOfDiscount = PercentsOfDicount;
        }
        public double GetCostOfLiving()
        {
            return this.CostOfLiving - (this.CostOfLiving * this.PercentsOfDiscount / 100);
        }
    }
}
