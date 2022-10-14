using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentId=1000;
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year):base( aid, name, fatherName,gender,phone)
        {
            s_studentId++;
            StudentId="STd"+s_studentId;
            Department=department;
            Year=year;
        }
        
        
        
        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id"+StudentId);
            System.Console.WriteLine("Department"+Department);
            ShowDetails();
        }
        
        
        
    }
}