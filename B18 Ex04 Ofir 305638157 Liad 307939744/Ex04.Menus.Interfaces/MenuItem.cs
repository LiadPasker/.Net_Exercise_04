namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        protected string m_Text;

        public abstract void OnClick();

        public string Text
        {
            get
            {
                return m_Text;
            }
        }
    }
}
