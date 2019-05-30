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

        internal override void Item_Selected()
        {
            base.Item_Selected();
            bool IsFinalItem = false;
            int userSelection;
            do
            {
                MenusOperator.PrintMenu(m_Title, m_MenuItems, "Go Back");
                userSelection = MenusOperator.GetUserSelection(m_MenuItems.Count);
                if (userSelection != -1)
                {
                    Console.Clear();
                    m_MenuItems[userSelection].Item_Selected();
                    if(!(m_MenuItems[userSelection] is SubMenu))
                    {
                        IsFinalItem = true;
                    }
                }
            }
            while (!IsFinalItem && userSelection != -1);
        }
    }
}
