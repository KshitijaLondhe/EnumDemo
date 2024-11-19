using System;


namespace EnumDemo
{
    internal class Program
    {
        //interchange value by call by value
        static void SwapValues(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void SwapValues1(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Cacl(int x, int y, out int add, out int multiply)
        {
            add = x + y;
            multiply = x * y;
        }

        static void Main(string[] args)
        {
            //code for enum
            // Emp e1 = new Emp(101, "Raj", Department.Testing,Roles.Manager);
            //Console.WriteLine(e1);

            //code for struct
            /* Dept d1 = new Dept(101, "Development");
             Console.WriteLine(d1.Print());
             Console.WriteLine();
             var d2 = new Dept(102, "Testing");
             Console.WriteLine(d2.Print());

             Console.WriteLine();
             Coordinates c1 = new Coordinates(10, 20);
             c1.Print();
             Console.WriteLine();
             var c2 = new Coordinates(70, 80);
             c2.Print();
            */

            //code for ref keyword
            /*int a = 100;
            int b = 200;
            Console.WriteLine($"Before swapping:a={a} b={b}");
            SwapValues(a, b);
            Console.WriteLine($"After swapping:a={a} b={b}");

            Console.WriteLine($"Before swapping:a={a} b={b}");
            SwapValues1(ref a, ref b);
            Console.WriteLine($"After swapping:a={a} b={b}");

            //code for out keyword
            int x = 3, y = 5, add, mul ; 
            // add & mul are the empty variables
            Cacl(x,y,out add,out mul);
            Console.WriteLine("add "+add);
            Console.WriteLine("multiply "+multiply);

             // ref variable can not be empty
            // out variable can be empty
            */

            //code for extension method
            Calculation c1 = new Calculation();
            Console.WriteLine("Multiplication:"+c1.Multiply(3, 6));
            Console.WriteLine("Addition:"+c1.Add(10, 20));


        }
    }
}
