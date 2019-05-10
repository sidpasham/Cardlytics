using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIntegersPrimeFactors
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\sadhas\Desktop\PrimeFactors.txt";
            getPrimeFactorsFromFile(path);
        }

        public static void getPrimeFactorsFromFile(string path)
        {

            var listrecords = File.ReadAllLines(path);

            foreach (var record in listrecords)
            {
                int num;
                if (int.TryParse(record, out num))
                {
                    // Get the number's factors.
                    List<int> factors = FindFactors(num);

                    // Display the factors.
                    List<string> strings = factors.ConvertAll(x => x.ToString());
                    Console.WriteLine(string.Join(",", strings.ToArray()));
                }
            }

        }

        // Return the number's prime factors.
        public static List<int> FindFactors(int? input)
        {
            List<int> result = new List<int>();

            if (input != null && input > 0)
            {
                int number = Convert.ToInt32(input);

                // Take out the 2s.
                while (number % 2 == 0)
                {
                    result.Add(2);
                    number /= 2;
                }

                // Take out other primes.
                int factor = 3;
                while (factor * factor <= number)
                {
                    if (number % factor == 0)
                    {
                        // This is a factor.
                        result.Add(factor);
                        number /= factor;
                    }
                    else
                    {
                        // Go to the next odd number.
                        factor += 2;
                    }
                }

                // If number is not 1, then whatever is left is prime.
                if (number > 1) result.Add(number);


            }

            return result;
        }
    }
}
