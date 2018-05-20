using System;

namespace Ex04.Menus.Delegates
{
    public delegate void ExecutionDelegate();

    public class ActionMenu : MenuItem
    {
        protected internal override void OnClick()
        {
            Console.Clear();
            button_OnClick();
        }

        protected virtual void button_OnClick()
        {
            if (Execution != null)
            {
                Execution.Invoke();
            }
        }

        public ActionMenu(string i_Text) : base(i_Text)
        {
        }

        public event ExecutionDelegate Execution;
    }
}