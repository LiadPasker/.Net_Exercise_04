using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenu
    {
        public MainMenu(string i_Text) : base(i_Text)
        {
        }

        protected override void showZeroOption()
        {
            Console.WriteLine("\n0. Exit\n");
        }
    }
}
