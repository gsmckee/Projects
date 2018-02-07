using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    
    class Program
    {
        protected float a = 5;
        protected float b = 6;
        protected float c = 10;
        protected float d = 1;
        private string hello = "Hello";
        private string world = "World";
        private string answer;
        private char ans;
        private char yes = 'Y';
        private char no = 'N';
        private bool isNum;
        static void Main(string[] args)
        {
            Program p = new Program();
            Equations equate = new Equations();
            //Subtract(a,b);
            Console.WriteLine("Hello World");
            Console.WriteLine(p.hello + " " + p.world);
            Console.WriteLine("Enter a valid whole number ");
            Console.WriteLine("Other than Base");
            p.isNum = float.TryParse(Console.ReadLine(), out p.a);
            if (p.isNum == true)
            {
                //p.a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your second whole number /r/n Base");
                p.isNum = float.TryParse(Console.ReadLine(), out p.b);
                if (p.isNum == true)
                {
                    //p.b = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Is this a trapezoid? (Y/N)");
                    p.answer = Console.ReadLine();
                    p.ans = char.ToUpper(p.answer[0]);
                    if (p.ans == 'Y')
                    {
                        Console.WriteLine("Your third whole number /r/n Base 2");
                        p.isNum = float.TryParse(Console.ReadLine(), out p.c);
                        if (p.isNum == true)
                        {
                            Console.WriteLine("Subtraction: " + p.Subtract(p.a, p.b));
                            Console.WriteLine("Addition: " + p.Add(p.a, p.b));
                            Console.WriteLine("Division: " + p.Divide(p.a, p.b));
                            Console.WriteLine("Multiplication: " + p.Multiply(p.a, p.b));
                            Console.WriteLine("Area of Square: " + equate.AreaSquare(p.a));
                            Console.WriteLine("Area of Rectangle: " + equate.AreaRect(p.a, p.b));
                            Console.WriteLine("Area of Triangle: " + equate.AreaTriangle(p.a, p.b));
                            Console.WriteLine("Area of Trapezoid: " + equate.AreaTrapezoid(p.a, p.b, p.c));
                        }
                        else { Console.WriteLine("Not a valid number"); }
                    }
                    else
                    {
                        Console.WriteLine("Subtraction: " + p.Subtract(p.a, p.b));
                        Console.WriteLine("Addition: " + p.Add(p.a, p.b));
                        Console.WriteLine("Division: " + p.Divide(p.a, p.b));
                        Console.WriteLine("Multiplication: " + p.Multiply(p.a, p.b));
                        Console.WriteLine("Area of Square: " + equate.AreaSquare(p.a));
                        Console.WriteLine("Area of Rectangle: " + equate.AreaRect(p.a, p.b));
                        Console.WriteLine("Area of Triangle: " + equate.AreaTriangle(p.a, p.b));
                    }

                }
            }
            else { Console.WriteLine("Try again"); }            
            Console.Read();
        }
        public float Subtract(float a, float b)
        {
            this.a = a;
            this.b = b;
            float c = a - b;
            return c;
        }
        public float Add(float a, float b)
        {
            this.a = a;
            this.b = b;
            float c = a + b;
            return c;
        }
        public float Divide(float a, float b)
        {
            this.a = a;
            this.b = b;
            float c = a / b;
            return c;
        }
        public float Multiply(float a, float b)
        {
            this.a = a;
            this.b = b;
            float c = a * b;
            return c;
        }

    }
}
