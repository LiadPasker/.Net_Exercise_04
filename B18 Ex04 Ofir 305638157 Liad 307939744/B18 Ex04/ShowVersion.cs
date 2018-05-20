using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowVersion : IActionListener
    {
        private string m_VersionText = "Version: 18.2.4.0";

        public void Invoke()
        {
            Console.WriteLine(m_VersionText);
            Console.ReadLine();  
        }
    }
}