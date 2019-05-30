using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    internal static class MenusOperator
    {
        internal static void PrintMenu(string i_Title, List<MenuItem> i_MenuItems, string i_getOutOfMenuString)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t{0}", i_Title);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Please choose one of the followings:");
            for (int i = 0; i < i_MenuItems.Count; i++) 
            {
                Console.WriteLine("\t{0}.{1}", (i + 1).ToString(), i_MenuItems[i].ToString());
            }

            Console.WriteLine("0.{0}", i_getOutOfMenuString);
        }

        internal static int GetUserSelection(int i_NumOfOptions)
        {
            string userSelectionAsString;
            int userSelection;
            bool isNumber;
            do
            {
                userSelectionAsString = Console.ReadLine();
                isNumber = int.TryParse(userSelectionAsString, out userSelection);
                if (!isNumber || userSelection < 0 || userSelection > i_NumOfOptions)
                {
                    Console.WriteLine("Value is not Valid!");
                    Console.WriteLine("Please enter a number between 0 to {0}:", i_NumOfOptions);
                }
            }
            while (!isNumber || userSelection < 0 || userSelection > i_NumOfOptions);

            return userSelection - 1;
        }
    }
}
