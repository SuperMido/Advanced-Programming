using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a +b;
        }

        public double Add(double a, double b, double c)
        {
            return a+b+c;
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a+b+c;
        }
    }

    public class Animal
    {
        private string name;
        private string favoriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return ($"I am {this.name} and my fovourite food is {this.favoriteFood}");
        }

    }

    public class Cat : Animal
    {
        public Cat(string Name, string FavouriteFood) : base(Name, FavouriteFood)
        {

        }

        public override string ExplainSelf()
        {

            return base.ExplainSelf() + "\nMEEOW";
        }
    }

    public class Dog : Animal
    {
        public Dog(string Name, string FavoriteFood) : base (Name, FavoriteFood)
        {

        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nDJAFF";
        }
    }

    public abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return "...";
        }
    }

    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get {return height; }
            set { height = value; }
        }

        public double Width
        {
            get {return width;}
            set {width = value;}
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter()
        {
            return (Width+Height)*2;
        }

        public override double CalculateArea()
        {
            return Width*Height;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get {return radius;}
            set {radius = value;}
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * 3.14;
        }

        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MathOperations myMathOperations = new MathOperations();
            Console.WriteLine(myMathOperations.Add(2,3));
            Console.WriteLine(myMathOperations.Add(2.2,3.3,5.5));
            Console.WriteLine(myMathOperations.Add(2.2m, 3.3m, 4.4m));
            Console.WriteLine();
            
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meet");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

            Shape myRectangle = new Rectangle(3,5);
            Shape myCircle = new Circle(5);
            Console.WriteLine();
            Console.Write("Area of Circle: ");
            Console.WriteLine(myCircle.CalculateArea());
            Console.Write("Perimeter of Circle: ");
            Console.WriteLine(myCircle.CalculatePerimeter());

            Console.WriteLine();

            Console.Write("Area of Rectangle: ");
            Console.WriteLine(myRectangle.CalculateArea());
            Console.Write("Perimeter of Rectangle: ");
            Console.WriteLine(myRectangle.CalculatePerimeter());

            
        }
    }
}
