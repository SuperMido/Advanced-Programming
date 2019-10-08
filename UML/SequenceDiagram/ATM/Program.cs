﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSequence
{
    class Program
    {
        class Customer {

            public string customerName;
            public Customer(string customerName)
            {
                this.customerName = customerName;
            }
            public void InsertCard(Card card, ATM atm)
            {
                atm.RequestPIN();
                int PIN = EnterPIN();

                if (!atm.VerifyPIN(PIN, card)) { 
                    Console.WriteLine("PIN Not Accepted ...");
                } else
                {
                    Console.WriteLine("PIN Accepted ...");
                    
                }
                
            }

            public void SelectOption(int option)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Waiting...");
                        break;
                    case 2:
                        break;
                }
            }

            int EnterPIN()
            {
                int PIN = Convert.ToInt32(Console.ReadLine());
                return PIN;
            }

            public void TakeCash(ATM atm)
            {
                atm.AtmGetSetBalance = atm.AtmGetSetBalance - EnterAmount();
            }

            public void Terminate()
            {
                
            }

            public double EnterAmount()
            {
                Console.Write("Please Enter Amount to withdraw: ");
                double Amount = Convert.ToInt32(Console.ReadLine());
                return Amount;
            }


        }

        class ATM {

            public int ATMID;
            double ATMBalance;
            public ATM(int atmID, double atmBalance)
            {
                ATMID = atmID;
                ATMBalance = atmBalance;
            }

            public double AtmGetSetBalance
            {
                get { return ATMBalance;}
                set {ATMBalance = value;} 
            }
            public void RequestPIN()
            {
                Console.Write("Please Enter Your PIN: ");
                
            }

            public bool VerifyPIN (int pin, Card card)
            {


                return pin == card.GetAccount().GetPIN();
            }

            public void RequestAmount()
            {
                Console.Write("Please input amount to withdraw: ");
            }

            public void DispenseCash()
            {
                Console.WriteLine("Please take your money");
            }

            public void RequestTakeCash()
            {
                Console.WriteLine("Please remember take your cash");
            }

            public void RequestContinuation()
            {
                Console.WriteLine("Do you do another transaction?");
            }

            public void PrintReceipt(Customer customer, Account account, ATMTransaction transaction)
            {
                Console.Write($"Atm ID: {ATMID}");
                Console.Write($"\nTransaction ID: {transaction.transactionID}");
                Console.Write($"\nCustomer Name: {customer.customerName}");
                Console.Write($"\nYour Balance: {account.Balance}");
                Console.WriteLine("\n Thanks for using our service!");
            }

            public bool ProcessTransaction(Customer customer)
            {
                if (customer.EnterAmount() > 0)
                return true;
                else return false;
            }
        }

        class Account {
            int PIN;
            double BALANCE;
            public Account(int pin, double Balance)
            {
                PIN = pin;
                BALANCE = Balance;
            }
            public int GetPIN()
            {
                return PIN;
            }

            public double Balance
            {
                get {return BALANCE;}
                set { value = BALANCE;}
            }

            public bool TransactionSuccessful(Customer customer)
            {
                double amount = customer.EnterAmount();
                Balance = Balance - amount;
                Console.WriteLine(" Transaction Successful!");
                return true;
            }


            public double WithdrawAmount(Customer customer)
            {
                double Amount = customer.EnterAmount();
                return Amount;
            }
        }

        class CheckingAccount 
        {
            public CheckingAccount()
            {

            }
            public bool WithdrawSuccessful(Account account, Customer customer)
            {
                double amount = customer.EnterAmount();
                if (account.Balance < amount)
                {
                    Console.WriteLine("Withdraw Sucessful...");
                    return false;
                }
                else
                {
                    Console.WriteLine("Withdraw UnSucessful...");
                    return true;
                } 
            }
        }

        class Card {

            Account Account;
            public Card()
            {
                Account = new Account(1234, 10000);
            }


            public Account GetAccount()
            {
                return Account;
            }
        }

        class ATMTransaction
        {
            public int transactionID;
            public ATMTransaction(int transactionID)
            {
                this.transactionID = transactionID;
            }
            
        }

        class Menu
        {
            public Menu()
            {

            }
            public void showMenu()
            {
                Console.WriteLine("Please choose options");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Exit");
            }
        }
        
        static void Main(string[] args)
        {
            Card myCard = new Card();
            ATM myATM = new ATM(1,100000);
            Customer myCustomer = new Customer("Huy");
            CheckingAccount myCheckingAccout = new CheckingAccount();
            Menu myMenu = new Menu();
            ATMTransaction myATMTransaction = new ATMTransaction(99);
            myCustomer.InsertCard(myCard, myATM);
            myMenu.showMenu();
            myCustomer.SelectOption(Convert.ToInt32(Console.ReadLine()));
            myCustomer.EnterAmount();
            myCustomer.TakeCash(myATM);
            myCustomer.Terminate();
            

            


            Console.ReadKey();
        }
    }
}