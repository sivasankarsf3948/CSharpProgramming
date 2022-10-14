using System;
using System.IO;
namespace FilesAndFolders
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string path=@"C:\Users\SivasankarMathiyazha\OneDrive - Syncfusion\Documents\Desktop\MyFolder";
            string folderPath=path+"/Siva";
            string filePath=path+"/newFile.txt";
            if(!Directory.Exists(folderPath))
            {
                System.Console.WriteLine("Folder not found.So creating folder");
                Directory.CreateDirectory(folderPath);
            }
            else
            {
                System.Console.WriteLine("Directory found ");
            }
            if(!File.Exists(filePath))
            {
                System.Console.WriteLine("File not found . Creating file");
                File.Create(filePath);
            }
            else
            {
                System.Console.WriteLine("File already exists");
            }

            //switch
            System.Console.WriteLine("Select Option 1.Create Folder\t2.Create File\n3.Delete Folder\n4.Delete File");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Enter folder name you want to create");
                    string name1=Console.ReadLine();
                    string newPath=path+"\\"+name1;
                    if(!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }
                    else{System.Console.WriteLine("Directory name already exists");}
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Enter file name you want to create");
                    string fileName=Console.ReadLine();
                    System.Console.WriteLine("Enter file extention you want to create");
                    string extention=Console.ReadLine();
                    string newPath=path+"\\"+fileName+"."+extention;
                    if(!File.Exists(newPath))
                    {
                        File.Create(newPath);
                    }
                    else{
                        System.Console.WriteLine("File name already exists");
                    }
                    

                    break;
                }
                case 3:
                {
                    foreach(string name in Directory.GetDirectories(path))//file manager 
                    {
                        System.Console.WriteLine(name);
                    }
                    System.Console.WriteLine("Select folder you want to delete");
                    string name1=Console.ReadLine();
                    string newPath=path+"\\"+name1;
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if(name==newPath)//check folder match
                        { try{Directory.Delete(newPath);
                            System.Console.WriteLine("Folder deleted");}
                            catch(DirectoryNotFoundException e)
                            {
                                System.Console.WriteLine("Directory not found");
                            }
                            
                        }
                    }
                    break;
                }
                case 4:
                {
                    foreach(string name in Directory.GetFiles(path))
                    {
                        System.Console.WriteLine(name);
                    }
                    System.Console.WriteLine("Select file you want to delete");
                    string name1=Console.ReadLine();
                    System.Console.WriteLine("Enter file extention you want to delete");
                    string name2=Console.ReadLine();
                    string newPath=path+"\\"+name1+"."+name2;
                    foreach(string name in Directory.GetFiles(path))
                    {
                        if(name==newPath)
                        {
                            File.Delete(newPath);
                            System.Console.WriteLine("File deleted");
                        }
                    }

                    break;
                }
            }

        }
    }
}
