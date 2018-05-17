using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private const int BACKOREXIT = 0;
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

            if(this is MainMenu)
            {
                Console.WriteLine("See you...");
                Thread.Sleep(1000);
            }
        }

        public virtual void Show()
        {
            while (m_KeepLooping)
            {
                Console.Clear();
                printMenu();
                GetUserInput();
            }
        }

        private void printMenu()
        {
            Console.WriteLine(this.m_Text);
            for (int i=0;i<this.m_Text.Length;i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            for (int i=1; i< m_MenuItems.Count; i++)
            {
                Console.Write("\n{0}. {1}", i, m_MenuItems[i].Text);
            }

            Console.WriteLine();
            showZeroOption();
        }

        protected virtual void showZeroOption()
        {
            Console.WriteLine("\n0. Back\n");
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

            if (choice >= BACKOREXIT && choice < m_MenuItems.Count)
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
