using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void Notifier();
    public class MenuItem
    {
        protected string m_Title;
        public event Notifier OnSelected;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        internal virtual void item_Selected()
        {
            if (OnSelected != null)
            {
                OnSelected.Invoke();
            }
        }

        public override string ToString()
        {
            return m_Title;
        }
    }
}
