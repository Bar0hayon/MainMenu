using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        protected string m_Title;
        private List<ISelectedListener> m_OnSelectedListeners = new List<ISelectedListener>();

        public void AddOnSelectedListener(ISelectedListener i_ListenerToAdd)
        {
            m_OnSelectedListeners.Add(i_ListenerToAdd);
        }

        public void RemoveOnSelectedListener(ISelectedListener i_ListenerToRemove)
        {
            m_OnSelectedListeners.Remove(i_ListenerToRemove);
        }

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        internal virtual void item_Selected()
        {
            foreach(ISelectedListener listener in m_OnSelectedListeners)
            {
                listener.OnSelected(m_Title);
            }
        }

        public override string ToString()
        {
            return m_Title;
        }
    }
}
