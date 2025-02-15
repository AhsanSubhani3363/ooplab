using System;

namespace area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;

            Console.WriteLine("Enter length: ");
            l = Console.Read(); 
            int area = l * l; 
            Console.WriteLine("The area is: " + area); 
        }
    }
}
