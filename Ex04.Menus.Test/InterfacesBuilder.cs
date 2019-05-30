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
            List<MenuItem> showDateOrTimeItems = new List<MenuItem>();
            showDateOrTimeItems.Add(new MenuItem("Show Time"));
            showDateOrTimeItems.Add(new MenuItem("Show Date"));
            showDateOrTimeItems[0].AddOnSelectedListener(this);
            showDateOrTimeItems[1].AddOnSelectedListener(this);
            SubMenu ShowDateOrTimeMenu = new SubMenu("Show Date/Time", showDateOrTimeItems);

            List<MenuItem> versionAndDigitsItems = new List<MenuItem>();
            versionAndDigitsItems.Add(new MenuItem("Count Digits"));
            versionAndDigitsItems.Add(new MenuItem("Show Version"));
            versionAndDigitsItems[0].AddOnSelectedListener(this);
            versionAndDigitsItems[1].AddOnSelectedListener(this);
            SubMenu VersionAndDigitsMenu = new SubMenu("Version and Digits", versionAndDigitsItems);

            List<MenuItem> mainMenuItems = new List<MenuItem>();
            mainMenuItems.Add(ShowDateOrTimeMenu);
            mainMenuItems.Add(VersionAndDigitsMenu);

            return new MainMenu(mainMenuItems);
        }

        public virtual void OnSelected(string i_ItemTitle)
        {
            switch (i_ItemTitle)
            {
                case "Show Time":
                    Program.ShowTime_OnSelected();
                    break;
                case "Show Date":
                    Program.ShowDate_OnSelected();
                    break;
                case "Count Digits":
                    Program.CountDigits_OnSelected();
                    break;
                case "Show Version":
                    Program.ShowVersion_OnSelected();
                    break;
            }
        }
    }
}
