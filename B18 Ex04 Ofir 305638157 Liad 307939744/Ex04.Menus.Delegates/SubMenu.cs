using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private const int BACKOREXIT = 0;
        private bool m_KeepLooping;
        private List<MenuItem> m_MenuItems;

        private void printMenu()
        {
            Console.WriteLine(m_Text);
            for (int i = 0; i < m_Text.Length; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            for (int i = 1; i < m_MenuItems.Count; i++)
            {
                Console.Write("{0}{1}. {2}", Environment.NewLine, i, m_MenuItems[i].Text);
            }

            Console.WriteLine();
            ShowZeroOption();
        }

        private void getUserInput()
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
                    Console.WriteLine("Invalid menu selection.{0}Try again:", Environment.NewLine);
                    choice = Console.ReadLine();
                }
        }

        private void handleUserChoice(string i_Option)
        {
            int choice = int.Parse(i_Option);

            if (choice >= BACKOREXIT && choice < m_MenuItems.Count)
            {
                m_MenuItems[choice].OnClick();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        protected internal override void OnClick()
        {
            Console.Clear();
            Show();
        }

        protected void OnZeroChoise()
        {
            m_KeepLooping = false;

            if (this is MainMenu)
            {
                Console.WriteLine("See you...");
                Thread.Sleep(1000);
            }
        }

        protected virtual void ShowZeroOption()
        {
            Console.WriteLine("{0}0. Back{0}", Environment.NewLine);
        }

        public SubMenu(string i_Text) : base(i_Text)
        {
            m_KeepLooping = true;
            m_MenuItems = new List<MenuItem>();
            m_MenuItems.Add(new ActionMenu("BackOrExit"));
            (m_MenuItems[0] as ActionMenu).Execution += OnZeroChoise;
        }

        public void Show()
        {
            while (m_KeepLooping)
            {
                Console.Clear();
                printMenu();
                getUserInput();
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuItem i_MenuItem)
        {
            bool removed = m_MenuItems.Remove(i_MenuItem);
            
            if(!removed)
            {
                Console.WriteLine("MenuItem wasn't found.");
            }     
        }
    }
}