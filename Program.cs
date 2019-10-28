using System;
/**
Name: Khali
Date of completion: 10/27/2019

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            int EXIT = -1;
            string employeeName = "";
            int deptNum;
            double hourlyPay, numOfHoursWorked, salary = 0.0;
            double [] deptSalaryAccum = {0.0,0.0,0.0,0.0,0.0,0.0,0.0};
            string [] DEPT_NAMES = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"};

            Console.WriteLine("MPLS Dog Boarding HR Payroll Report Program");
            Console.WriteLine("Please enter department number");
            deptNum = Convert.ToInt32(Console.ReadLine());

            while(deptNum != EXIT){

                Console.WriteLine("Please enter name");
                employeeName = Console.ReadLine();

                Console.WriteLine("Please enter hourly pay");
                hourlyPay = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter hours worked");
                numOfHoursWorked = Convert.ToInt32(Console.ReadLine());

                salary = hourlyPay * numOfHoursWorked;
                
                //output
                Console.WriteLine($"For {employeeName}, salary is {salary} department is {DEPT_NAMES[deptNum - 1]}");
                Console.WriteLine("thank you for using mpls dog boarding hr payroll report program");

                //primer
                Console.WriteLine("To continue, please enter another department number or enter -1 to exit the program");
                deptNum = Convert.ToInt32(Console.ReadLine());


            }            
            
        }
    }
}
