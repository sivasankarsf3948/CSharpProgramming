using System;
namespace SingleInheritance
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
           
        }
        
        
    }
}
