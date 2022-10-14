using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Operations
    {
        static StudentDetails currentstudent=null;
        static List<StudentDetails> studentList=new List<StudentDetails>() ;
        public static void MainMenu()
        {
            
            string choice="yes";
            do
            {

            
                    System.Console.WriteLine("Select Option 1.Registration 2. Login 3.Exit");
                    int option =int.Parse(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                        {
                        System.Console.WriteLine("Registration");
                        Registration();
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("Login");
                            Login();
                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("Exit");
                            choice="no";
                            break;
                        }
                        default:
                        {

                            break;
                        }
                    }
            }while(choice=="yes");
        }
        public static void Registration()
        {
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
           System.Console.WriteLine("Register Number"+student1.RegisterNumber);
      
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter Your Register number ");
            string registerNumber=Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if(student.RegisterNumber==registerNumber)
                {
                    System.Console.WriteLine("Login Successful");
                    currentstudent=student;
                    SubMenu();

                }
     
            }
            
        }
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                
            
                System.Console.WriteLine("Select Option 1.Show Details\n2.Check Eligibility\n3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                       System.Console.WriteLine("Show Details");
                        currentstudent.ShowDetails();

                        break;
                    }
                    case 2:
                    {
                    System.Console.WriteLine("Check Eligibility");
                    bool eligible=currentstudent.CheckEligibility(75.0);
                    string ans=eligible?"You are eligible":"You are not eligible";
                    System.Console.WriteLine(ans);
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Option");
                        break;
                    }
                }
            } while (choice=="yes");
            
           // System.Console.WriteLine();
        }
    }

}