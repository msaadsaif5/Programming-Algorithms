using System;

namespace RecursivePermute
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter any string to calculate its permutations.");
                string s = Console.ReadLine();

                RecPermute(s);

                Console.WriteLine("Well, that was easy, give me a tough one!");
            }
        }

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

        static void RecPermute(string s)
        {
            RecPermute(String.Empty, s);
        }
    }
}
