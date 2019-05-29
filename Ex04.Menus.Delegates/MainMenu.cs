using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
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
            int UserSelection;
            do
            {
                MenusOperator.printMenu("Main Menu", m_MenuItems, "exit");
                UserSelection = MenusOperator.GetUserSelection(m_MenuItems.Count);
                if (UserSelection != -1)
                {
                    m_MenuItems[UserSelection].item_Selected();
                }
            } while (UserSelection != -1);
        }
    }
}
