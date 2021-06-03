using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatchingAlgorithm.Helper
{
    internal class KMPAlgorithm
    {
        internal void MatchString()
        {
            Console.Write("Enter the string : ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the string : ");
            string pattern = Console.ReadLine();

            int[] pie = new int[pattern.Length];
            int i = 0, j = 0;

            ComputeLPSArray(pattern, pattern.Length, pie);

            while (i < mainString.Length && j < pattern.Length)
            {
                if (pattern[j] == mainString[i])
                {
                    j++;
                    i++;
                }
                else
                {
                    if (j != 0)
                        j = pie[j - 1];
                    else
                        i++;
                }
            }

            if (j == pattern.Length)
            {
                Console.WriteLine($"Found pattern at index : {i - j}");
            }
            else
            {
                Console.WriteLine("Pattern not found");
            }
        }

        private void ComputeLPSArray(string patter, int M, int[] lps)
        {
            int len = 0, i = 1;
            lps[0] = 0;

            while (i < patter.Length)
            {
                if (patter[i] == patter[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}
