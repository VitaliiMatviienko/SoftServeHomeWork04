using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServeHomeWork04
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person() { name = "Unknown"; birthYear = new DateTime(1900, 1, 1); }
        public Person(string name, DateTime birthYear) { this.name = name; this.birthYear = birthYear; }

        public int Age()
        {
            return (int)(DateTime.Now.Subtract(birthYear).Days/365.25);
        }
        public static Person Input()
        {
            Console.Write("write name: ");
            string name = Console.ReadLine();
            Console.Write("write bithYear: ");
            int birthYear = int.Parse(Console.ReadLine());
            Person person = new Person(name, (new DateTime(birthYear, 1, 1)));
            return person;
        }

        public void ChangeName(string newName)
        {
            //Console.Write("write new name: ");

            //name = Console.ReadLine();
            name = newName;


        }

        public override string ToString()
        {
            return "name - " + name + ", birthyear - " + birthYear.Year.ToString();
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }


    }
}
