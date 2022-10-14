using System;
using System.IO;
namespace ReadWritxtFiles
{
    class Program 
    {
         public static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
                System.Console.WriteLine("Folder created");
      
            }
            else{
                System.Console.WriteLine("Folder Exists");
            }
            if(!File.Exists("TestFolder/Test.txt"))
            {
                File.Create("TestFolder/Test.txt");
                System.Console.WriteLine("File created");
            }
            else{
                System.Console.WriteLine("File found");
            }
            System.Console.WriteLine("Select option \n1.Read file info\n2.write File Info");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    string line;
                    StreamReader sr=null;
                    try
                    {//pass file path ,name to streamreader constructor
                        sr=new StreamReader("TestFolder/Test.txt");
                        line=sr.ReadLine();//read 1stline of text
                        while(line!=null)
                        {
                            System.Console.WriteLine(line);//write line to console window
                            line=sr.ReadLine();//read next line
                            
                        }
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine("Exception: "+e.Message);
                    }
                    finally
                    {
                        if(sr!=null)
                        {
                            System.Console.WriteLine("Executing finally block ");
                            sr.Close();
                        }
                        
                    }

                    break;
                }
                case 2:
                {
                    StreamWriter sw=null;
                    try
                    {
                        string[] old=File.ReadAllLines("TestFolder/Test.txt");//pass filepath and filename to stream writer constructor
                        sw =new StreamWriter("TestFolder/Test.txt");
                        System.Console.WriteLine("Enter new content to be placed in file");
                        string info=Console.ReadLine();
                        string old1="";
                            foreach(string text in old)
                            {
                                old1=old1+"\n"+text;
                            }
                            old1=old1+"\n"+info;
                            sw.WriteLine(old1);
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine("Exception  "+e.Message);
                    }
                    finally
                    {
                        System.Console.WriteLine("Entered finally block");
                        sw.Close();
                    }
                    break;
                }
            }
        }
    }
}
