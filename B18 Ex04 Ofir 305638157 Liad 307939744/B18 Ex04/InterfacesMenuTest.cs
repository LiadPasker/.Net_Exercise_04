using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfacesMenuTest
    {
        private MainMenu m_MainMenu = null;
        private string m_MainMenuText = "Interfaces Menu";

        private void buildMainMenu()
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
