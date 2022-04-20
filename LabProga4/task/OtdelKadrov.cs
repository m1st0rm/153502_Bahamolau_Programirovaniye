using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class OtdelKadrov
    {
        private string NameOfCompany = "Company Co.";
        private int CountOfWorkers = 20;
        private NormativeOfHours Normative;
        private static OtdelKadrov OtdelKadrovInstance = null;
        private double SalaryForHour = 200;
        private double SalaryBill = 0.13;
        private OtdelKadrov(string Name, int Count, int Norma, double Salary)
        {
            Normative = new NormativeOfHours();
            this.NameOfCompany = Name;
            this.CountOfWorkers = Count;
            this.Normative.SetHours(Norma);
            this.SalaryForHour = Salary;
            this.SalaryBill = 0.13;
        }
        public static OtdelKadrov GetInstance(string Name, int CountOfPeoples, int Norma, double Salary)
        {
            if (OtdelKadrovInstance == null)
            {
                OtdelKadrovInstance = new OtdelKadrov(Name, CountOfPeoples, Norma, Salary);
            }
            return OtdelKadrovInstance;
        }
        public void SetHours(int count)
        {
            Normative.SetHours(count);
        }
        public int GetHours()
        {
           return Normative.GetHours();
        }
        public double SalarySum()
        {
            double FullSalary = (this.CountOfWorkers * this.SalaryForHour * this.Normative.GetHours()) * (1 - this.SalaryBill);
            return FullSalary;
        }
        public double SalarySum(int NewBill)
        {
            double FullSalary = (this.CountOfWorkers * this.SalaryForHour * this.Normative.GetHours()) * (1 - NewBill);
            return FullSalary;
        }
    }

    class NormativeOfHours {
        private int CountOfHours;
        public NormativeOfHours()
        {

        }
        public void SetHours(int Norma)
        {
            this.CountOfHours = Norma;
        }
        public int GetHours()
        {
            return CountOfHours;
        }
    }
    namespace mainspace
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}