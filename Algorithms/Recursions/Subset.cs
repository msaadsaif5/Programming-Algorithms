using System;

namespace Algorithms.Recursions
{
    public static class Subset
    {
        public static void FindSubsets(string s)
        {
            RecSubsets(string.Empty, s);
        }

        static void RecSubsets(string soFar, string rest)
        {
            if (string.IsNullOrEmpty(rest))
                Console.WriteLine(soFar);
            else
            {
                RecSubsets(soFar + rest[0], rest.Substring(1));
                RecSubsets(soFar, rest.Substring(1));
            }
        }
    }
}