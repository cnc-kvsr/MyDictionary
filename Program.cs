using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customers = new MyDictionary<int, string>();
            customers.Add(1, "Kevser");
            customers.Add(2, "Nagehan");
            customers.Add(3, "Kağan");

            foreach (var item in customers.Id)
            {
                Console.WriteLine($"Customer Id: {item}");

            }
            foreach (var item2 in customers.FirstName)
            {
                Console.WriteLine($"Customer Name: {item2}");
            }
           
           
        }
    }
}
