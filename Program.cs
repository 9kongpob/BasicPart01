using System;

namespace BasicPart01
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1995;
            string name = "Kongpop Kunchanuan";
            double points = 4.00;
            bool status = true;
            year = year + 543;
            string str = "400.59";
            double number;
            double.TryParse(str,out number);
            number = number + 6000;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("Grade : " + points);
            Console.WriteLine("Years : " + (year+10));
            Console.WriteLine("Status : " + status);
            Console.WriteLine("Result : " + number);
            Console.ReadKey();
        }
    }
}
