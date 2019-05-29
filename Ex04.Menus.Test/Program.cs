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
            Delegates.MainMenu DelegatesMainMenu = getDelegatesMainMenu();
            DelegatesMainMenu.Start();

            InterfacesBuilder interfacesBuilder = new InterfacesBuilder();
            Interfaces.MainMenu InterfacesMainMenu = interfacesBuilder.GetMainMenu();
            InterfacesMainMenu.Start();
        }

        private static MainMenu getDelegatesMainMenu()
        {
            List<Delegates.MenuItem> ShowDateOrTimeItems = new List<MenuItem>();
            ShowDateOrTimeItems.Add(new MenuItem("Show Time"));
            ShowDateOrTimeItems.Add(new MenuItem("Show Date"));
            ShowDateOrTimeItems[0].OnSelected += ShowTime_OnSelected;
            ShowDateOrTimeItems[1].OnSelected += ShowDate_OnSelected;
            SubMenu ShowDateOrTimeMenu = new SubMenu("Show Date/Time", ShowDateOrTimeItems);

            List<Delegates.MenuItem> VersionAndDigitsItems = new List<MenuItem>();
            VersionAndDigitsItems.Add(new MenuItem("Count Digits"));
            VersionAndDigitsItems.Add(new MenuItem("Show Version"));
            VersionAndDigitsItems[0].OnSelected += CountDigits_OnSelected;
            VersionAndDigitsItems[1].OnSelected += ShowVersion_OnSelected;
            SubMenu VersionAndDigitsMenu = new SubMenu("Version and Digits", VersionAndDigitsItems);

            List<Delegates.MenuItem> MainMenuItems = new List<MenuItem>();
            MainMenuItems.Add(ShowDateOrTimeMenu);
            MainMenuItems.Add(VersionAndDigitsMenu);

            return new MainMenu(MainMenuItems);
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
