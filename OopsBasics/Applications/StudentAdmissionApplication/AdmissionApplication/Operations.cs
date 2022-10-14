using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplication
{
    public class Operations{
        public static void MainMenu()
        {   
            System.Console.WriteLine("Are you willing to join in this college");
            string willing=Console.ReadLine();
            
            List<StudentDetails> studentList=new List<StudentDetails>() ;
            //Student1 detail
            while(willing=="yes")
            {
            
            System.Console.WriteLine("Student details  ");
            System.Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
           // student1.Name=name1;
            System.Console.WriteLine("Enter your Father name");
            string fathername=Console.ReadLine();
          
            System.Console.WriteLine("Enter your date of birth as dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            
            System.Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            
            System.Console.WriteLine("Enter your Phone number");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail id");
            string mail =Console.ReadLine();
            System.Console.WriteLine("Enter your Physics mark");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry mark ");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths mark");
           int maths=int.Parse(Console.ReadLine());
           StudentDetails student1 =new StudentDetails(name,fathername,dob,gender,mail,phone,physics,chemistry,maths);
           studentList.Add(student1);
           System.Console.WriteLine("Are you willing to join in this college");
           willing=Console.ReadLine();
          

            }
           

            foreach(StudentDetails student in studentList)
            {
             System.Console.WriteLine("Name : "+student.Name);
            System.Console.WriteLine("Father name : "+student.FatherName);
            System.Console.WriteLine("D.O.B is"+student.DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Gender :"+student.Gender);
            System.Console.WriteLine("Phone number :"+student.Phone);
            System.Console.WriteLine("Mail ID is :"+student.Mail);
            System.Console.WriteLine("Physics mark : "+student.Physics);
            System.Console.WriteLine("Chemistry mark is : "+student.Chemistry);
            System.Console.WriteLine("Maths mark is :"+student.Maths);
            System.Console.WriteLine("Your id is "+student.RegisterNumber);
            bool eligible=student.CheckEligibility(75.0);
            if(eligible)
            {
                System.Console.WriteLine("You are eligible for admission");
            }
            else{
                System.Console.WriteLine("You are not eligible for admission");
            }

            }
        

            /*Destructor
            ~Student details()
            {

            }*/
            
        }
    }
}