using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        enum Genders
        {
            Male,
            Female
        };

        private String name;
        private DateTime birthDate;
        private Genders gender;

        public override string ToString()
        {
            String result = "Name:" + name + ", Birth Date:" + birthDate.ToString("yyyy-MM-dd") + ", Gender:" + gender;
            return result;
        }

        static void Main(string[] args)
        {
            Person person = new Person()
            {
                name = "Kiss János",
                birthDate = new DateTime(1974, 2, 9),
                gender = Genders.Male
            };
            Console.WriteLine(person.ToString());
            Console.ReadKey();
        }
    }
}
