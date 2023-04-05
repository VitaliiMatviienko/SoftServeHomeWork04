using System;

namespace SoftServeHomeWork04
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPersons = 6;
            Person[] persons = new Person[countPersons];
            for (int i = 0; i < countPersons; i++)
            {
                persons[i] = Person.Input();
            }


            for (int k = 0; k < countPersons; k++)
            {
                Console.WriteLine("person: {0}. age: {1}", persons[k].ToString(), persons[k].Age());
            }

            for (int l = 0; l < countPersons; l++)
            {
                if (persons[l].Age() < 16)
                {
                    persons[l].ChangeName("Very young");
                }
                
            }
            for (int j = 0; j < countPersons; j++)
            {

                persons[j].Output();
            }

            for (int m = 0; m < persons.Length; m++)
            {
                for (int n = m + 1; n < persons.Length; n++)
                {
                    if (persons[m] == persons[n])
                    {
                        Console.WriteLine("{0} and {1} are equals", persons[m].ToString(), persons[n].ToString());
                    }
                    else
                    { Console.WriteLine($"Cars are not equals"); }
                }
            }

        }
    }
}
