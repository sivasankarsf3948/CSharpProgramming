using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement
{
    public enum WorkLocations{Default,Madura,Eymard};
    public enum Gender{Default,Male,Female,TransGender};
    public class EmployeePayment
    {
        private static int _semployeeId=1000;
        public string EmployeeId { get;  }
        public string EmployeeName { get; set; }
        public Gender Gender { get; set; }
        public string WorkRole { get; set; }
        public WorkLocations  Location { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int WorkingDays { get; set; }
        public int LeaveTaken { get; set; }
        
        
        public EmployeePayment(string name,string roll,WorkLocations location,Gender gender,string team,DateTime date)
        {
            _semployeeId++;
            EmployeeId="SF"+_semployeeId;
            EmployeeName=name;
            Gender=gender;
            TeamName=team;
            Location=location;
            WorkRole=roll;
            DateOfJoining=date;
           // WorkingDays=days;
            
        }
        
       /* 
        
       public void SalaryCalculation()
       {
          int salary=(WorkingDays-LeaveTaken)*500;
          System.Console.WriteLine("Your salary is             :"+salary);
       } 
        
        */
        
        
        
        
        
        
    }
}