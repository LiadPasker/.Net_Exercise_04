using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : SubMenu
    {
        public MainMenu(string i_Text) : base(i_Text)
        {
        }

        protected override void showZeroOption()
        {
            // Console.WriteLine("0. Exit");
        }
    }
}
