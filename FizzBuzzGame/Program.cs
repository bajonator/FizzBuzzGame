using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FizzBuzz fizzBuzz = new FizzBuzz();

                Console.WriteLine("Wpisz Liczbę:");
                var userNumber = fizzBuzz.ShowResult();
                Console.WriteLine(userNumber.ToString());
            }
        }
    }
}
