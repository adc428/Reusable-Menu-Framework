using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    internal class Menu
    {
        private readonly string r_Title;
        private readonly List<MenuItem> r_Items;
        private readonly bool r_IsMainMenu;

        internal Menu(string i_Title, bool i_IsMainMenu)
        {
            if (string.IsNullOrWhiteSpace(i_Title))
            {
                throw new ArgumentException("Menu title cannot be empty.", "i_Title");
            }
            r_Title = i_Title;
            r_IsMainMenu = i_IsMainMenu;
            r_Items = new List<MenuItem>();
        }

        internal void AddMenuItem(MenuItem i_MenuItem)
        {
            r_Items.Add(i_MenuItem);
        }

        internal void Show()
        {
            bool userWantsToLeave = false;
            int userChoice = 0;

            while (!userWantsToLeave)
            {
                renderMenu();
                userChoice = readUserChoice();

                if (userChoice == 0)
                {
                    userWantsToLeave = true;
                }
                else
                {
                    r_Items[userChoice - 1].Execute();
                }
            }
        }

        private void renderMenu()
        {
            ConsoleMenuRenderer.PrintTitle(r_Title);
            ConsoleMenuRenderer.PrintMenuItems(r_Items);
            ConsoleMenuRenderer.PrintZeroOption(r_IsMainMenu);
            ConsoleMenuRenderer.PrintChoiceRequest(1, r_Items.Count, r_IsMainMenu);
        }

        private int readUserChoice()
        {
            bool isValidChoice = false;
            int userChoice = 0;

            while (!isValidChoice)
            {
                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    return 0;
                }
                bool isParsed = int.TryParse(userInput, out userChoice);
                isValidChoice = isParsed && userChoice >= 0 && userChoice <= r_Items.Count;

                if (!isValidChoice)
                {
                    ConsoleMenuRenderer.PrintInvalidChoiceMessage();
                    ConsoleMenuRenderer.PrintChoiceRequest(1, r_Items.Count, r_IsMainMenu);
                }
            }

            return userChoice;
        }
    }
}
