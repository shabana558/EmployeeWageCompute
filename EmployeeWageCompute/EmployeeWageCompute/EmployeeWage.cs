using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    public class EmpWageBuilderObject
    {
        //Declaring Constant Variable
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        //  private static int maxHoursPerMonth;
        private string company;
        private int empRatePerHour;
        private int numofWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;


        public EmpWageBuilderObject(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            //Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        // Console.WriteLine("Employee is present for full-time");
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        //Console.WriteLine("Employee is present for part-time");
                        empHrs = 8;
                        break;
                    default:
                        //Console.WriteLine("Employee is absent");
                        totalEmpHrs = 0;
                        break;

                }
                totalEmpHrs += totalEmpHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company:" + company + "is:" + totalEmpWage);


        }
        public string tostring()
        {
            return "Total Emp Wage for company: " + this.company + "is:" + this.totalEmpWage;


        }
    }
    class program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMART", 12, 5, 19);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 12, 20, 30);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString ());
        }

    }

    }
        
        
    
   
 

        
    

     
    

  
   


