using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class DecimalZip
    {
        public int solution(int A, int B)
        {
            int result = -1;
            int intMax = 100000000;

            // convert all int to string
            string strA = A.ToString();
            string strB = B.ToString();
            string strMax = intMax.ToString();

            // length of two given integer
            int lengthA = strA.Length;
            int lengthB = strB.Length;

            // check for length limit
            if (A == 0 && lengthB >= strMax.Length)
            {
                return -1; 
            }

            if (A > 0 && (lengthA + lengthB) >= strMax.Length)
            {
                return -1;
            }

            // loop through length of A to extract digit from both strings
            string strResult = string.Empty;
            for (int i = 0; i < lengthA; i++)
            {
                strResult += strA[i];
                // add char from B 
                if (i < lengthB)
                {
                    strResult += strB[i];
                }
            }
            // add any remaining string in B
            if (lengthA < lengthB)
                strResult += strB.Substring(lengthA);

            // convert result to int
            result = int.Parse(strResult);
            return result;
        }
    }
}
