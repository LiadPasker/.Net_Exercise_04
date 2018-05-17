using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ExecutionDelegate();

    public class ActionMenu : MenuItem
    {
        public event ExecutionDelegate Execution;

        public ActionMenu(string i_Text) : base(i_Text)
        {
        }

        public override void OnClick()
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

    }
}
