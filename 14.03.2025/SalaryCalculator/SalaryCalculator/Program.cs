namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary calculator");
            Console.WriteLine("Kirjuta brutopalk: ");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());
            double netIncome = 0;
            if (brutoSalary <= 1200)
            {
                netIncome = Salary.SalaryCalculationLess1200(netIncome, brutoSalary);
            }

            else if (brutoSalary > 1200 && brutoSalary < 2100)
            {
                netIncome = Salary.SalaryCalculationFrom1200To2100(netIncome, brutoSalary);
            }

            else if (brutoSalary >= 2100)
            {
                netIncome = Salary.SalaryCalculationIsAbove2100(netIncome, brutoSalary);
            }

            else
            {
                Console.WriteLine("Error, please try again");
            }

            Console.WriteLine("Sinu neto sissetulek on " + netIncome);
        }
    }

    public static class Salary
    {
        public static double SalaryCalculationLess1200(double netIncome, double brutoIncome)
        {
            double incomeTax = 0.22;
            double taxFreeIncome = 654;

            double pensionFund = brutoIncome * 0.02;
            double unempTax = brutoIncome * 0.016;

            double incomeTaxSum = (brutoIncome - (taxFreeIncome + pensionFund + unempTax)) * incomeTax;
            netIncome = brutoIncome - (pensionFund + unempTax + incomeTaxSum);

            return netIncome;
        }

        public static double SalaryCalculationFrom1200To2100(double netIncome, double brutoIncome)
        {
            double incomeTax = 0.22;
            double TaxFreeIncome =

            double pensionFund = brutoIncome * 0.02;
            double unempTax = brutoIncome * 0.016;

            return netIncome;
        }

        public static double SalaryCalculationIsAbove2100(double netIncome, double brutoIncome)
        {


            return netIncome;
        }
    }


}