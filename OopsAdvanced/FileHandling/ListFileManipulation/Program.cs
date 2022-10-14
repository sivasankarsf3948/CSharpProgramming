using System;
using System.IO;
using System.Collections.Generic;
namespace ListFileManipulation
{
    
    class Program 
    { 
        
        public static void Main(string[] args)
        {
             List<StudentDetails> vList=new List<StudentDetails>();
             vList.Add(new StudentDetails(){Name="siva",FatherName="mathi",Gender=Gender.Male,DOB=new DateTime(1111,11,23),});
             vList.Add(new StudentDetails(){Name="sankar",FatherName="mathi",Gender=Gender.Male,DOB=new DateTime(2222,11,23),});
             vList.Add(new StudentDetails(){Name="baskar",FatherName="sethu",Gender=Gender.Male,DOB=new DateTime(3333,11,23),});
             Insert(vList);
             Display();
             

        }

        //insert method
        static void Insert(List<StudentDetails> vlist)
        {
            StreamWriter write=null;
            if(!File.Exists("Data.csv"))
            {
                System.Console.WriteLine("File does't exist created a new csv file");
                File.Create("Data.csv");
            }
            else{
                System.Console.WriteLine("File found");
            }

            write=new StreamWriter(File.OpenWrite("Data.csv"));
            foreach(var v in vlist)
            {
                write.WriteLine( v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyy"));
            }
            write.Close();
        }

        //display
        static void Display()
        {
            StreamReader reader=null;
            List<StudentDetails> listA=new List<StudentDetails>();
            if(File.Exists("Data.csv"))
            {
                reader=new StreamReader(File.OpenRead("Data.csv"));
                while(!reader.EndOfStream)
                {
                    var line=reader.ReadLine();
                    var values=line.Split(",");
                    if(values[0]!="")
                    {
                        listA.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                    }
                }
            }
            else{
                System.Console.WriteLine("File does not exise");
            }
            reader.Close();
            foreach(var column1 in listA)
            {
                System.Console.WriteLine("Your name:\t"+column1.Name+"\t Father name\t"+column1.FatherName+"\t Gender is :\t"+column1.Gender+"\tDate of birth :\t"+column1.DOB.ToString("dd/MM/yyyy"));
            }


        }

        //update
        
        static void Update()
        {
            System.Console.WriteLine("To update select option 0.your name 1.Father name");
            int option=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the name to be updated ");
            
        }
    }
}

