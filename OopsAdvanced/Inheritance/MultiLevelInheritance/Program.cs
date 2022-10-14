using System;
namespace MultiLevelInheritance
{
    class Program 
    {
        public static void Main(string[] args)
        {
            PersonalDetails person =new PersonalDetails("Sivasankar","Mathi",Gender.Male,636995530);
           // PersonalDetails.Default();
           person.ShowDetails();
           StudentDetails student=new StudentDetails("667876","siva","mathi",Gender.Male,6789,Department.EEE,"Final");
           student.ShowStudent();
           student.GetMark(90,99,88);
           student.Calculate();
           student.ShowMark();
           Customer customer=new Customer("26677","siva","mathi",Gender.Male,9827882);
           customer.Recharge();
           customer.ShowCustomerDetail();
           EmploymentDetails employee=new EmploymentDetails("SF1002","677222","siva","mathi",Gender.Male,2222222,Department.EEE,DateTime.Now);
            employee.GetMark(90,99,88);
            employee.Calculate();
           employee.ShowMark();
            employee.ShowEmploymentDetail();
        }
        
        
    }
}
