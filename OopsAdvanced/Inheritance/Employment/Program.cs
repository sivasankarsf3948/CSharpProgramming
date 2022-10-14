using System;
namespace Employment
{
    class Program 
    {
        public static void Main(string[] args)
        {
             PersonalDetails person =new PersonalDetails("Sivasankar","Mathi",Employment.Gender.Male,636995530);
            //PersonalDetails.Default();
            PersonalDetails.ShowDetails();
            
        }
        
        
    }
}
