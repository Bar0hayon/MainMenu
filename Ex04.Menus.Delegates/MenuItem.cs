using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        protected string m_Title;
        public event Action<string> OnSelected;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        internal virtual void item_Selected()
        {
            if (OnSelected != null)
            {
                OnSelected.Invoke(m_Title);
            }
        }

        public override string ToString()
        {
            return m_Title;
        }
    }
}
