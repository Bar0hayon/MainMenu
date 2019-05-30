using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal static class DelegatesBuilder
    {
        internal static MainMenu GetDelegatesMainMenu()
        {
            List<Delegates.MenuItem> ShowDateOrTimeItems = new List<MenuItem>();
            ShowDateOrTimeItems.Add(new MenuItem("Show Time"));
            ShowDateOrTimeItems.Add(new MenuItem("Show Date"));
            ShowDateOrTimeItems[0].OnSelected += Program.ShowTime_OnSelected;
            ShowDateOrTimeItems[1].OnSelected += Program.ShowDate_OnSelected;
            SubMenu ShowDateOrTimeMenu = new SubMenu("Show Date/Time", ShowDateOrTimeItems);

            List<Delegates.MenuItem> VersionAndDigitsItems = new List<MenuItem>();
            VersionAndDigitsItems.Add(new MenuItem("Count Digits"));
            VersionAndDigitsItems.Add(new MenuItem("Show Version"));
            VersionAndDigitsItems[0].OnSelected += Program.CountDigits_OnSelected;
            VersionAndDigitsItems[1].OnSelected += Program.ShowVersion_OnSelected;
            SubMenu VersionAndDigitsMenu = new SubMenu("Version and Digits", VersionAndDigitsItems);

            List<Delegates.MenuItem> MainMenuItems = new List<MenuItem>();
            MainMenuItems.Add(ShowDateOrTimeMenu);
            MainMenuItems.Add(VersionAndDigitsMenu);

            return new MainMenu(MainMenuItems);
        }
    }
}
