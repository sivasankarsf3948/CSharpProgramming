using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement
{
    public static class Operations
    {
        static EmployeePayment currentCustomer=null;
        static List<EmployeePayment> employeeList=new List<EmployeePayment>() ;
        public static void MainMenu()
        {
           
            string condition ="yes";
            do
            {
              System.Console.WriteLine("Select Option :\n1.Employee Registering\n2.Login to the application\n3.Exit the Application");
              int option=int.Parse(Console.ReadLine());
              switch(option)
              {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                  System.Console.WriteLine("Thank you");
                    condition="no";
                    break;
                }
                default:
                {

                    break;
                }
              }
              
            }while(condition=="yes");
            
        }


        //SubMenu
        public static void SubMenu()
        {
          string condition="yes";
          do
          {
            System.Console.WriteLine("Select Options :\n1.Show employee Details\n2.GetNumber of leaves\n3.Calculate salary\n4.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
              case 1:
              {
                ShowDetails();
                break;
              }
              case 2:
              {
                GetNumberOfLeaves();

                break;
              }
              case 3:
              {
               SalaryCalculation();

                break;
              }
              case 4:
              {
                condition="no";
                break;
              }
              

            }

          }while(condition=="yes");
       

        }

        //Registration
        public static void Registration()
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
          
            
           
            EmployeePayment employee=new EmployeePayment(name,role,location,gender,team,date);
            employeeList.Add(employee);
           System.Console.WriteLine("AccountNumber ="+employee.EmployeeId);
           


        }

        //Login
        public static void Login()
        {
         System.Console.WriteLine("Enter your employee id number");
          string number=Console.ReadLine().ToUpper();
         foreach(EmployeePayment customer1 in employeeList)
         {
           if(number==customer1.EmployeeId)
          {
            System.Console.WriteLine("-----Logged in-----");
            currentCustomer=customer1;
            SubMenu();
          }
         }
         
          
          

        }

        //ShowDetails

        public static void ShowDetails()
        {
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
          //  System.Console.WriteLine("Number of working days     :"+worker.WorkingDays);
           // System.Console.WriteLine("Number of leave taken      :"+worker.LeaveTaken);
         //   worker.SalaryCalculation();
            System.Console.WriteLine("----------------------------");
            
        }
        }

        //GetLeave Method

        public static void GetNumberOfLeaves()
        {
          System.Console.WriteLine("Enter number of working days");
          int days=int.Parse(Console.ReadLine());
          currentCustomer.WorkingDays=days;
           System.Console.WriteLine("Enter number of leaves taken");
          int leave=int.Parse(Console.ReadLine());
          currentCustomer.LeaveTaken=leave;
          
        }

        //Calculate method
         public static void SalaryCalculation()
       {
          int salary=(currentCustomer.WorkingDays-currentCustomer.LeaveTaken)*500;
          System.Console.WriteLine("Your salary is             :"+salary);
       }
       
    }
}