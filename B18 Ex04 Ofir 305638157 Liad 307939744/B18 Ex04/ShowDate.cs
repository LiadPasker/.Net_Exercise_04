using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IActionListener
    {
        public void Invoke()
        {
            Console.WriteLine("The current date is: {0}", DateTime.Now.ToShortDateString());
            Console.ReadLine();
        }
    }
}