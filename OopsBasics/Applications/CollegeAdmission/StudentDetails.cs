using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// used to process the college admission
/// </summary>
namespace CollegeAdmission
{
    /// <summary>
    /// used to select gender
    /// </summary>
    public enum Gender{Default,Male,Female,TransGender};
    /// <summary>
    /// to assign value to property in a <see cref=" Student details" />
    /// </summary>
    public class StudentDetails
    {
       // private string _name;//field declaration
        //public string Name { get{return _name;} set{name=value;} }
        /// <summary>
        /// used to auto increment
        /// </summary>
        private static int s_registernumber=3000;
        /// <summary>
        /// used to identify a <see cref="Specific object"/>
        /// </summary>
        /// <value></value>
        public string RegisterNumber{ get;  }
        /// <summary>
        /// used to identify  a name
        /// </summary>
        /// <value></value>
        
        
        public string Name { get; set; }//Auto property
        /// <summary>
        /// it refer father namof object
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// refers DOB of object
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Property Gender provide gender of the class
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// It refers mobile number of student class
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }
        /// <summary>
        /// Refers to mail of the student
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// It give physics mark of a student
        /// </summary>
        /// <value></value>
        public int Physics { get; set; }
        /// <summary>
        /// it gives chemistry mark of a student
        /// </summary>
        /// <value></value>
        public int Chemistry { get; set; }
        /// <summary>
        /// It gives maths marks of a student
        /// </summary>
        /// <value></value>
        public int Maths { get; set; }
      /*  public StudentDetails()//default constructor
        {
            Name="Your name";
            FatherName="Your Father name ";
        }*/
        /// <summary>
        /// Constructor of student class used <see cref="to initialize values to their properties"/>
        /// </summary>
        /// <param name="name">Initialize a name value  to Name property</param>
        /// <param name="fathername">Intialize fathername value to FatherName Property</param>
        /// <param name="dob">Initializing date of birth to DOB property</param>
        /// <param name="gender">Inializing gender name to Gender Property</param>
        /// <param name="mail">Initialize mail value to mail Property</param>
        /// <param name="phone">Initialize Phone number to Phone Property</param>
        /// <param name="physics">Initialize Physics marks to Physics property</param>
        /// <param name="chemistry">Initialize Chemistry mark  to Chemistry Property</param>
        /// <param name="maths">Initialize Maths mark to maths property</param>
        public StudentDetails(string name,string fathername,DateTime dob,Gender gender,string mail,long phone,int physics,int chemistry,int maths)
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Mail=mail;
           Phone=phone;
           Chemistry=chemistry;
           Maths=maths;
           Physics=physics;
             /*Destructor
            ~Student details()
            {

            }*/

        }
        /// <summary>
        /// Method check eligibility of a student by taking cuttoff as a parameter check with average 
        /// If cuttof is less or equal to average it returns true or false value
        /// </summary>
        /// <param name="cutoff">holds the cuttoff value for eligibility check up</param>
        /// <returns>Returns true if eligible else return false value</returns>
        public bool CheckEligibility(double cutoff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    /// <summary>
    /// It show all the details of the student which are assigned to the property
    /// </summary>
        public void ShowDetails()
        {
            System.Console.WriteLine("Register number "+RegisterNumber);
           // System.Console.WriteLine($"Name is :{Name}\nFather Name :{FatherName}\n");
            System.Console.WriteLine("Name : "+Name);
            System.Console.WriteLine("Father name : "+FatherName);
            System.Console.WriteLine("D.O.B is"+DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Gender :"+Gender);
            System.Console.WriteLine("Phone number :"+Phone);
            System.Console.WriteLine("Mail ID is :"+Mail);
            System.Console.WriteLine("Physics mark : "+Physics);
            System.Console.WriteLine("Chemistry mark is : "+Chemistry);
            System.Console.WriteLine("Maths mark is :"+Maths);
            //System.Console.WriteLine("Your id is "+RegisterNumber);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}