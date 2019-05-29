using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems;

        public SubMenu(string i_Title, List<MenuItem> i_MenuItems) : base(i_Title)
        {
            m_MenuItems = i_MenuItems;
        }

        internal override void item_Selected()
        {
            base.item_Selected();
            bool IsFinalItem = false;
            int UserSelection;
            do
            {
                MenusOperator.printMenu(m_Title, m_MenuItems, "Go Back");
                UserSelection = MenusOperator.GetUserSelection(m_MenuItems.Count);
                if (UserSelection != -1)
                {
                    Console.Clear();
                    m_MenuItems[UserSelection].item_Selected();
                    if(!(m_MenuItems[UserSelection] is SubMenu))
                    {
                        IsFinalItem = true;
                    }
                }
            } while (!IsFinalItem && UserSelection != -1);
        }
    }
}
