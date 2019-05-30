using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
        public class MainMenu
        {
            private List<MenuItem> m_MenuItems;

            public MainMenu(List<MenuItem> i_MenuItems)
            {
                m_MenuItems = i_MenuItems;
            }

            public void Start()
            {
                int userSelection;
                do
                {
                    MenusOperator.PrintMenu("Main Menu", m_MenuItems, "exit");
                    userSelection = MenusOperator.GetUserSelection(m_MenuItems.Count);
                    if (userSelection != -1)
                    {
                        m_MenuItems[userSelection].Item_Selected();
                    }
                }
            while (userSelection != -1);
            }
        }
    }
