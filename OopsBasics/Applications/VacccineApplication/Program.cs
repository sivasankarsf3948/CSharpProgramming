using System;
namespace VaccineApplication
{
            public class Program
            {
                public static void Main(string[] args)
                {
                // Beneficiary defuser=new Beneficiary();
                Files.CreateFolderAndFile();
               Files.ReadFiles();
            
                Operations.MainMenu();
                Files.WriteFiles();
                
                }


            }

}