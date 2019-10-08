using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
                {
                    return this.lastName;
                }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        private decimal Salary
        {
            get
            {
                return this.Salary;
            }
            set
            {
                if(value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary:F2} leva.";
        }

        public void IncreaseSalary(decimal bonus)
        {
            if(this.age >= 30)
            {
                this.salary = this.salary + (this.salary * bonus) / 100;
            }
            else
            {
                this.salary = this.salary + (this.salary * bonus) / 200;
            }
        }
    }
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return this.firstTeam;
            }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam;
            }
        }

        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
                var lines = int.Parse(Console.ReadLine());
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    try
                    {
                        var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                        persons.Add(person);
                    }
                    catch(ArgumentException ex)
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                    
                }
                // var bonus = decimal.Parse(Console.ReadLine());
                // persons.ForEach(p => p.IncreaseSalary(bonus));
                // persons.ForEach(p => Console.WriteLine(p.ToString()));

                // persons.OrderBy(p => p.FirstName)
                //        .ThenBy(p => p.Age)
                //        .ToList()
                //        .ForEach(p => Console.WriteLine(p.ToString()));
               
                // var team = new Team("GCD");
                // for (int i = 0; i < lines; i++)
                // {
                //     var cmdArgs = Console.ReadLine().Split();
                //     var person = new Person(cmdArgs[0],
                //                             cmdArgs[1],
                //                             int.Parse(cmdArgs[2]),
                //                             decimal.Parse(cmdArgs[3]));

                //     team.AddPlayer(person);
                // }

                // Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
                // Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");


            }
        }
}
