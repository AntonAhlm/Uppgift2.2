using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många meter hoppade Elin? ");
            double Elin = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hur många meter hoppade Alma? ");
            double Alma = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Elin hoppade " + (Elin - Alma) + " meter längre än Alma");  

        }
    }
}
