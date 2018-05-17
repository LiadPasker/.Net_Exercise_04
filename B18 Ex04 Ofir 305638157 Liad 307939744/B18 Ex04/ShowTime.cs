using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IActionListener
    {
        public void Invoke()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}