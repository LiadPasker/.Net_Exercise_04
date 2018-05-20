using System;
using System.Threading;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private const int BACKOREXIT = 0;
        private bool m_KeepLooping;
        private List<MenuItem> m_MenuItems;

        private void printMenu()
        {
            Console.WriteLine(this.m_Text);
            for (int i = 0; i < this.m_Text.Length; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.Write("{0}{1}. {2}", Environment.NewLine, (i + 1), m_MenuItems[i].Text);
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

            if (choice > BACKOREXIT && choice <= m_MenuItems.Count)
            {
                m_MenuItems[choice - 1].OnClick();
            }
            else if (choice == BACKOREXIT)
            {
                OnZeroChoise();
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
            Console.Clear();
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
            m_MenuItems = new List<MenuItem>();
            m_KeepLooping = true;
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

            if (!removed)
            {
                Console.WriteLine("MenuItem wasn't found.");
            }

        }
    }
}