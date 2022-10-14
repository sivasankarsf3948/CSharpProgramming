using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails:PersonalDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year):base( aid, name, fatherName,gender,phone)
        {
            s_studentId++;
            StudentId="STd"+s_studentId;
            Department=department;
            Year=year;
        }
        
        
        //
        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id"+StudentId);
            System.Console.WriteLine("Department"+Department);
            ShowDetails();
        }
        
        public void GetMark(int physics, int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        
        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3;
        }
        public void ShowMark()
        {
            System.Console.WriteLine($"Physics{Physics} Chemistry{Chemistry} Maths {Maths}");
        }
    }
}