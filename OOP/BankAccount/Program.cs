using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1_AdvancedProgramming
{
    class BankAccount
    {
        //Private fields
        private int id;
        private decimal balance;

        //Public properties
        public int Id;
        public decimal Balance;

        public BankAccount(int id)
        {
            Id = id;
        }

        public BankAccount(int id, decimal balance)
        {
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Can't deposite Negative amount");
            } 
            else Balance = Balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Can't withdraw");
            } else if (amount < 0)
            {
                Console.WriteLine("Can't withdraw negative amount");
            }
            else Balance = Balance - amount;
        }

        public override string ToString()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Balance: {0}", Balance);
            return base.ToString();
        }

        public void Print(int id)
        {

        }
    }

    class Person
    {
        string name;
        int age;
        List<BankAccount> accounts;

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        public Person(string n, int a, List<BankAccount> acc)
        {
            name = n;
            age = a;
            accounts = acc;
        }

        public decimal GetBalance()
        {
            decimal sum;
            sum = accounts.Sum(x => x.Balance);
            return sum;
        }
    }
    class StartUp
    {
        List<BankAccount> accounts;
        public StartUp()
        {
            accounts = new List<BankAccount>();
        }

        public void ShowMenu()
        {
            Console.WriteLine("<-----MENU----->");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print");
            Console.WriteLine("5. End");
            Console.WriteLine("===============");
        }

        public bool IsIdExists(int id)
        {

            return accounts.Exists(x => x.Id == id);
        }

        public void AddBankAccount(int id)
        {
            accounts.Add(new BankAccount(id));
        }
        static void Main(string[] args)
        {
            //BankAccount acc = new BankAccount();

            //Override the method ToString()

            /*
            acc.Id = 1;
            acc.Balance = 15;
            acc.ToString();
            Console.WriteLine("=========");
            acc.Deposit(10);
            acc.ToString();
            */


            StartUp myProgram = new StartUp();
            myProgram.ShowMenu();

            Console.Write("Enter your command: ");
            int chooseMenu = Convert.ToInt32(Console.ReadLine());
            int chooseId;
            int chooseAmount;

            //Choose option for menu

            Console.WriteLine("Command: {0}", chooseMenu);
            while (chooseMenu != 5)
            {
                if (chooseMenu > 5 || chooseMenu < 0)
                {
                    Console.WriteLine("Invalid command");
                    
                }
                else
                {
                    switch (chooseMenu)
                    {
                        case 1:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            if (myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account already exists...");
                            }
                            else
                            {
                                Console.WriteLine("Account created successfully...");

                                myProgram.AddBankAccount(chooseId);
                            }
                            break;
                        case 2:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Please enter amount: ");
                            chooseAmount = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).Deposit(chooseAmount);
                                Console.WriteLine("After deposit");
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 3:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Please enter amount: ");
                            chooseAmount = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).Withdraw(chooseAmount);
                                
                                Console.WriteLine("After withdraw");
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 4:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 5: break;
                        default:
                            break;
                    }
                    if (chooseMenu == 5) break;
                }
                Console.Write("Enter your command: ");
                chooseMenu = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thank you for using our service");

            List<BankAccount> listAccounts = new List<BankAccount>();
            listAccounts.Add(new BankAccount(1, 10));
            listAccounts.Add(new BankAccount(2, 10));
            listAccounts.Add(new BankAccount(3, 10));
            listAccounts.Add(new BankAccount(4, 10));
            listAccounts.Add(new BankAccount(5, 10));

            Person myPerson = new Person("Peter", 10, listAccounts);

            Console.WriteLine("Sum: {0}", myPerson.GetBalance());


            Console.Read();
            
        }
    }
}