using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int palindromeIndex(string s)
    {
        int maxIndex = s.Length / 2;

        for (int i = 0; i < maxIndex; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                if (s.Substring(i + 1, 2) == Reverse(s.Substring((s.Length - 1 - i) - 1, 2)))
                {
                    return i;
                }
                else
                {
                    return (s.Length - 1 - i);
                }

                return i;
            }
        }

        return -1;
    }

    static string Reverse(string str)
    {
        string reverse = "";
        int Length = 0;
        Length = str.Length - 1;
        while (Length >= 0)
        {
            reverse = reverse + str[Length];
            Length--;
        }
        return reverse;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

            Console.WriteLine(result);
        }
    }
}
