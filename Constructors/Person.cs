using System;
namespace Constructors
{
    public class Person
    {
        int ID;
        string firstName;
        string lastName;
        string address;
        int age;
        string gender;

        public Person()
        {
            ID = 1;
            firstName = "Marcin";
            lastName = "Nowak";
            age = 99;
        }

        public Person(int ID, string firstName, string lastName, string address, int age, string gender)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int ID, string firstName, string lastName)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            address = "Katowice";
            age = 18;
        }

        public Person(int ID, string firstName)
        {
            this.ID = ID;
            this.firstName = firstName;
        }
    }
}
