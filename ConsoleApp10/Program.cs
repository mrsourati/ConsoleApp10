﻿// See https://aka.ms/new-console-template for more information


namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
            }
            Console.WriteLine("Kollar om ändringen funkar igen");
        }
    }
}
