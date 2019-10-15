using System;

namespace Encapsulation
{
    class Persons
    {
        private string name;
        private int age;

        private string phone;

        public string Name
        {
            get { return name;}
            set { name = value;}
        }

        public int Age
        {
            get {return age;}
            set {age = value;}
        }

        public string Phone
        {
            get{return phone;}
            set{phone = value;}
        }
        public void getInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old and has phone number: {Phone}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persons myPersons = new Persons();
            myPersons.Name = "Quang Huy";
            myPersons.Age = 24;
            myPersons.Phone = "0795541090";
            Console.Write($"{myPersons.Name} is {myPersons.Age} years old and has phone number: {myPersons.Phone}");
            Console.WriteLine();
            myPersons.getInfo();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
