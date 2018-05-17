using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private bool m_KeepLooping;
        private List<MenuItem> m_MenuItems;

        public SubMenu(string i_Text) : base(i_Text)
        {
            m_KeepLooping = true;
            m_MenuItems = new List<MenuItem>();
            m_MenuItems.Add(new ActionMenu("BackOrExit"));
            (m_MenuItems[0] as ActionMenu).Execution += OnZeroChoise;
        }

        protected void OnZeroChoise()
        {
            m_KeepLooping = false;
        }

        public virtual void Show()
        {
            Console.Clear();

            while (m_KeepLooping)
            {
                printMenu();
                GetUserInput();
            }
        }

        private void printMenu()
        {
            int i = 1;
            foreach (MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine("{0}. {1}", ++i, menuItem.Text);
            }

            showZeroOption();
        }

        protected virtual void showZeroOption()
        {
            Console.WriteLine("0. Back");
        }

        public void GetUserInput()
        {
            Console.WriteLine("Please enter your selection:");
            string choice = Console.ReadLine();

            while (true)
                try
                {
                    handleUserChoice(choice);
                    break;
                }
                catch
                {
                    Console.Clear();
                    printMenu();
                    Console.WriteLine("Invalid menu selection.\nTry again:");
                    choice = Console.ReadLine();
                }
        }

        private void handleUserChoice(string i_Option)
        {
            int choice = int.Parse(i_Option);

            if (choice >= 0 && choice < m_MenuItems.Count)
            {
                m_MenuItems[choice].OnClick();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuItem i_ItemToRemove)
        {
            bool removed = m_MenuItems.Remove(i_ItemToRemove);
            
            if(!removed)
            {
                Console.WriteLine("MenuItem wasn't found.");
            }
                
        }

        public override void OnClick()
        {
            Console.Clear();
            Show();
        }
    }
}
