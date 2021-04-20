using System;

namespace CalculateDailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            // PartTimeEmpWage();

            //UC3_PartTimeEmpWage.PartTimeEmpWage();
            //ClassSwitchFullTimePartTime.EmpWageUsingSwitch();
            Calculate20days.CalculateWagesFor20DaysInMonth();
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            //UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            //UC8 starts
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("DMart", 20, 2, 10);
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("Reliance", 10, 4, 20);
            //UC8 Ends

            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());

            Console.ReadKey();
        }
        /* public static void PartTimeEmpWage()
        {
            //Constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            int salary = 0;
            int totalHrs = 0;
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Emp Wage for Day "+i+": "+ empWage);
                salary = salary + empWage;
                totalHrs = totalHrs + empHrs;
            }
            Console.WriteLine("Total Hours: " + totalHrs);
            Console.WriteLine("Total Salary: " + salary);
            if (totalHrs < 100)
            {
                Console.WriteLine("Salary not Paid!! Working hour less than 100hrs");
            }
            else Console.WriteLine("Salary Paid :)");
            Console.ReadKey();
        }
        */


    }
}
