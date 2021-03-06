﻿namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Text;

        protected internal MenuItem(string i_Text)
        {
            m_Text = i_Text;
        }

        protected internal abstract void OnClick();

        protected internal string Text
        {
            get
            {
                return m_Text;
            }
        }
    }
}