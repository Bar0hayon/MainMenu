using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Delegates.MainMenu delegatesMainMenu = DelegatesBuilder.GetDelegatesMainMenu();
            delegatesMainMenu.Start();

            Interfaces.MainMenu interfacesMainMenu = (new InterfacesBuilder()).GetInterfacesMainMenu();
            interfacesMainMenu.Start();
        }

        public static void ShowVersion_OnSelected()
        {
            print("Version: 19.2.4.32");
        }

        public static void CountDigits_OnSelected()
        {
            Console.WriteLine("Please enter a sentence: ");
            string userInput = Console.ReadLine();
            int countDigits = 0;
            foreach(char SingleCharacter in userInput.ToCharArray())
            {
                if(SingleCharacter >= '0' && SingleCharacter <= '9')
                {
                    countDigits++;
                }
            }

            print(string.Format("The sentence you entered contains {0} Digits", countDigits));
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
