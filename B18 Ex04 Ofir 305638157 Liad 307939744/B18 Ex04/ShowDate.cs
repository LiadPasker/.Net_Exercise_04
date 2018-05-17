using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowDate : IActionListener
    {
        public void Invoke()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}