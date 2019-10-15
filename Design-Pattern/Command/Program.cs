using System;

namespace Command
{
    class Garage
    {
        private string garageName;
        public Garage(string garageName)
        {
            this.garageName = garageName;
        }

        bool checkedOpen = false;

        public void Open()
        {
            if (checkedOpen == true)
            {
                Console.WriteLine($"{garageName} --> Garage is alredy Opened!");
            }
            else
            {
                Console.WriteLine($"{garageName} --> Garage Opened!");
                checkedOpen = true;
            }
            
        }

        public void Close()
        {
            if (checkedOpen == true)
            {
                Console.WriteLine($"{garageName} --> Garage Closed!");
                checkedOpen = false;
            }
            else
            {
                Console.WriteLine($"{garageName} --> Garage is alredy Closed!");
            }
            
        }
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class GarageOpen : ICommand
    {
        private Garage myGarage;

        public GarageOpen(Garage garage)
        {
            myGarage = garage;
        }

        public void Execute()
        {
            myGarage.Open();
        }

        public void Undo()
        {
            myGarage.Close();
        }
    }

    class GarageClose : ICommand
    {
        private Garage myGarage;

        public GarageClose(Garage garage)
        {
            myGarage = garage;
        }

        public void Execute()
        {
            myGarage.Close();
        }

        public void Undo()
        {
            myGarage.Open();
        }
    }

    class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }

        public void Show()
        {
            Console.WriteLine("==== Remote Garage ====");
            Console.WriteLine("[1]. Open garage");
            Console.WriteLine("[2]. Close garage");
            Console.WriteLine("[3]. Quit");
            Console.Write("Option: ");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var myGarage = new Garage("Huy Tran's Garage");

            var openGarage = new GarageOpen(myGarage);
            var CloseGarage = new GarageClose(myGarage);

            var myRemote = new RemoteControl();

            int choose;

            myRemote.Show();
            choose = Int32.Parse(Console.ReadLine());            
            while(choose != 3)
            {
                switch(choose)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        myRemote.Submit(openGarage);
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        myRemote.Submit(CloseGarage);
                        Console.ResetColor();
                        break;
                    case 3:
                        break;
                }
                if (choose == 3) break;
                Console.WriteLine();
                myRemote.Show();
                choose = Int32.Parse(Console.ReadLine());  
            }
            

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
