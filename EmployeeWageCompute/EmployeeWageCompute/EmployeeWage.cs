using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    public class EmpWageBuilderArray
    {
                //Declaring Constant Variable
                 public const int IS_FULL_TIME = 2;
                 public const int IS_PART_TIME = 1;

               //  private static int maxHoursPerMonth;
                  private int numofCompany = 0;
                 private companyEmpWage[] companyEmpWageArray;

                public EmpWageBuilderArray()
                {
                 this.companyEmpWageArray = new companyEmpWage[5];
                 }

              
                 public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHooursPerMonth)
                 {
                 companyEmpWageArray[this.numofCompany] = new companyEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
                  numofCompany++;
                 }

                public void ComputeEmpWage()
                {
                for (int i = 0; i < numofCompany; i++)
                {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
                }
               }

                 //Console.WriteLine("Welcome to employee wage computation");
                 //Creating a Random Function
                //variables
                private int computeEmpWage(companyEmpWage companyEmpWage)
               {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //computation
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpwage.numofWorkingDays)
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
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs);
                return totalEmpHrs * companyEmpWage.empRatePerHour;
            }
          }
               public class companyEmpWage
          {
                public int empRatePerHour;
                public string company;
                 public int numofWorkingDays;
                 public int maxHoursPerMonth;
                  public int totalEmpWage;

                      public companyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
                   {
                        this.company = company;
                        this.empRatePerHour = empRatePerHour;
                        this.numofWorkingDays = numofWorkingDays;
                        this.maxHoursPerMonth = maxHoursPerMonth;
                     }



                    public void setTotalEmpWage(int totalEmpWage)
                   {
                    this.totalEmpWage = totalEmpWage;
                   }
                    public string tostring()
                   {
                     return "Total Emp Wage for company:" + this.company + " is:" + this.totalEmpWage;
                     }

        }

    }  }
        
        
    
   
 

        
    

     
    

  
   


