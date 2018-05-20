using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : SubMenu
    {
        protected override void ShowZeroOption()
        {
            Console.WriteLine("{0}0. Exit{0}", Environment.NewLine);
        }

        public MainMenu(string i_Text) : base(i_Text)
        {
        }
    }
}