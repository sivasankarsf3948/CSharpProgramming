using System;
using System.Collections.Generic;
namespace FilterDeligates
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Person person1=new Person(){Name="John",Age=41};//here no constructor but object created with inbuild default and property value assign to that specific object
            Person person2=new Person(){Name="siva",Age=69};
            Person person3=new Person(){Name="sam",Age=12};
            Person person4=new Person(){Name="senthu",Age=10};
            Person person5=new Person(){Name="Johnny",Age=30};
            Person person6=new Person(){Name="Johner",Age=50};
            List<Person> persons=new List<Person>(){person1,person2,person3,person4,person5,person6};
            // persons.Add(person1);
            // persons.Add(person2);
            // persons.Add(person3);
            // persons.Add(person4);
            // persons.Add(person5);
            // persons.Add(person6);

            DisplayPeople("Children :",persons,IsChild);
            DisplayPeople("Voters :",persons,IsVoter);
            DisplayPeople("Adults :",persons,IsAdult);
            DisplayPeople("Seniors :",persons,IsSenior);
        }

        static void DisplayPeople(string title,List<Person> persons,FilterDeligate filter)
        {
            System.Console.WriteLine("People in "+title+"list are:");
            foreach(Person p in persons)
            {
                if(filter (p))
                {
                    System.Console.WriteLine("{0} is {1} years old ",p.Name,p.Age);
                }
            }
        }
        static bool IsChild(Person p){return p.Age<15;}
        static bool IsVoter(Person p){return p.Age>=18;}
        static bool IsAdult(Person p){if( p.Age>=18 && p.Age<50){ return true;} else return false;}
        static bool IsSenior (Person p){return p.Age>50;}

    }
}
