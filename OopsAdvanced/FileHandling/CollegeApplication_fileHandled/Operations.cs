using System;
//using System.Collections.Generic;


namespace CollegeApplication
{public delegate void EventManager();
   //public enum AdmissionStatus{Default,Booked,Cancelled} 
    public static class Operations
    {
        //public static string _eventName;
        public static event EventManager eventlink=null;
      //  static int i;
       
        public static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();
        
        private static StudentDetails currentStudent=null;
         public static List<StudentDetails> studentList=new List<StudentDetails>();

        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operations.MainMenu);
            eventlink+=new EventManager(Files.WriteToFiles);

        }

        public static void StartEvent()
        {
            Subscribe();//event register store
            eventlink();//trigger one by one
        }
        public static void MainMenu()
        {
          
          System.Console.WriteLine("Welcome to SyncFusion Engineering College");
          bool condition=true;
          do
          {
            
            System.Console.WriteLine("Select Option :\n1.Student Registration\n2.Student Login\n3.Check Department wise Seat Availability\n4.Exit");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Enter your details to register");
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
                    DepartmentDetails.SeatAvailability();

                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Thank You");
                    condition=false;
                    break;
                }
            }
            
          }while(condition);
        }
        
        
        //Registration method
        
        public static void Registration()
        {
           System.Console.WriteLine("Enter Your name");
           string name=Console.ReadLine();
           System.Console.WriteLine("Enter your Father name");
           string fathername=Console.ReadLine();
           System.Console.WriteLine("Enter your date of birth as dd/mm/yyyy");
           DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
           System.Console.WriteLine("Enter Gender name");
           Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
           System.Console.WriteLine("Enter your physics mark");
           int physics=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter your chemistry mark");
           int chemistry=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter your maths mark");
           int maths=int.Parse(Console.ReadLine());
           //objectcreation
           StudentDetails student=new StudentDetails(name,fathername,dob,gender,physics,chemistry,maths);
           studentList.Add(student);
           System.Console.WriteLine("Student Added Successfully and student Id is "+student.StudentID);
           
        }
        

        //Login ,ethod
        public static void Login()
        {
            System.Console.WriteLine("Enter your student id");
              string id=Console.ReadLine().ToUpper();
            foreach (StudentDetails student1 in studentList)
           {
              
               if(student1.StudentID==id)
               {
                 currentStudent=student1;
                 Submenu();
                }
            }  
        }
        //Submenu method
        public static void Submenu()
        {
            bool condition=true;
          do
          {
           
                System.Console.WriteLine("Select Option :1.Check Eligibility\n2.Show details\n3.Take Admission\n4.Cancel admission\n5.Show Admission Details\n6.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                    
                        CheckEligibility();
                        break;
                    }
                    case 2:
                    {
                        ShowDetails();
                        break;
                    }
                    case 3:
                    {
                        TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                    ShowAdmissionDetails(); 
                    break;
                    }
                    case 6:
                    {
                    System.Console.WriteLine("Thank You");
                        condition=false;
                        break;

                    }
                }
            
            }while(condition);

        }
        

          public static void CheckEligibility()
          {
         
           
                int average=(currentStudent.Maths+currentStudent.Physics+currentStudent.Chemistry)/3;
                if(average>=75)
                {
                    System.Console.WriteLine("Your eligible for admission");

                }
                else{
                    System.Console.WriteLine("You are not eligible for admission");
                }
               
          }
           
            
           
        
          

        //Department list
        public static void DepartmentList()
        {
            foreach(DepartmentDetails department in DepartmentDetails.departmentList)
            {
                 System.Console.WriteLine("Department ID    :"+department.DepartmentId+"Seats   : "+department.Seats);
            }
        

           
        }
        public static void ShowDetails()
        {
            System.Console.WriteLine("Student Id       :"+currentStudent.StudentID);
            System.Console.WriteLine("Student name     :"+currentStudent.StudentName);
            System.Console.WriteLine("Father name      :"+currentStudent.FatherName);
            System.Console.WriteLine("Gender           :"+currentStudent.Gender);
            System.Console.WriteLine("DOB              :"+currentStudent.DOB);
            System.Console.WriteLine("Physics mark     :"+currentStudent.Physics);
            System.Console.WriteLine("Chemistry mark   :"+currentStudent.Chemistry);
            System.Console.WriteLine("Maths mark       :"+currentStudent.Maths);
        }
        
        
        public static void TakeAdmission()
        {
            DepartmentDetails.SeatAvailability();
            System.Console.WriteLine("Choose the department id shown above");
            string userdepartment=Console.ReadLine().ToUpper();
            foreach(DepartmentDetails department in DepartmentDetails.departmentList)
            {
                if(userdepartment==department.DepartmentId)
                {
                
                        int average=(currentStudent.Maths+currentStudent.Physics+currentStudent.Chemistry)/3;
                        if(average>=75)
                        {
                          foreach(DepartmentDetails listmember in DepartmentDetails.departmentList)
                          {
                            if(userdepartment==department.DepartmentId)
                            {
                                listmember.Seats--;
                                
                               // System.Console.WriteLine(listmember.Seats);
                            }
                          }
                          AdmissionDetails admitdetail=new AdmissionDetails(currentStudent.StudentID,userdepartment,DateTime.Now,AdmissionStatus.Booked);
                                admissionList.Add(admitdetail);
                                System.Console.WriteLine("Admission took successfully and Admission Id is "+admitdetail.AdmissionId);
                       
                        }
                }

            }
            
           
        }     
         


            //cancel admission
            public static void CancelAdmission()
            {
                foreach(AdmissionDetails member in admissionList)
                {
                    if(member.StudentId==currentStudent.StudentID)
                    {
                        if(member.AdmissionStatus!=AdmissionStatus.Cancelled)
                        {
                            foreach(DepartmentDetails department in DepartmentDetails.departmentList)
                            {
                                if( member.DepartmentId==department.DepartmentId)
                                {
                                    department.Seats++;
                                    //System.Console.WriteLine("Your Admission status is "+member.AdmissionStatus);
                                    member.AdmissionStatus=AdmissionStatus.Cancelled;
                                    System.Console.WriteLine("Now Your admission status changed to"+member.AdmissionStatus);
                               }
                               
                            }
                            
                        }       
                    }
                }
            }

            //show admission details
            public static void ShowAdmissionDetails()
            {
                foreach(AdmissionDetails i in admissionList)
                {
                    if(i.StudentId==currentStudent.StudentID)
                    {
                        System.Console.WriteLine("Student ID               :"+i.StudentId);
                        System.Console.WriteLine("Admission status         :"+i.AdmissionStatus);
                        System.Console.WriteLine("Admission ID             :"+i.AdmissionId);
                        System.Console.WriteLine("Admission Date           :"+i.AdmissionDate);
                    
                    }
                }
            }
        
    }
} /*    foreach(var student in admissionList)
                            {
                                if(currentStudent.StudentID!=student.StudentId)
                                {
                                    AdmissionDetails entry=new AdmissionDetails(currentStudent.StudentID,department.DepartmentId,DateTime.Now,AdmissionStatus.Booked);
                                    admissionList.Add(entry);
                                    department.Seats--;
                                    System.Console.WriteLine("Admisssion Booked and admisssion id is "+entry.AdmissionId);
                                }
                            }*/