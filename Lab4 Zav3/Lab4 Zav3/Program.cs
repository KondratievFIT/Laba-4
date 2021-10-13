using System;
using System.Diagnostics;

namespace Lab4_Zav3
{
    class StudentID
    {
        static public string Name = "Київський національний торговельно-економічний університет";
        static public int KV = 65729412, group = 7;
        static public string issued = "15.09.2020 ", valid = "30.06.2024", name = "Петро", surname = "Петров", lastname = "Петрович";
        static public string faculty = "ФІТ";
    }
    class Card : StudentID
    {
        static public string admission = "public";
        public Card()
        {
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + Name.GetTypeCode() + " Назва змінної: Name " + "Значення: " + Name);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + KV.GetTypeCode() + " Назва змінної: KV " + "Значення: " + KV);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + issued.GetTypeCode() + " Назва змінної: issued " + "Значення: " + issued);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + valid.GetTypeCode() + " Назва змінної: valid " + "Значення: " + valid);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + name.GetTypeCode() + " Назва змінної: name " + "Значення: " + name);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + surname.GetTypeCode() + " Назва змінної: surname " + "Значення: " + surname);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + lastname.GetTypeCode() + " Назва змінної: lastname " + "Значення: " + lastname);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + faculty.GetTypeCode() + " Назва змінної: faculty " + "Значення: " + faculty);
            Trace.WriteLine("Тип доступа: " + admission + " Тип данних: " + group.GetTypeCode() + " Назва змінної: group " + "Значення: " + group);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Card A = new Card();
        }
    }
}
