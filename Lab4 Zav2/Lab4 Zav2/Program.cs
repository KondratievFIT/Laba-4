using System;
using System.Diagnostics;

namespace Lab4_Zav2
{
    class A
    {
        
        public static int number;
        public static int count = 0;
        public static string input,str1;
        public static double PointOFnumber;
        public static bool TrueORfalse, True;
        public static char symbol;
        public A(string information)
        {
            Input = information;
        }
        public static string Input
        {
            get
            {
                return Input;
            }
            set
            {
                str1 = value;
                True = int.TryParse(str1, out number);
                if (True == true)
                {
                    value = value + " " + "Тип:число (int)";
                }
                True = double.TryParse(str1, out PointOFnumber);
                if (True == true)
                {
                    value = value + " " + "Тип:десяткове число(double)";
                }
                True = char.TryParse(str1, out symbol);
                if (True == true)
                {
                    value = value + " " + "Тип:символ(char)";
                }
                True = bool.TryParse(str1, out TrueORfalse);
                if (True == true)
                {
                    value = value + " " + "Тип:булеан(bool)";
                }
                if (count == 0)
                {
                    value = value + " " + "Тип:рядок(string)";
                }
                input = "Значення: " + value + " Модифікатор доступа: public";
            }
        }
        public static void Show1()
        {
            Trace.WriteLine(input);
        }
    }

    public class Argument
    {
        protected static string argument;
        public static void Show()
        {
            Console.WriteLine("Введіть аргумент: ");
            argument = Console.ReadLine();
        }
    }
    public class Argument1 : Argument
    {
        public static string argument1;
        public Argument1()
        {
            Show();
            argument1 = argument;
        }
    }
    public class Argument2 : Argument
    {
        public static string argument2;
        public Argument2()
        {
            Show();
            argument2 = argument;
        }
    }
    public class Argument3 : Argument
    {
        public static string argument3;
        public Argument3()
        {
            Show();
            argument3 = argument;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Argument1 A1 = new Argument1();
            Argument2 B1 = new Argument2();
            Argument3 C1 = new Argument3();
            string information;
            information = Argument1.argument1;
            A Example1 = new A(information);
            A.Show1();
            information = Argument2.argument2;
            A Example2 = new A(information);
            A.Show1();
            information = Argument3.argument3;
            A Example3 = new A(information);
            A.Show1();
        }
    }
}
