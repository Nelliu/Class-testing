using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            Person Person1 = new Person();
            Person Person2 = new Person();
            Person Person3 = new Person();
            Person Person4 = new Person();
            Person Person5 = new Person();

            Person addon = new Person();
            

            
            

            Person1 = Person1.Addto(0,0);
            Person2 = Person1.Addto(1, 1);
            Person3 = Person1.Addto(2, 0);
            Person4 = Person1.Addto(3, 1);
            Person5 = Person1.Addto(4, 1);

            People.Add(Person1);
            People.Add(Person2);
            People.Add(Person3);
            People.Add(Person4);
            People.Add(Person5);

            int CurrentYear = 2018;
            int howm = 0;
            int AgeofAll = 0;
            int men = 0;
            int woman = 0;
            int other = 0;

            for (int i = 0; i < People.Count; i++)
            {
                Console.WriteLine("Name: " + People[i].Name);
                Console.WriteLine("Last name: " + People[i].LastName);
                Console.WriteLine("Year of birth: " + People[i].Bdate);
                Console.WriteLine("Gender: " + People[i].Gender);
                
                if (People[i].Alive == true)
                {
                    Console.WriteLine("Status: Alive");
                }
                else
                {
                    Console.WriteLine("Status: Dead");
                }
                Console.WriteLine();

                AgeofAll = AgeofAll + (CurrentYear - People[i].Bdate);
                howm++;

                if (People[i].Gender == "Man")
                {
                    men++;
                }
                else if (People[i].Gender == "Woman")
                {
                    woman++;
                }
                else
                {
                    other++;
                }

            }

            Console.WriteLine("Average age: "+(AgeofAll / howm));
            Console.WriteLine("Men: " + men);
            Console.WriteLine("Women: " + woman);
            Console.WriteLine("Other: " + other);

            

            





        }
    }
}
