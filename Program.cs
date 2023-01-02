using SimpleEmployeeApp.Menus;
using System;
using System.IO;
using SimpleEmployeeApp.Entities;
using SimpleEmployeeApp.Repository;
using SimpleEmployeeApp.Enums;

namespace SimpleEmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================Welcome MGQS Employee App==========================");
            Menu menu = new Menu();
            menu.MyMenu();

            // var r = new EmployeeRepository();
            // r.AddToFile(e);

            // string path = @"C:\Users\Hp\Desktop\MGQS\Sample.txt";
            // StreamWriter writer = new StreamWriter(path, true);
            // writer.WriteLine("Welcome to file handling...");
            // writer.WriteLine("Thank you for keep showing up...");
            // writer.Flush();
            // writer.Close();
            // Console.WriteLine("Successfully created!");

            // var address = "No 4, Victoria Street, Sabo, Yaba, Lagos, NGA";

            // var newAdressSplit = address.Split(",");
            // foreach(var split in newAdressSplit)
            // {
            //     Console.WriteLine(split);
            // }
        }
    }
}