using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try4 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number;
            int sum = 0;

            while (!Int32.TryParse(input, out number)) {
                Console.WriteLine("Error: Please enter a number: ");
            }

            for (int i = 1; i<number+1; i++) {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine("The sum is: " + sum);
            Console.ReadKey();
        }

    }
}
