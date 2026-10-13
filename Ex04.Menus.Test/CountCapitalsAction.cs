using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class CountCapitalsAction : IMenuAction
    {
        public void Execute()
        {
            Console.WriteLine("Please enter a sentence:");

            string sentence = Console.ReadLine() ?? string.Empty;
            int capitalCount = 0;

            foreach (char letter in sentence)
            {
                if (char.IsUpper(letter))
                {
                    capitalCount++;
                }
            }

            Console.WriteLine("There are {0} uppercase letters in your text", capitalCount);
            Console.WriteLine();
        }
    }
}
