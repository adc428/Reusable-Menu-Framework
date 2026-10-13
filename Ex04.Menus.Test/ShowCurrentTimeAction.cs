using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowCurrentTimeAction : IMenuAction
    {
        public void Execute()
        {
            Console.WriteLine("Current Time is {0}", DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine();
        }
    }
}
