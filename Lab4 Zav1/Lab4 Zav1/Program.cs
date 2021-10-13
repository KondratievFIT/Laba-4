using System;
using System.Diagnostics;

namespace Lab4_Zav1
{
    class Input
    {
        static public string input;
        static public void output()
        {
            Console.WriteLine("Введіть данні: ");
            input = Console.ReadLine();
        }
    }
    class Date : Input
    {
        private static double pointOFnumber;
        private static int number;
        private static bool True;
        private static bool TrueORFalse;
        private static char symbol;
        static private void Test()
        {
            True = double.TryParse(input, out pointOFnumber);
            if(True == true)
            {
                Trace.WriteLine("http://Типданних double");
            }
            True = int.TryParse(input, out number);
            if(True == true)
            {
                Trace.WriteLine("http://Типданних int");
            }
            True = bool.TryParse(input, out TrueORFalse);
            if (True == true)
            {
                Trace.WriteLine("http://Типданних bool");
            }
            True = char.TryParse(input, out symbol);
            if (True == true)
            {
                Trace.WriteLine("http://Типданних char");
            }
            else
            {
                Trace.WriteLine("http://Типданних string");
            }
        }
        static public void Output()
        {
            Trace.WriteLine(input);
            Test();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Input.output();
            Date.Output();

        }
    }
}
