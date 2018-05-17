using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class DelegatesMenuTest
    {
        private MainMenu m_MainMenu = null;
        private string m_MainMenuText = "Delegates Menu";

        private void buildMainMenu()
        {
            m_MainMenu = new MainMenu(m_MainMenuText);
        }

        public void Show()
        {
            buildMainMenu();
            //m_MainMenu.Show();
        }
    }
}
