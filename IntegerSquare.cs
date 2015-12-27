using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class IntegerSquare
    {
        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int intCount = 0;

            if (B < 0)
            {
                // integer square cannot be negative
                return 0;
            }
            else if (A < 0)
            {
                // Set A = 0 to evalulate the positive range.
                A = 0;
            }

            // Find sqrt of the two integers
            double sqrtA = Math.Sqrt(A);
            double sqrtB = Math.Sqrt(B);

            // Find # of whole number betweent the two square-root values
            double lowestRange = Math.Ceiling(sqrtA);
            double upperRange = Math.Floor(sqrtB);

            intCount = Convert.ToInt32(upperRange) - Convert.ToInt32(lowestRange) + 1;

            return intCount;
        }
    }
}
