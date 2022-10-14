using System;
using System.Collections.Generic;
namespace CollegeAdmission
{
    class Program{
        public static void Main(string[] args)
        {   
            System.Console.WriteLine("Are you willing to join in this college");
            string willing=Console.ReadLine();
            
            List<StudentDetails> studentList=new List<StudentDetails>() ;
            //Student1 detail
            while(willing=="yes")
            {
            
            System.Console.WriteLine("Student details 1 ");
            System.Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
           // student1.Name=name1;
            System.Console.WriteLine("Enter your Father name");
            string fathername=Console.ReadLine();
          
            System.Console.WriteLine("Enter your date of birth as dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            
            System.Console.WriteLine("Enter your gender");
            string gender=Console.ReadLine();
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
            /*
            System.Console.WriteLine("Student details 1 ");
            //studentdetail2
            StudentDetails student2 =new StudentDetails();
            System.Console.WriteLine("Enter your name");
            student2.Name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name");
            student2.FatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your date of birth as dd/mm/yyyy");
            student2.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            System.Console.WriteLine("Enter your gender");
            student2.Gender=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone number");
            student2.Phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail id");
            student2.Mail=Console.ReadLine();
            System.Console.WriteLine("Enter your Physics mark");
            student2.Physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry mark ");
            student2.Chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths mark");
            student2.Maths=int.Parse(Console.ReadLine());
            studentList.Add(student2);
            
            System.Console.WriteLine("Student details 3 ");
            //studentdetail3
            StudentDetails student3=new StudentDetails();
            System.Console.WriteLine("Enter your name");
            student3.Name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name");
            student3.FatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your date of birth as dd/mm/yyyy");
            student3.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            System.Console.WriteLine("Enter your gender");
            student3.Gender=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone number");
            student3.Phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail id");
            student3.Mail=Console.ReadLine();
            System.Console.WriteLine("Enter your Physics mark");
            student3.Physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry mark ");
            student3.Chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths mark");
            student3.Maths=int.Parse(Console.ReadLine());
            studentList.Add(student3);
            
            Default separate part
             student1.Physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry mark ");
            student1.Chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths mark");
           student1.Maths=int.Parse(Console.ReadLine());
           StudentDetails student1 =new StudentDetails();
           studentList.Add(student1);
           System.Console.WriteLine("Are you willing to join in this college");
           willing=Console.ReadLine();
          
*/

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

            }
        
           /* System.Console.WriteLine("Details of student 1 :");
            System.Console.WriteLine("Name : "+student1.Name);
            System.Console.WriteLine("Father name : "+student1.FatherName);
            System.Console.WriteLine("D.O.B is"+student1.DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Gender :"+student1.Gender);
            System.Console.WriteLine("Phone number :"+student1.Phone);
            System.Console.WriteLine("Mail ID is :"+student1.Mail);
            System.Console.WriteLine("Physics mark : "+student1.Physics);
            System.Console.WriteLine("Chemistry mark is : "+student1.Chemistry);
            System.Console.WriteLine("Maths mark is :"+student1.Maths);

            System.Console.WriteLine("Details of student 2 :");
            System.Console.WriteLine("Name : "+student2.Name);
            System.Console.WriteLine("Father name : "+student2.FatherName);
            System.Console.WriteLine("D.O.B is"+student2.DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Gender :"+student2.Gender);
            System.Console.WriteLine("Phone number :"+student2.Phone);
            System.Console.WriteLine("Mail ID is :"+student2.Mail);
            System.Console.WriteLine("Physics mark : "+student2.Physics);
            System.Console.WriteLine("Chemistry mark is : "+student2.Chemistry);
            System.Console.WriteLine("Maths mark is :"+student2.Maths);
           
            System.Console.WriteLine("Details of student 3 :");
            System.Console.WriteLine("Name : "+student3.Name);
            System.Console.WriteLine("Father name : "+student3.FatherName);
            System.Console.WriteLine("D.O.B is"+student3.DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Gender :"+student3.Gender);
            System.Console.WriteLine("Phone number :"+student3.Phone);
            System.Console.WriteLine("Mail ID is :"+student3.Mail);
            System.Console.WriteLine("Physics mark : "+student3.Physics);
            System.Console.WriteLine("Chemistry mark is : "+student3.Chemistry);
            System.Console.WriteLine("Maths mark is :"+student3.Maths);*/
            
        }
    }
}