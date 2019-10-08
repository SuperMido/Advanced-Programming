using System;
using System.Collections.Generic;

namespace PizzaOrder
{
    class Program
    {
        class Order
        {

        }

        abstract class Drink
        {

        }

        abstract class Franchise
        {

        }

        class Water : Drink
        {

        }

        class Wine : Drink
        {

        }

        class Lemonade : Drink
        {

        }

        class Shirt : Franchise
        {

        }

        class Mug : Franchise
        {

        }

        abstract class IPizza
        {
            double Price;
            string GetDescription;
            List<IToppings> Toppings;
            
            int toppingsPrice;

            public void AddChesse()
            {
                Toppings.Add(ToppingsFactory.AddCheese());
            }

            public void AddHam()
            {
                Toppings.Add(ToppingsFactory.AddHam());
            }

            public void AddOnions()
            {
                Toppings.Add(ToppingsFactory.AddOnions());
            }

            public void AddPineapple()
            {
                Toppings.Add(ToppingsFactory.AddPineapple());
            }

            public void AddSalami()
            {
                Toppings.Add(ToppingsFactory.AddSalami());
            }

            public double GetTopingsPrice(){
                double result = 0;
                foreach (var toping in Toppings){
                    result = result + toping.GetPrice();
                }

                return result;
            }

            public double GetPrice()
            {
                return Price + this.GetTopingsPrice();
            }

        }

         class MargheritaPizza : IPizza
        {
            double Price = 4.99;
     
            public string GetDescription()
            {
                return "Pizza Margherita (Tomato, cheese)";
            }
        }
        class SalamiPizza : IPizza
        {
            private readonly IPizza myPizza;

            public SalamiPizza(IPizza pizza)
            {
                myPizza = pizza;
            }
            public double Price()
            {
                return 0;
            }

        }

        class HawaiianPizza : IPizza
        {
            public double Price()
            {
                return 6.49;
            }
            public string GetDescription()
            {
                return "Hawaiian Pizza (Tomato, cheese, ham, pineapple)";
            }
        }

        public interface IToppings
        {
            double GetPrice();
            double GetCalories();

            void GetDescription();
            
        }

        public class Cheese : IToppings
        {
            public double GetPrice()
            {
                return  0.69;
            }

            public double GetCalories()
            {
                return 92;
            }

            public void GetDescription(){
                Console.WriteLine("Topping: Cheese");
            }
        }

        public class Ham : IToppings
        {
            public double GetPrice()
            {
                return  0.99;
            }

            public double GetCalories()
            {
                return 35;
            }
            public void GetDescription(){
                Console.WriteLine("Topping: Ham");
            }
            
        } 

        public class Onions : IToppings
        {
            public double GetPrice()
            {
                return  0.69;
            }

            public double GetCalories()
            {
                return 22;
            }
            public void GetDescription(){
                Console.WriteLine("Topping: Onions");
            }
        }

        public class Pineapple : IToppings
        {
            public double GetPrice()
            {
                return  0.79;
            }

            public double GetCalories()
            {
                return 24;
            }
            public void GetDescription(){
                Console.WriteLine("Topping: Pineapple");
            }
        }

        public class Salami : IToppings
        {
            public double GetPrice()
            {
                return  0.99;
            }

            public double GetCalories()
            {
                return 86;
            }
            public void GetDescription(){
                Console.WriteLine("Topping: Salami");
            }
        }

        public static class ToppingsFactory
        {
            public static IToppings AddCheese()
            {
                return new Cheese();
            }
            public static IToppings AddHam()
            {
                return new Ham();
            }
            public static IToppings AddOnions()
            {
                return new Onions();
            }
            public static IToppings AddPineapple()
            {
                return new Pineapple();
            }
            public static IToppings AddSalami()
            {
                return new Salami();
            }
        }
        static void Main(string[] args)
        {
            var cheese = ToppingsFactory.AddCheese();
            cheese.GetDescription();
            Console.WriteLine("Hello World!");
        }
    }
}
