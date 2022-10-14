using System;
//using System.Collections.Generic;

using System.IO;

namespace CollegeApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating a new folder");
                Directory.CreateDirectory("College");
            }

            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Files created ");
                File.Create("College/DepartmentDetails.csv");
            }

             if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Files created ");
                File.Create("College/AdmissionDetails.csv");
            }

             if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Files created ");
                File.Create("College/StudentDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
            }
            //read for deoartment details
            string[] department=File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string data2 in department)
            {
                DepartmentDetails depart=new DepartmentDetails(data2);
                DepartmentDetails.departmentList.Add(depart);
            }
            //admissiondetails
            string[] admision=File.ReadAllLines("College/AdmissionDetails.csv");
            foreach(string data1 in admision)
            {
                AdmissionDetails admit=new AdmissionDetails(data1);
                Operations.admissionList.Add(admit);
            }

        }

        public static void WriteToFiles()
        {
            string[] studentdetails=new string[Operations.studentList.Count] ;
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                studentdetails[i]=Operations.studentList[i].StudentID+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;

            }
            File.WriteAllLines("College/StudentDetails.csv",studentdetails);
        }
    }
}