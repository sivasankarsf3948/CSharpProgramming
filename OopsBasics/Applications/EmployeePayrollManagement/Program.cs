using System;
using System.Collections.Generic;
namespace EmployeePayrollManagement;
class Program
{
   public static void Main(string[] args)
   {
   
    System.Console.WriteLine("Welcome to Employee Payroll Application");
     Operations.MainMenu();
  /*  System.Console.WriteLine("To Continue.....Enter yes");
    string condition=Console.ReadLine();
    condition=condition.ToLower();
    List<EmployeePayment> employeeList=new List<EmployeePayment>();
    while(condition=="yes")
    {
        System.Console.WriteLine("Enter your name ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your work role");
        string role=Console.ReadLine();
        System.Console.WriteLine("Enter work location  Madura-Eymard ");
        WorkLocations location=Enum.Parse<WorkLocations>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter gender name");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter team name ");
        string team=Console.ReadLine();
        System.Console.WriteLine("Enter date of joining as dd/mm/yyyy");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
       System.Console.WriteLine("Enter numer of working days");
        int days=int.Parse(Console.ReadLine());
        
        //Finding days
       /* int year=date.Year;
        int month=date.Month;
        int days=0;
        if(DateTime.IsLeapYear(year))
        {
            days=DateTime.DaysInMonth(year,month);
        }
        else{
            days=DateTime.DaysInMonth(year,month);
        }*/
      /*  System.Console.WriteLine("Enter number of leaves taken");
        int leave=int.Parse(Console.ReadLine());
        EmployeePayment employee=new EmployeePayment(name,role,location,gender,team,date,days,leave);
        employeeList.Add(employee);
        System.Console.WriteLine("To Continue.....Enter yes");
        condition=Console.ReadLine();
        condition=condition.ToLower();

        foreach(EmployeePayment worker in employeeList)
        {
            System.Console.WriteLine("Employee details           :");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Employee name              :"+worker.EmployeeName);
            System.Console.WriteLine("Employee  ID               :"+worker.EmployeeId);
            System.Console.WriteLine("Gender                     :"+worker.Gender);
            System.Console.WriteLine("Job role                   :"+worker.WorkRole);
            System.Console.WriteLine("Work location              :"+worker.Location);
            System.Console.WriteLine("Team name                  :"+worker.TeamName);
            
            System.Console.WriteLine("Date of joining            :"+worker.DateOfJoining.ToShortDateString());
            System.Console.WriteLine("Number of working days     :"+worker.WorkingDays);
            System.Console.WriteLine("Number of leave taken      :"+worker.LeaveTaken);
            worker.SalaryCalculation();
            System.Console.WriteLine("----------------------------");
            
        }*/
          
    
   }
}
