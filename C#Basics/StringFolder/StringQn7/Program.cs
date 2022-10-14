using System;
namespace StringQn7 
{
    class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a sting ");
        string word=Console.ReadLine();
        int vowels=0,constants=0;
        for(int i=0;i<word.Length;i++)
        {
            if(word[i]=='a'|| word[i]=='e' || word[i]=='i' || word[i]=='o' || word[i]=='u'||word[i]=='A'|| word[i]=='E' || word[i]=='I' || word[i]=='O'||word[i]=='U')
            {
                vowels++;
            }
            else if((int)word[i] >=65 && (int)word[i] <=90 || (int)word[i] >=97 && (int)word[i] <=122 )
            {
                constants++;
            }
            
        }
        System.Console.WriteLine("Vowels count are "+vowels);
            System.Console.WriteLine("constant count are "+constants);
    }
    }

}
