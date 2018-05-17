using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_Text;

        public MenuItem(string i_Text)
        {
            m_Text = i_Text;
        }

        public abstract void OnClick();

        public string Text
        {
            get
            {
                return m_Text;
            }
        }
    }
}
