// This is Learn from home Csharp second assignment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace LearnFromHome2
{
    //first program, for quadratic equation
    class GenerateX
    {
        double a, b, c;
 
        public void read()
        {
            Console.WriteLine("\n To find the roots of a quadratic equation of " + 
                              "the form a*x*x + b*x + c = 0");
            Console.WriteLine("\n Enter value for a : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter value for b : ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter value for c : ");
            c = double.Parse(Console.ReadLine());
        }
        public void solve()
        {
            int g;
            double x1, x2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0)
                g = 1;
            else if (d1 > 0)
                g = 2;
            else if (d1 == 0)
                g = 3;
            else
                g = 4;
            switch (g)
            {
                case 1: Console.WriteLine(@"\n Not a Quadratic equation, 
                                          Linear equation");
                    Console.ReadLine();
                    break;
                case 2: Console.WriteLine("\n Roots are Real and Distinct");
                    x1 = (-b + Math.Sqrt(d1)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d1)) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##}", x1);
                    Console.WriteLine("\n Second root is {0:#.##}", x2);
                    Console.ReadLine();
                    break;
                case 3: Console.WriteLine("\n Roots are Real and Equal");
                    x1 = x2 = (-b) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##}", x1);
                    Console.WriteLine("\n Second root is {0:#.##}", x2);
                    Console.ReadLine();
                    break;
                case 4: Console.WriteLine("\n Roots are Imaginary");
                    x1 = (-b) / (2 * a);
                    x2 = Math.Sqrt(-d1) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}", 
                                       x1, x2);
                    Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}", 
                                      x1, x2);
                    Console.ReadLine();
                    break;
            }
        }
    }
 
    class Roots
    {
        public static void Main()
        {
            GenerateX qr = new GenerateX(); //where did you get this from...
            qr.read(); //this questions are simple maths na...
            qr.solve(); //i will beat you Goodness
        }
    }

 // second program to generate to convert Fahrenheit to Celsius
    class celsiusFarenheit
    {
        static void Main1(string[] args)
        {
            double celsius;
            Console.WriteLine("Enter Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is" + celsius);
            Console.ReadLine();
        }

// third program to determine if user input is palindrone
    class Palindrome  
   {  
     public static void Main2(string[] args)  
      {  
          int n,r,sum=0,temp;    
          Console.WriteLine("Enter value: ");   
          n = int.Parse(Console.ReadLine());  
          temp=n;      
          while(n>0)      
          {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
          }      
          if(temp==sum)      
           Console.Write("Number is Palindrome.");      
          else      
           Console.Write("Number is not Palindrome");     
    }  
  } 
    }
}
