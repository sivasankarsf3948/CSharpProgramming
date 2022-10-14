using System;


namespace CollegeApplication
{
    public class DepartmentDetails
    {
       public static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();
       private static int s_DepartmentId=100;
       public string DepartmentName { get; set; }
       public string DepartmentId { get; set; }
       public int Seats { get; set; }
       
       
       
       public DepartmentDetails(string departmentName,int seats)
       {
        s_DepartmentId++;
        DepartmentId="DID"+s_DepartmentId;
        DepartmentName=departmentName;
        Seats=seats;
       }

       //file constructor
       public DepartmentDetails(string value)
       {
        string[] value1=value.Split(',');
        DepartmentName=value1[1];
        s_DepartmentId=int.Parse(value1[0].Remove(0,2));
        DepartmentId=value1[0];
        Seats=int.Parse(value1[2]);
       }
       //Seat availability
     public static void SeatAvailability()
       {
           DepartmentDetails admit=new DepartmentDetails("EEE",29);
            departmentList.Add(admit);
            DepartmentDetails admit2= new DepartmentDetails("CSE",29);
            departmentList.Add(admit2);
            DepartmentDetails admit3=new DepartmentDetails("MECH",30);
            departmentList.Add(admit3);
            DepartmentDetails admit4=new DepartmentDetails("ECE",30);
            departmentList.Add(admit4);
            foreach(DepartmentDetails department in departmentList)
            {
                System.Console.WriteLine("Department Id is    "+department.DepartmentId);
                System.Console.WriteLine("Department Name is  "+department.DepartmentName);
                System.Console.WriteLine("Seats available     "+department.Seats);
                
            }
       }

       //default method
       public static void DefaultMethod()
       {
        DepartmentDetails.departmentList.Add(new DepartmentDetails("EEE",29));
        DepartmentDetails.departmentList.Add(new DepartmentDetails("CSE",29));
        DepartmentDetails.departmentList.Add(new DepartmentDetails("MECH",30));
        DepartmentDetails.departmentList.Add(new DepartmentDetails("ECE",39));
       }
        
    }
}