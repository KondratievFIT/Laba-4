using System;

namespace Lab4_Zav4
{
    class ApplicationLicense
    {
        static private void AllowTrial()
        {
            Console.WriteLine("Пробна версія");
        }
        static private void AllowPro()
        {
            Console.WriteLine("Платна версія"); 
        }
        static private void AllowCommon()
        {
            Console.WriteLine("Активована безкоштовна версія");
        }
        public ApplicationLicense(string key)
        {
            if (key == "111")
            {
                AllowTrial();
            }
            else if (key == "222")
            {
                AllowPro();
            }
            else
            {
                AllowCommon();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть ключ доступа: Пробна версія-(111),Платна версія-(222)");
            Console.WriteLine("Якщо не має ключа натисніть Enter ");
            string key = Console.ReadLine();
            ApplicationLicense license = new ApplicationLicense(key);
        }
    }
}
