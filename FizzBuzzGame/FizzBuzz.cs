using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string ShowResult()
        {
            if (!int.TryParse(Console.ReadLine(), out int fizzbuzz))
            {
                Console.WriteLine("Podaj prawidłową wartość.");
                return "";
            }
            if (fizzbuzz % 3 == 0 && fizzbuzz % 5 == 0)
                return "FizzBuzz\n";
            if (fizzbuzz % 5 == 0)
                return "Buzz\n";
            if (fizzbuzz % 3 == 0)
                return "Fizz\n";
            return fizzbuzz.ToString(); 
        }
    }
}
