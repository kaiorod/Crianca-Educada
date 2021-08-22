using System;

namespace Crianca_Educada
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.Beep();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Me diga o que você acha sobre uma pessoa que não segue regras : ");
            Console.ResetColor();
            texto = Console.ReadLine();

            texto = texto
            .Replace("chato", "@#!¨*&")
            .Replace("chato", "%#@*0")
            .Replace("chata", "%#@*@")
            .Replace("bobo", ";0;0")
            .Replace("boba", ";0;@")
            .Replace("feio", "+&!0")
            .Replace("feia", "+&!@")
            .Replace("boboca", ";0;0%@")
            .Replace("bocó", ";0;º")
            .Replace("tonto", "*0|*0")
            .Replace("tonta", "*0|*@")
            .Replace("palerma", "*/+@#%$")
            .Replace("paspalho", "@#!¨*&")
            .Replace("paspalha", "&%¨&$+-*")
            .Replace("tantã", "$#@%$")
            .Replace("panaca", "¨#(&+-")
            .Replace("pentelho", "&#*@#+/*")
            .Replace("pentelha", "+-*.*&#$%")
            .Replace("burro", "&#%%@")
            .Replace("burra", "++=*&")
            .Replace("besta", "$*@#!");

            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nEu sou uma criança educada. No seu lugar eu diria : ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(texto);
            Console.ResetColor();
            
        }
    }
}
