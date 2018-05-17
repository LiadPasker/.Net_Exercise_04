using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IActionListener
    {
        public void Invoke()
        {
            Console.WriteLine("The current time is: {0}",DateTime.Now.ToShortTimeString());
            Console.ReadLine();
        }
    }
}