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
            while (!Int32.TryParse(input, out number)) {
                Console.WriteLine("Error: Please enter a number: ");
            }

            for (int i = 1; i<number+1; i++) {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
