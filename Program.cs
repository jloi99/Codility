using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            DecimalZip d = new DecimalZip();

            Console.WriteLine(String.Format("{0} and {1} is {2}", 100, 23456, d.solution(100, 23456)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 123, 456, d.solution(123, 456)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 12345, 678, d.solution(12345, 678)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 0, 1234, d.solution(0, 1234)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 12345, 0, d.solution(12345, 0)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 12345, 67890, d.solution(12345, 67890)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 100000000, 0, d.solution(100000000, 0)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 10000000, 0, d.solution(10000000, 0)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 0, 10000000, d.solution(0, 10000000)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 0, 0, d.solution(0, 0)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 0, 1, d.solution(0, 1)));
            Console.WriteLine(String.Format("{0} and {1} is {2}", 1, 0, d.solution(1, 0)));
 
            Console.ReadLine();
        }

    }
}
