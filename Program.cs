using System;
/**
Name: 
Date of completion:

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
            int name, depName;
            int depNum, hoursWork;
            double gross, salary;
            Console.WriteLine("MPLS Dog Boarding HR Payroll Report Program");
            Console.WriteLine("Please enter your name");
            name = Convert.ToInt32(Console.ReadLine());

            while(name != EXIT){
                //defensive programming -- something that only accepts characters
                while(name = ){

                    name = Convert.ToInt32(Console.ReadLine());
                }
                
                Console.WriteLine($"Welcome {name}");
                Console.WriteLine("Enter department number");
                depNum = Console.ReadLine()

            }

            
        }
    }
}
