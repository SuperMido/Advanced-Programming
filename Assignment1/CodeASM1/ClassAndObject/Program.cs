using System;

namespace ClassAndObject
{
    class Persons
    {
        public string name;
        public int age;

        public string phone;

        public Persons()
        {
            name = "Empty";
            age = 0;
        }

        public Persons(string Name)
        {
            name = Name;
            age = 0;
            phone = "0";
        }
        public Persons(string Name, int Age)
        {
            name = Name;
            age = Age;
            phone = "0";
        }
         public Persons(string Name, int Age, string Phone)
        {
            name = Name;
            age = Age;
            phone = Phone;
        }

        public void setName(string Name)
        {
            name = Name;
        }

        public void setAge(int Age)
        {
            age = Age;
        }

        public void setPhone(string Phone)
        {
            phone = Phone;
        }

        public void getInfo()
        {
            Console.WriteLine($"{name} is {age} years old and has phone number: {phone}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persons myPersons = new Persons();
            myPersons.setName("Quang Huy");
            myPersons.setAge(24);
            myPersons.setPhone("0795541090");
            myPersons.getInfo();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
