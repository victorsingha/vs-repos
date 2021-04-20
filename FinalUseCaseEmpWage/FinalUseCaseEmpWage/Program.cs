using System;

namespace FinalUseCaseEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputeEmpWage empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            //Console.WriteLine("Total Wage for DMart company: "+empWageBuilder.getTotalWage("DMart"));
            Console.ReadKey();
        }

    }
}
