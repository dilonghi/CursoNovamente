﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloGitHub
{
    class Program
    {
        static void EscreveNaTela(string txt)
        {
            Console.WriteLine(txt);
        }

        public static void Main(string[] args)
        {
            EscreveNaTela("Primeiro teste de Git");
            Console.ReadKey();
        }

    }
}
