using System;
using System.Collections.Generic;

namespace Algorithms.Recursions
{
    public static class Permutation
    {
        static void RecPermute(string soFar, string rest)
        {
            if (String.IsNullOrEmpty(rest))
                Console.WriteLine(soFar);
            else
            {
                for (int i = 0; i < rest.Length; i++)
                {
                    var next = soFar + rest[i];
                    var remainig = rest.Substring(0, i) + rest.Substring(i + 1);

                    RecPermute(next, remainig);
                }
            }
        }

        public static void RecPermute(string s)
        {
            RecPermute(String.Empty, s);
        }
    }
}