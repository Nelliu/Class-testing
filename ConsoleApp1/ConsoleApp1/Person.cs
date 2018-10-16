using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Bdate { get; set; }
        public string Gender { get; set; }

        public bool Alive { get; set; }


        List<string> Names = new List<string>() { "Honza", "Pepa", "Kuba", "Franta", "Jirka" };
        List<string> LastNames = new List<string>() { "Nový", "Novotný", "Starý", "Modrý", "Novák" };
        List<int> Bdates = new List<int>() { 1799, 2000, 1997, 2000, 1996 };
        List<string> Genders = new List<string>() { "Man", "Woman" };




        Random randomn = new Random();

        
        
        public Person Addto(int rand, int rand1)
        {
            bool isalive = false;
            if (rand1 == 0)
            {
                isalive = true;
            }
            

            Person returningP = new Person();
            returningP.Name = Names[rand];
            returningP.LastName = LastNames[rand];
            returningP.Bdate = Bdates[rand];
            returningP.Gender = Genders[0];
            returningP.Alive = isalive;


            return returningP;
        }


    }
}
