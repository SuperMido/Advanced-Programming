using System;

namespace Abstraction
{
    abstract class school
    {
        public virtual void Display()
        {
            
        }
    }
    class Persons : school
    {
        private string name;
        private int age;

        private string phone;

        public virtual string Name
        {
            get { return name;}
            set { name = value;}
        }

        public virtual int Age
        {
            get {return age;}
            set {age = value;}
        }

        public virtual string Phone
        {
            get{return phone;}
            set{phone = value;}
        }

        public Persons(string name, int age, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Phone = phone;
        }
        public void getInfo()
        {
            Console.WriteLine($"{name} is {age} years old and has phone number: {phone}");
        }

        public virtual void Print()
        {
            Console.WriteLine("=====Persons Information=====");
            Console.WriteLine("Name\t\tAge\tPhone");
            Console.WriteLine($"{Name}\t{Age}\t{Phone}");
        }

        public override void Display()
        {
            Console.WriteLine("==== Welcome to University of Greenwich ====");
            Console.WriteLine("====         Advance programing         ====");
            Console.WriteLine($"====         Person Name: {Name}     ====");
            Console.WriteLine($"====         Person Age: {Age}             ====");
            Console.WriteLine($"====         Person Phone: {Phone}   ====\n");        }
    }

    class Room : school
    {
        private int roomID;
        private bool hasClass;

        public int roomID
        {
            get { return roomID;  }
            set { roomID = value; }

        }

        public bool HasClass
        {
            get { return hasClass; }
            set { hasClass = value;  }
        }

        public Room(int roomID, bool hasClass)
        {
            this.roomID = roomID;
            this.hasClass = hasClass;
        }

        public override void Display()
        {
            Console.WriteLine("==== Welcome to University of Greenwich ====");
            Console.WriteLine("====         Advance programing         ====");
            Console.WriteLine($"====         Room ID: {roomID}   \t        ====");
            Console.WriteLine($"====         Room status: {hasClass}          ====");
        }
    }

    class Student : Persons
    {
        private double score;
        private int grade;

        public Student(string name, int age, string phone) : base(name,age,phone)
        {
            score = 0;
            grade = 0;
        }

        public Student(string name, int age, string phone, double score) : base(name,age,phone)
        {
            this.score = score;
        }

        public Student(string name, int age, string phone, double score, int grade) : base(name,age,phone)
        {
            this.score = score;
            this.grade = grade;
        }

        public void status()
        {
            if (score >=5)
                Console.Write($"Infomation of student {Name}:\n\tAge: {Age}\n\tPhone Number: {Phone}\n\tScore: {score}\n\tMove to next grade({grade} => {grade+1})\n\n");
                else Console.Write($"Infomation of student {Name}:\n\tAge: {Age}\n\tPhone Number: {Phone}\n\tScore: {score}\n\tCant move to next grade({grade} => {grade+1})\n\n");
        }
        public override void Print()
        {
            Console.WriteLine("Name\t\tAge\tPhone\t\tScore\tGrade");
            Console.WriteLine($"{Name}\t{Age}\t{Phone}\t{score}\t{grade}");
        }

    }

    class Teacher : Persons
    {
        private double salary;
        private int workhours;

        public Teacher(string name, int age, string phone) : base(name,age,phone)
        {
            salary = 0;
            workhours =0;
        }

        public Teacher(string name, int age, string phone, double salary) : base(name,age,phone)
        {
            this.salary = salary;
            workhours =0;
        }

        public Teacher(string name, int age, string phone, double salary, int workhours) : base(name,age,phone)
        {
            this.salary = salary;
            this.workhours = workhours;
        }

        public int CalSalary(int workhours)
        {
            return 10*workhours;
        }

        public void status()
        {
                Console.Write($"Infomation of teacher {Name}:\n\tAge: {Age}\n\tPhone Number: {Phone}\n\tSalary: {salary}\n\tWork hours: {workhours}\n\tSalary get: {CalSalary(workhours)}\n");
        }

        public override void Print()
        {
            Console.WriteLine("=====Teacher Information=====");
            Console.WriteLine("Name\t\tAge\tPhone\t\tSalary\tWork hours");
            Console.WriteLine($"{Name}\t{Age}\t{Phone}\t{salary}\t{workhours}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            school mySchool;

            mySchool = new Student("QUang Huy",24,"0795541090");
            mySchool.Display();
            mySchool = new Room(10,true);
            mySchool.Display();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
