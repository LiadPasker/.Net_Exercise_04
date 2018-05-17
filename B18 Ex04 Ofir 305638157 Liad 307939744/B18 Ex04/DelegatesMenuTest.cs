using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class DelegatesMenuTest
    {
        private MainMenu m_MainMenu;
        private string m_MainMenuText = "Delegates Menu";

        private void showTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        private void showDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());

        }

        private void countCapitals()
        {
            {
                int upperCaseLetters = 0;
                Console.WriteLine("Please type a sentence:");
                string inputSentence = Console.ReadLine();

                for (int i = 0; i < inputSentence.Length; ++i)
                {
                    if (char.IsUpper(inputSentence[i]))
                    {
                        ++upperCaseLetters;
                    }
                }

                Console.WriteLine("The input sentence contains {0} uppercase letters.", upperCaseLetters);
            }
        }

        private void showVersion()
        {
            Console.WriteLine("Version: 18.2.4.0");
        }

        private void buildMainMenu()
        {
            ActionMenu showTimeActionItem = new ActionMenu("Show Time");
            ActionMenu showDateActionItem = new ActionMenu("Show Date");
            ActionMenu countCapitalsActionItem = new ActionMenu("Count Capitals");
            ActionMenu showVersionActionItem = new ActionMenu("Show Version");
            showTimeActionItem.Execution += showTime;
            showDateActionItem.Execution += showDate;
            countCapitalsActionItem.Execution += countCapitals;
            showVersionActionItem.Execution += showVersion;
            SubMenu dateTimeSubMenu = new SubMenu("Show Date / Time");
            SubMenu versionAndCapitalsSubMenu = new SubMenu("Version and Capitals");
            dateTimeSubMenu.AddMenuItem(showTimeActionItem);
            dateTimeSubMenu.AddMenuItem(showDateActionItem);
            versionAndCapitalsSubMenu.AddMenuItem(countCapitalsActionItem);
            versionAndCapitalsSubMenu.AddMenuItem(showVersionActionItem);
            m_MainMenu.AddMenuItem(dateTimeSubMenu);
            m_MainMenu.AddMenuItem(versionAndCapitalsSubMenu);
        }

        public DelegatesMenuTest()
        {
            m_MainMenu = new MainMenu(m_MainMenuText);
        }

        public void Show()
        {
            buildMainMenu();
            m_MainMenu.Show();
        }
    }
}