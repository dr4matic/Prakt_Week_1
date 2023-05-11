using Microsoft.VisualBasic;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Это программа покажет свое тайное сообщение только тем кто знает пароль, у вас есть 3 попытки");

        string password = "magirulit";
        
        for (int i = 3; i > 0; i--)
        {
            Console.Write("Введите пароль:");
            string str = Console.ReadLine();
            if (str == password)
            {
                Console.WriteLine("Это тайное сообщение доступно только тем кто знает пароль");
                return;
            }
            Console.WriteLine($"Пароль не верный");
        }
    }
}