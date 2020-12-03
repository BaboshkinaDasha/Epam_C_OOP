using System;

namespace FirstLabBaboshkina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to work with arrays(1) or a calculator(2)?\n(Enter 1 or 2)");
            int choice;
            choice = int.Parse(Console.ReadLine());
            if (choice < 2)
            {
                Console.WriteLine("WORKING WITH AN ARRAY");
                LabArray();
            }
            else
            {
                Console.WriteLine("CALCULATOR");
                Calc();
            }
        }
            static void LabArray()
        {
            try
            {
                int x;
                Console.WriteLine("\nEnter a size:");
                x = int.Parse(Console.ReadLine());
                double[] arr;
                arr = new double[x];
                Console.WriteLine("Enter {0} numbers: ", x);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} number? ", i + 1);
                    arr[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nArray output:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                }
                double y;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            y = arr[i];
                            arr[i] = arr[j];
                            arr[j] = y;
                        }
                    }
                }
                Console.WriteLine("\nSorted array output:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input! Please, enter a number!");
                LabArray();
            }
        }
        static void Calc()
        {
            try
            {
                string want;
                do
                {
                    double x, y, rez;
                    string oper;
                    rez = 0;
                    Console.WriteLine("\nEnter the first number: ");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter math operation(+,-,*,/): ");
                    oper = Console.ReadLine();
                    if (y == 0 && Equals(oper, "/"))
                    {
                        Console.WriteLine("You cannot divide by zero!");
                    }
                    else
                        {
                        Console.WriteLine("Expression value: ");
                        switch (oper)
                        {
                            case "+":
                                rez = x + y;
                                Console.WriteLine("{0} {1} {2} = {3}", x, oper, y, rez);
                                break;
                            case "-":
                                rez = x - y;
                                Console.WriteLine("{0} {1} {2} = {3}", x, oper, y, rez);
                                break;
                            case "*":
                                rez = x * y;
                                Console.WriteLine("{0} {1} {2} = {3}", x, oper, y, rez);
                                break;
                            case "/":
                                rez = x / y;
                                Console.WriteLine("{0} {1} {2} = {3}", x, oper, y, rez);
                                break;
                        }
                        }
                    Console.WriteLine("Do you want to continue computing?(yes or no)");
                        want = Console.ReadLine();
                }
                while (Equals(want, "yes"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input! Please, enter a number!");
                Calc();
            }
        }
    }
}