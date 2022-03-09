using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4
{
    class Jag
    {
        int[][] ja = new int [3][];
        public void read()
        {
            Console.WriteLine("Enter the size of first inner Array");
            ja[0] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter the value of first");
            for (int i = 0; i < ja[0].Length; i++)
            {
                ja[0][i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of Second inner Array");
            ja[1] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter the value of Second");
            for (int i = 0; i < ja[1].Length; i++)
            {
                ja[1][i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of thrid inner Array");
            ja[2] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter the value of thrid");
            for (int i = 0; i < ja[2].Length; i++)
            {
                ja[2][i] = int.Parse(Console.ReadLine());
            }
        }
        public void findsum()
        {
            int sum = 0;
            for (int i = 0; i < ja[0].Length; i++)
            {
                sum = sum + ja[0][i];
            }
            for (int i = 0; i < ja[1].Length; i++)
            {
                sum = sum + ja[1][i];
            }
            for (int i = 0; i < ja[2].Length; i++)
            {
                sum = sum + ja[2][i];
            }
            Console.WriteLine("Sum of all the three inner array is ={0} " + sum);
        }
        public void print()
        {
            Console.WriteLine("\n Element of First inner Array");
            for (int i = 0; i < ja[0].Length; i++)
                Console.WriteLine(ja[0][i]);
            for (int i = 0; i < ja[1].Length; i++)
                Console.WriteLine(ja[1][i]);
            for (int i = 0; i < ja[2].Length; i++)
                Console.WriteLine(ja[2][i]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Jag j = new Jag();
            j.read();
            j.findsum();
            j.print();
            Console.ReadKey(); 
        }
    }
}
