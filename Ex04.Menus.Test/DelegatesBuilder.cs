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
            List<Delegates.MenuItem> showDateOrTimeItems = new List<MenuItem>();
            showDateOrTimeItems.Add(new MenuItem("Show Time"));
            showDateOrTimeItems.Add(new MenuItem("Show Date"));
            showDateOrTimeItems[0].OnSelected += Program.ShowTime_OnSelected;
            showDateOrTimeItems[1].OnSelected += Program.ShowDate_OnSelected;
            SubMenu ShowDateOrTimeMenu = new SubMenu("Show Date/Time", showDateOrTimeItems);

            List<Delegates.MenuItem> versionAndDigitsItems = new List<MenuItem>();
            versionAndDigitsItems.Add(new MenuItem("Count Digits"));
            versionAndDigitsItems.Add(new MenuItem("Show Version"));
            versionAndDigitsItems[0].OnSelected += Program.CountDigits_OnSelected;
            versionAndDigitsItems[1].OnSelected += Program.ShowVersion_OnSelected;
            SubMenu VersionAndDigitsMenu = new SubMenu("Version and Digits", versionAndDigitsItems);

            List<Delegates.MenuItem> mainMenuItems = new List<MenuItem>();
            mainMenuItems.Add(ShowDateOrTimeMenu);
            mainMenuItems.Add(VersionAndDigitsMenu);

            return new MainMenu(mainMenuItems);
        }
    }
}
