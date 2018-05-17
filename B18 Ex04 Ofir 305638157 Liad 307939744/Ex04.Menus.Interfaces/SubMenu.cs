using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems;

        public SubMenu(string i_Text)
        {
            m_Text = i_Text;
        }

        public void Show()
        {

        }

        public void GetUserInput()
        {

        }

        public override void OnClick()
        {
            Console.Clear();
            showMenuItems();
        }

        private void showMenuItems()
        {
            for (int i = 0; i < m_MenuItems.Count; ++i)
            {
                Console.WriteLine("{0}. {1}", i + 1, m_MenuItems[i].Text);
            }
        }
    }
}
