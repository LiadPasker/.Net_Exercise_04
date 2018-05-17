using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenu : MenuItem
    {
        private IActionListener m_ActionListener;

        public ActionMenu(string i_Text, IActionListener i_ActionListener): base(i_Text)
        {
            m_ActionListener = i_ActionListener;
        }

        public override void OnClick()
        {
            Console.Clear();
            m_ActionListener.Invoke();
        }
    }
}
