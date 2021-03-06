﻿using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesMenuTest
    {
        private MainMenu m_MainMenu;
        private string m_MainMenuText = "Interfaces Menu";

        private void buildMainMenu()
        {
            m_MainMenu = new MainMenu(m_MainMenuText);
            SubMenu dateTimeSubMenu = new SubMenu("Show Date / Time");
            SubMenu versionAndCapitalsSubMenu = new SubMenu("Version and Capitals");
            dateTimeSubMenu.AddMenuItem(new ActionMenu("Show Time", new ShowTime()));
            dateTimeSubMenu.AddMenuItem(new ActionMenu("Show Date", new ShowDate()));
            versionAndCapitalsSubMenu.AddMenuItem(new ActionMenu("Count Capitals", new CountCapitals()));
            versionAndCapitalsSubMenu.AddMenuItem(new ActionMenu("Show Version", new ShowVersion()));
            m_MainMenu.AddMenuItem(dateTimeSubMenu);
            m_MainMenu.AddMenuItem(versionAndCapitalsSubMenu);
        }

        public InterfacesMenuTest()
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