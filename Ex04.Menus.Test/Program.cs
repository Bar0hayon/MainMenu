﻿using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            /////adding something
            Delegates.MainMenu DelegatesMainMenu = DelegatesBuilder.GetDelegatesMainMenu();
            DelegatesMainMenu.Start();

            Interfaces.MainMenu InterfacesMainMenu = (new InterfacesBuilder()).GetInterfacesMainMenu();
            InterfacesMainMenu.Start();
        }

        public static void ShowVersion_OnSelected()
        {
            print("Version: 19.2.4.32");
        }

        public static void CountDigits_OnSelected()
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

        public static void ShowDate_OnSelected()
        {
            print(string.Format("The Date is: {0}", DateTime.Now.Date));
        }

        public static void ShowTime_OnSelected()
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
