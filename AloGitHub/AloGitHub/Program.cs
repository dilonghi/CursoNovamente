using System;

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
