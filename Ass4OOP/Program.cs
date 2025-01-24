using System.IO;

namespace Ass4OOP
{
    internal class Program
    {

        #region Part01

        #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to: 
        //internal class Calculator
        //{ 
        //    public int Add (int x , int y)
        //    {
        //      return x + y;
        //    }
        //    public int Add (int x , int y , int z)
        //    {
        //        return x + y + z;
        //    }
        //    public double Add(double a, double b)
        //    {
        //        return a + b;
        //    }

        //}
        #endregion

        #region Q2) Create a class named Rectangle with the following constructors: 
        //internal class Rectangle
        //{
        //    public int Width {  get; set; }
        //    public int Height { get; set; }

        //    public Rectangle()
        //    {
        //        Width = 0;
        //        Height = 0;
        //    }
        //    public Rectangle (int _width, int _height)
        //    {
        //        this.Width = _width;
        //        this.Height = _height;
        //    }
        //    public Rectangle (int _length)
        //    {
        //        this.Width = _length;
        //        this.Height = _length;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine($"Width: {Width}, Height: {Height}");
        //    }
        //}
        #endregion

        #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
        //internal class Complex
        //{
        //    public int Real { get; set; }
        //    public int Imag { get; set; }

        //    public static Complex operator + (Complex left , Complex right)
        //    {
        //        return new Complex()
        //        {
        //            Real = (left?.Real ?? 0) + (right?.Real ?? 0),
        //            Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
        //        };
        //    }

        //    public static Complex operator - (Complex left, Complex right)
        //    {
        //        return new Complex()
        //        {
        //            Real = (left?.Real ?? 0) - (right?.Real ?? 0),
        //            Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
        //        };
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Real} + {Imag}i";
        //    }
        //}
        #endregion

        #region Q4) a) Create a base class named Employee with method That Work as it prints "Employee is  working".
        //internal class Employee
        //{
        //    public virtual void Work()
        //    {
        //        Console.WriteLine("Employee is  working");
        //    }
        //}

        //internal class Manager : Employee
        //{
        //    public override void Work()
        //    {
        //        base.Work();

        //        Console.WriteLine("Manager is managing");
        //    }
        //}

        #endregion

        #region Q5) a) Create a base class BaseClass with a virtual method DisplayMessage that prints "Message from BaseClass". 
        ///**/ When a derived class overrides a virtual method using the override keyword it changes the method's implementation
        ///When the New keyword is used the derived class hides the base class method and don't override it.
        /// **/

        //internal class BaseClass
        //{
        //    public virtual void DisplayMessage()
        //    {
        //        Console.WriteLine("Message from BaseClass");
        //    }
        //}

        //internal class DerivedClass1 : BaseClass 
        //{
        //    public override void DisplayMessage()
        //    {
        //        Console.WriteLine("Message from DerivedClass1");
        //    }
        //}

        //internal class DerivedClass2 : BaseClass
        //{
        //    public new void DisplayMessage()
        //    {
        //        Console.WriteLine("Message from DerivedClass2");
        //    }
        //}
        #endregion

        #endregion


        #region Part02

        internal class Duration
        {
            #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds. 
            public int Hours {  get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public Duration (int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }
            #endregion

            #region 2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] 
            public override string ToString()
            {
                return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
            }

            public override bool Equals(object? obj)
            {
                if (obj is Duration obj2)
                {
                    return this.Hours == obj2.Hours &&
                           this.Minutes == obj2.Minutes &&
                           this.Seconds == obj2.Seconds;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Hours, Minutes, Seconds);
            }
            #endregion

            #region 3-Define All Required Constructors to Produce this output: 

            #endregion
        }


        #endregion

        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Sum of 2 integers: " + calculator.Add(1,2));    
            //Console.WriteLine("Sum of 3 integers: " + calculator.Add(1,2,3));    
            //Console.WriteLine("Sum of 2 doubles: " + calculator.Add(4.5,5.5));

            /*---------------------------------------------------------------------------------*/

            //Rectangle r1 = new Rectangle();
            //Rectangle r2 = new Rectangle(10,20);
            //Rectangle r3 = new Rectangle(15);

            //Console.WriteLine("Rectangle 1");
            //r1.Display();

            //Console.WriteLine("\nRectangle 2:");
            //r2.Display();

            //Console.WriteLine("\nRectangle 3:");
            //r3.Display();

            /*---------------------------------------------------------------------------------*/

            //Complex c1 = new Complex() { Real = 1, Imag = 2 };
            //Complex c2 = new Complex() { Imag = 3, Real = 4 };
            //Complex c3 = default;
            //Complex c4 = default;

            //c3 = c1 + c2;
            //c4 = c3 - c2;

            //Console.WriteLine($"C1 = {c1}");
            //Console.WriteLine($"C2 = {c2}");
            //Console.WriteLine($"C3 after addition = {c3}");
            //Console.WriteLine($"C4 after subtraction = {c4}");

            /*---------------------------------------------------------------------------------*/

            //Employee emp = new Employee();
            //emp.Work();

            //Console.WriteLine("-------------------------");

            //Manager manager = new Manager();
            //manager.Work();

            /*---------------------------------------------------------------------------------*/

            //BaseClass c = new DerivedClass1();
            //BaseClass c2 = new DerivedClass2();

            //c.DisplayMessage();
            //c2.DisplayMessage();

            /*---------------------------------------------------------------------------------*/

            //Duration d1 = new Duration(1, 30, 45);
            //Duration d2 = new Duration(1, 30, 45);
            //Duration d3 = new Duration(3, 15, 30);

            //Console.WriteLine("Duration d1: " + d1);
            //Console.WriteLine("Duration d2: " + d2);
            //Console.WriteLine("Duration d3: " + d3);

            //// Test Equals()
            //Console.WriteLine("\nd1 equals d2: " + d1.Equals(d2)); // true
            //Console.WriteLine("d1 equals d3: " + d1.Equals(d3)); // false

            //// Test GetHashCode()
            //Console.WriteLine("\nd1 hash code: " + d1.GetHashCode());
            //Console.WriteLine("d2 hash code: " + d2.GetHashCode());
            //Console.WriteLine("d3 hash code: " + d3.GetHashCode());

            /*---------------------------------------------------------------------------------*/


        }
    }
}
