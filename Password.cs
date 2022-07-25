﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    public static class Password
    {
        private static string[] symbols = {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
            "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=",
            "q", "w", "e", "r", "t", "y", "u", "i", "o", "p",
            "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
            "a", "s", "d", "f", "g", "h", "j", "k", "l", ";",
            "A", "S", "D", "F", "G", "H", "J", "K", "L", ":",
            "z", "x", "c", "v", "b", "n", "m", ",", ".",
            "Z", "X", "C", "V", "B", "N", "M", "<", ">"
        };

        public static string Get()
        {
            string answer = "";

            for (int i = 0; i < 25; i++)
            {
                Random rand = new Random();
                int symbolNum = rand.Next(0, symbols.Length);
                answer += symbols[symbolNum];
            }

            return answer;
        }
    }
}
