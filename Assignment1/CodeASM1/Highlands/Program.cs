using System;

namespace Highlands
{
    //Code so 1
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }

    //Code so 2

    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string getDescription();
    }

    //Code so 3
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double cost()
        {
            return 1.2;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double cost()
        {
            return 1.4;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double cost()
        {
            return 1.7;
        }
    }


    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.9;
        }
    }

    //Code so 4
    public class SteamedMilk : CondimentDecorator
    {
        Beverage myBeverage;

        public SteamedMilk(Beverage beverage)
        {
            myBeverage = beverage;
        }

        public override string getDescription()
        {
            return $"{myBeverage.getDescription()}, Steamed Milk";
        }

        public override double cost()
        {
            return myBeverage.cost() + 0.20;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage myBeverage;

        public Mocha(Beverage beverage)
        {
            myBeverage = beverage;
        }

        public override string getDescription()
        {
            return myBeverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return myBeverage.cost() + 0.30;
        }
    }

    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return beverage.cost() + 0.25;
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage myBeverage;

        public Whip(Beverage beverage)
        {
            myBeverage = beverage;
        }

        public override string getDescription()
        {
            return myBeverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return myBeverage.cost() + 0.20;
        }
    }
    class Program
    {

        //code so 5
        static void Main(string[] args)
        {
            Beverage myBeverage = new Espresso();
            Console.WriteLine($"{myBeverage.getDescription()}: ${myBeverage.cost()}");

            Beverage myBeverage2 = new DarkRoast();
            myBeverage2 = new Mocha(myBeverage2);
            myBeverage2 = new Mocha(myBeverage2);
            myBeverage2 = new Whip(myBeverage2);
            Console.WriteLine($"{myBeverage2.getDescription()}: ${myBeverage2.cost()}");

            Beverage myBeverage3 = new HouseBlend();
            myBeverage3 = new Soy(myBeverage3);
            myBeverage3 = new Mocha(myBeverage3);
            myBeverage3 = new Whip(myBeverage3);
            Console.WriteLine($"{myBeverage3.getDescription()}: ${myBeverage3.cost()}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
