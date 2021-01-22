using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // homework 1
            // 1
            var A = 2;
            var B = 2;
            if (A == B)
            {
                A = B = 0;
            }
            else
            {
                A = B = (A > B) ? A : B;
            }
            Console.WriteLine($"A={A}; B={B}");

            // 2
            var operand1 = 1.0;
            var operand2 = 2.0;
            Console.Write("enter sign: ");
            var sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("division by zero is not allowed");
                        break;
                    }
                    Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 / operand2}");
                    break;
                default:
                    Console.WriteLine("invalid sign");
                    break;
            }

            // 3
            Console.Write("enter number: ");
            var isParsed = int.TryParse(Console.ReadLine(), out var number);
            if (!isParsed)
            {
                Console.WriteLine("invalid input");
                return;
            }
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("in range of [0 - 14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("in range of [15 - 35]");
            } 
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("in range of [36 - 50]");
            } 
            else if (number >= 50 && number <= 100)
            {
                Console.WriteLine("in range of [50 - 100]");
            }
            else
            {
                Console.WriteLine("not in range");
            }



            // homework 2
            // 1
            Console.Write("enter total price: ");
            double.TryParse(Console.ReadLine(), out var amount);
            var discount = 0.0;
            // 1000 is included or not ?
            if (amount > 1000 )
            {
                discount = 0.05;
            }
            // 500 is included or not ?
            else if (amount > 500)
            {
                discount = 0.03;
            }
            Console.WriteLine($"payment amount: {amount - (amount * discount)}");

            // 2
            var num1 = 1;
            var num2 = 2;
            var num3 = 3;
            var num4 = 4;
            if (num1 == num2 && num2 == num3 && num3 == num4)
            {
                Console.WriteLine(Math.Pow(num1, 4));
            }
            else if (num1 < num2 && num2 < num3 && num3 < num4 )
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine("Числа расположены по возрастанию");
            }

            // 3
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out var a);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out var b);
            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out var c);

            void swap(ref double a, ref double b)
            {
                double t;
                t = b;
                b = a;
                a = t;
            }

            if (a >= b && a >= c && c >= b)
            {
                swap(ref b, ref c);
            }
            else if (b >= a && b >= c && a >= c)
            {
                swap(ref a, ref b);
            }
            else if (b >= c && b >= a && c >= a)
            {
                swap(ref a, ref c);
                swap(ref b, ref c);
            }
            else if (c >= b && c >= a && b >= a)
            {
                swap(ref c, ref a);
            }
            else if (c >= b && c >= a && a >= b)
            {
                swap(ref c, ref a);
                swap(ref a, ref b);
            }
            Console.WriteLine($"{a}>={b}>={c}");
        }
    }
}
