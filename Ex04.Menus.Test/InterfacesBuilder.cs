using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesBuilder : ISelectedListener
    {
        public MainMenu GetInterfacesMainMenu()
        {
            List<MenuItem> ShowDateOrTimeItems = new List<MenuItem>();
            ShowDateOrTimeItems.Add(new MenuItem("Show Time"));
            ShowDateOrTimeItems.Add(new MenuItem("Show Date"));
            ShowDateOrTimeItems[0].AddOnSelectedListener(this);
            ShowDateOrTimeItems[1].AddOnSelectedListener(this);
            SubMenu ShowDateOrTimeMenu = new SubMenu("Show Date/Time", ShowDateOrTimeItems);

            List<MenuItem> VersionAndDigitsItems = new List<MenuItem>();
            VersionAndDigitsItems.Add(new MenuItem("Count Digits"));
            VersionAndDigitsItems.Add(new MenuItem("Show Version"));
            VersionAndDigitsItems[0].AddOnSelectedListener(this);
            VersionAndDigitsItems[1].AddOnSelectedListener(this);
            SubMenu VersionAndDigitsMenu = new SubMenu("Version and Digits", VersionAndDigitsItems);

            List<MenuItem> MainMenuItems = new List<MenuItem>();
            MainMenuItems.Add(ShowDateOrTimeMenu);
            MainMenuItems.Add(VersionAndDigitsMenu);

            return new MainMenu(MainMenuItems);
        }

        public virtual void OnSelected(string i_ItemTitle)
        {
            switch (i_ItemTitle)
            {
                case ("Show Time"):
                    Program.ShowTime_OnSelected();
                    break;
                case ("Show Date"):
                    Program.ShowDate_OnSelected();
                    break;
                case ("Count Digits"):
                    Program.CountDigits_OnSelected();
                    break;
                case ("Show Version"):
                    Program.ShowVersion_OnSelected();
                    break;
                default:
                    break;
            }
        }
    }
}
