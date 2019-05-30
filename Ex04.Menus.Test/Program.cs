using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            Delegates.MainMenu DelegatesMainMenu = DelegatesBuilder.GetDelegatesMainMenu();
            DelegatesMainMenu.Start();

            Interfaces.MainMenu InterfacesMainMenu = (new InterfacesBuilder()).GetMainMenu();
            InterfacesMainMenu.Start();
        }

        public static void ShowVersion_OnSelected(string i_ItemName)
        {
            print("Version: 19.2.4.32");
        }

        public static void CountDigits_OnSelected(string i_ItemName)
        {
            Console.WriteLine("Please enter a sentence: ");
            string UserInput = Console.ReadLine();
            int CountDigits = 0;
            foreach(char SingleCharacter in UserInput.ToCharArray())
            {
                if(SingleCharacter >= '0' && SingleCharacter <= '9')
                {
                    CountDigits++;
                }
            }
            print(string.Format("The sentence you entered contains {0} Digits", CountDigits));
        }

        public static void ShowDate_OnSelected(string i_ItemName)
        {
            print(string.Format("The Date is: {0}", DateTime.Now.Date));
        }

        public static void ShowTime_OnSelected(string i_ItemName)
        {
            print(string.Format("The Time is: {0}", DateTime.Now.TimeOfDay));
        }

        private static void print(string i_StringToPrint)
        {
            Console.WriteLine(i_StringToPrint);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
