using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems;

        public SubMenu(string i_Text) : base(i_Text)
        {
        }

        public virtual void Show()
        {
            Console.Clear();

            int i = 1;
            foreach(MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine("{0}. {1}", ++i, menuItem.Text);
            }
        }

        public void GetUserInput()
        {
            Console.WriteLine("Please select one of the following:");
            int option = int.Parse(Console.ReadLine());


        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public override void OnClick()
        {
            Console.Clear();
            Show();
        }
    }
}
