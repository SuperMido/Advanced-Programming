using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

     public class Point
    {
     
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Rectangle 
    {
        private Point topleft;
        private Point bottomRight;
        public Point TopLeft
        {
            get 
            {
                return topleft; 
            }
            set 
            { 
                topleft = value; 
            }
        }

        public Point BottomRight
        {
            get 
            { 
                return bottomRight; 
            }
            set 
            { 
                bottomRight = value;  
            }
        }

        public Rectangle(Point x, Point y)
        {
            this.topleft = x;
            this.bottomRight = y;
        }

        public bool Contains(Point point)
        {
            if (point.X <= BottomRight.X && point.X >= TopLeft.X && point.Y <= BottomRight.Y && point.Y >= TopLeft.Y)
            {
                return true;
            }
            else return false;
        }
    }
    public class studentInfomation
    {
        private string studentName;
        private int studentAge;
        private decimal studentGrade;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentAge
        {
            get {return studentAge; }
            set {studentAge = value;}
        }
        public decimal StudentGrade
        {
            get {return studentGrade;}
            set {studentGrade = value;}
        }
        public studentInfomation (string stdName, int stdAge, decimal stdGrade)
        {
            StudentName = stdName;
            StudentAge = stdAge;
            StudentGrade = stdGrade;
        }
        public override string ToString()
        {
            string comentary;
            if(studentGrade >5)
                comentary = "Excellent student";
                else comentary = "Average student";
            Console.ForegroundColor = ConsoleColor.Blue;    
            Console.Write("{0}", StudentName);
            Console.Write(" is {0}", StudentAge);
            Console.Write(" years old. {0}", comentary);
            Console.WriteLine();
            Console.ResetColor();
            return base.ToString();
        }

    }

    public class PriceCalculator
    {
        private decimal priceperday;
        private int numberofdays;
        public decimal pricePerDay
        {
            get { return priceperday; }
            set { priceperday = value; }
        }

        public int numberOfDays
        {
            get { return numberofdays; }
            set {numberofdays = value; }
        }

        public void priceCalculator(decimal price, int days, int seasonPick, decimal discountTypePick)
       {
            decimal totalPrice;
            totalPrice = price*days*seasonPick*discountTypePick;
            Console.Write("Total price of the holiday: {0}", totalPrice);
       } 
       public void priceCalculator(decimal price, int days, int seasonPick)
       {
            decimal totalPrice;
            totalPrice = price*days*seasonPick;
            Console.Write("Total price of the holiday: {0}", totalPrice);
       } 

    }

    enum season 
    {
        Autumn = 1, 
        Spring = 2, 
        Winter = 3, 
        Summer = 4
    }
    enum discountType
    {
        VIP = 8, 
        SecondVisit = 9
    }    
    class Program
    {
        // static void PrintRow(int n)
        // {
        //     int CountTop = n -1;
        //     for (int i =1; i<= n; i++)
        //     {
        //         for (int k = CountTop; k >= 1; k--)
        //             Console.Write(" ");
        //         for (int j = 1;j <= i; j++)
        //             Console.Write("* ");
        //         Console.WriteLine();
        //         CountTop--;
        //     }
        //     int CountDown = 1;
        //     for (int i = n; i > 1; i--)
        //     {
        //         for (int k = i; k<= n; k++)
        //             Console.Write(" ");
        //         for (int j = 1; j <= i-1; j++)
        //             Console.Write("* ");
        //         Console.WriteLine();
        //         CountDown++;
        //     }
            
        // }
        List<studentInfomation> StdInfo;

        public Program()
        {
            StdInfo = new List<studentInfomation>();
        }
            
        public void addStudent(string addStdName,int addStdAge, decimal addStdGrade)
        {
            StdInfo.Add(new studentInfomation(addStdName,addStdAge,addStdGrade));
        }
        
        static void Main(string[] args)
        {
            /*Console.Write("Input n: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            PrintRow(n);
            Console.WritPriceCalculator myPrice = new PriceCalculator(); 
            int seasonTotal=1;
            decimal discountTotal=1;
            Console.Write("Input information about the reservation: ");
            string res = Console.ReadLine();
            string[] resArr = res.Split(' ').ToArray();
            if ( resArr[2] == "Autumn")
            {
                seasonTotal = (int)season.Autumn;
            }
            if ( resArr[2] == "Spring")
            {
                seasonTotal = (int)season.Spring;
            }
            if ( resArr[PriceCalculator myPrice = new PriceCalculator(); 
            int seasonTotal=1;
            decimal discountTotal=1;
            Console.Write("Input information about the reservation: ");
            string res = Console.ReadLine();
            string[] resArr = res.Split(' ').ToArray();
            if ( resArr[2] == "Autumn")
            {
                seasonTotal = (int)season.Autumn;
            }
            if ( resArr[2] == "Spring")
            {
                seasonTotal = (int)season.Spring;
            }
            if ( resArr[2] == "Winter")
            {
                seasonTotal = (int)season.Winter;
            }
            if ( resArr[2] == "Summer")
            {
                seasonTotal = (int)season.Summer;
            }
            if ( resArr[3] == "VIP")
            {
                discountTotal = (decimal)discountType.VIP/10;
            }
            if ( resArr[3] == "SecondVisit")
            {
                discountTotal = (decimal)discountType.SecondVisit/10;
            }
            if (resArr[3] == "")
            {
                myPrice.priceCalculator(Convert.ToDecimal(resArr[0]),Convert.ToInt32(resArr[1]) , seasonTotal);
            }else  myPrice.priceCalculator(Convert.ToDecimal(resArr[0]),Convert.ToInt32(resArr[1]) , seasonTotal,discountTotal);2] == "Winter")
            {
                seasonTotal = (int)season.Winter;
            }
            if ( resArr[2] == "Summer")
            {
                seasonTotal = (int)season.Summer;
            }
            if ( resArr[3] == "VIP")
            {
                discountTotal = (decimal)discountType.VIP/10;
            }
            if ( resArr[3] == "SecondVisit")
            {
                discountTotal = (decimal)discountType.SecondVisit/10;
            }
            if (resArr[3] == "")
            {
                myPrice.priceCalculator(Convert.ToDecimal(resArr[0]),Convert.ToInt32(resArr[1]) , seasonTotal);
            }else  myPrice.priceCalculator(Convert.ToDecimal(resArr[0]),Convert.ToInt32(resArr[1]) , seasonTotal,discountTotal);eLine("================");*/


            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.Write("Rectagnel format: TopLeftX TopLeftY BottomRightX BottomRightY\n");
            // Console.ResetColor();
            // Console.Write("Input the Rectagle: ");
            // string coor = Console.ReadLine();
            // int[] arr = coor.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            // Point TopLeft = new Point(arr[0], arr[1]);
            // Point BottomRight = new Point(arr[2], arr[3]);
            // Rectangle rectangle = new Rectangle(TopLeft,BottomRight);
            // Console.Write("Input amount coordinates of points that you wanted to check: ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine();
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.Write("Point format: x y\n");
            // Console.ResetColor();
            // for(int i = 0; i < n; i++)
            // {
            //     Console.Write("Input your point {0}: ", i+1);
            //     string y = Console.ReadLine();
            //     int[] coorP = y.Split(' ').Select(b => Convert.ToInt32(b)).ToArray();
            //     Point point = new Point(coorP[0], coorP[1]);
            //     Console.Write("Result: ");
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     Console.Write(rectangle.Contains(point));
            //     Console.ResetColor();
            //     Console.WriteLine();
            // }


            
            // Console.Write("Please input your commands: ");
            // string cmd = Console.ReadLine();
            // string[] cmdArr = cmd.Split(' ').ToArray();
            // while (cmdArr[0] != "Exit")
            // {
            //     if (cmdArr[0] == "Create")
            //     {
            //     myProgram.addStudent(cmdArr[1],Convert.ToInt32(cmdArr[2]),Convert.ToDecimal(cmdArr[3]));
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     Console.WriteLine("Student information has been created");
            //     Console.ResetColor();
            //     }
            //     if (cmdArr[0] == "Show")
            //     {
            //         myProgram.StdInfo.Find(x => x.StudentName == cmdArr[1]).ToString();
            //     }

            //     if (cmdArr[0] == "Exit") break;

            //     Console.Write("Please input your commands: ");
            //     cmd = Console.ReadLine();
            //     cmdArr = cmd.Split(' ').ToArray();
            // }
            

            PriceCalculator myPrice = new PriceCalculator(); 
            int seasonTotal=1;
            decimal discountTotal=1;
            Console.Write("Input information about the reservation: ");
            string res = Console.ReadLine();
            string[] resArr = res.Split(' ').ToArray();
            if ( resArr[2] == "Autumn")
            {
                seasonTotal = (int)season.Autumn;
            }
            if ( resArr[2] == "Spring")
            {
                seasonTotal = (int)season.Spring;
            }
            if ( resArr[2] == "Winter")
            {
                seasonTotal = (int)season.Winter;
            }
            if ( resArr[2] == "Summer")
            {
                seasonTotal = (int)season.Summer;
            }
            if ( resArr[3] == "VIP")
            {
                discountTotal = (decimal)discountType.VIP/10;
            }
            if ( resArr[3] == "SecondVisit")
            {
                discountTotal = (decimal)discountType.SecondVisit/10;
            }
            if (resArr[3] == "")
            {
                myPrice.priceCalculator(Convert.ToDecimal(resArr[0]),Convert.ToInt32(resArr[1]) , seasonTotal);
            }else  myPrice.priceCalculator(Convert.ToDecimal(resArr[0]),Convert.ToInt32(resArr[1]) , seasonTotal,discountTotal);

           
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
