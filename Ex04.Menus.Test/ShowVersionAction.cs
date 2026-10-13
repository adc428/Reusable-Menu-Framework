using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersionAction : IMenuAction
    {
        private const string k_Version = "App Version: 26.2.4.7310";

        public void Execute()
        {
            Console.WriteLine(k_Version);
            Console.WriteLine();
        }
    }
}
