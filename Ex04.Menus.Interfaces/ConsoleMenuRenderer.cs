using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    internal class ConsoleMenuRenderer
    {
        private const string k_TitlePrefix = "** ";
        private const string k_TitleSuffix = " **";
        private const string k_ExitOptionText = "0. Exit";
        private const string k_BackOptionText = "0. Back";
        private const string k_ExitSuffix = "or 0 to exit";
        private const string k_BackSuffix = "or 0 to go back";
        private const string k_InvalidChoiceMessage = "Invalid choice. Please try again.";
        private const string k_PromptPrefix = ">>";

        internal static void ClearScreen()
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }
        }

        internal static void PrintTitle(string i_Title)
        {
            string formattedTitle = string.Format("{0}{1}{2}", k_TitlePrefix, i_Title, k_TitleSuffix);

            if (!Console.IsOutputRedirected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(formattedTitle);
            if (!Console.IsOutputRedirected)
            {
                Console.ResetColor();
            }
            printSeparator(formattedTitle.Length);
        }

        internal static void PrintMenuItems(List<MenuItem> i_MenuItems)
        {
            int itemNumber = 1;

            foreach (MenuItem item in i_MenuItems)
            {
                Console.WriteLine(string.Format("{0}. {1}", itemNumber, item.Title));
                itemNumber++;
            }
        }

        internal static void PrintZeroOption(bool i_IsMainMenu)
        {
            if (i_IsMainMenu)
            {
                Console.WriteLine(k_ExitOptionText);
            }
            else
            {
                Console.WriteLine(k_BackOptionText);
            }
        }

        internal static void PrintChoiceRequest(int i_MinValue, int i_MaxValue, bool i_IsMainMenu)
        {
            if (i_MaxValue < i_MinValue)
            {
                Console.WriteLine(i_IsMainMenu ? "Please enter 0 to exit:" : "Please enter 0 to go back:");
                Console.Write("{0} ", k_PromptPrefix);
                return;
            }
            string zeroSuffix;

            if (i_IsMainMenu)
            {
                zeroSuffix = k_ExitSuffix;
            }
            else
            {
                zeroSuffix = k_BackSuffix;
            }

            Console.WriteLine(
                string.Format(
                    "Please enter your choice ({0}-{1} {2}):",
                    i_MinValue,
                    i_MaxValue,
                    zeroSuffix));
            Console.Write("{0} ", k_PromptPrefix);
        }

        internal static void PrintInvalidChoiceMessage()
        {
            Console.WriteLine(k_InvalidChoiceMessage);
        }

        private static void printSeparator(int i_Length)
        {
            for (int i = 0; i < i_Length; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine();
        }
    }
}
