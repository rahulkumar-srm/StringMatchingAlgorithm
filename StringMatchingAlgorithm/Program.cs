using StringMatchingAlgorithm.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatchingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine
                    (Environment.NewLine + "Please select an option" +
                        Environment.NewLine + "1. String Matching(KMP)" +
                        Environment.NewLine + "0. Exit"
                    );

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine(Environment.NewLine + "Input format is not valid. Please try again." + Environment.NewLine);
                }

                if (i == 0)
                {
                    Environment.Exit(0);
                }
                else if (i == 1)
                {
                    KMPAlgorithm kMPAlgorithm = new KMPAlgorithm(); //ababcabcabababd, ababd
                    kMPAlgorithm.MatchString();
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }


            }
        }
    }
}
