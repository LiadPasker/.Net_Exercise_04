using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IActionListener
    {
        public void Invoke()
        {
            int upperCaseLetters = 0;
            Console.WriteLine("Please type a sentence:");
            string inputSentence = Console.ReadLine();

            for (int i = 0; i < inputSentence.Length; ++i)
            {
                if(char.IsUpper(inputSentence[i]))
                {
                    ++upperCaseLetters;
                }
            }

            Console.WriteLine("The input sentence contains {0} uppercase letters.", upperCaseLetters);
            Console.ReadLine();
        }
    }
}