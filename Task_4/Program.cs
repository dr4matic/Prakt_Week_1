using System.Numerics;
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Загрузка.");
        Thread.Sleep(1200);
        Console.Write('.');
        Thread.Sleep(1200);
        Console.WriteLine('.');
        Thread.Sleep(1200);
        Console.WriteLine("");

        Console.WriteLine($"Вы встретились с Упырем приготовьтесь к бою\nВаши варианты действий: \n" +
            "0. Выстрел из мушкетов - Способность позволяет выстрелить из 2-ух мушкетов, каждый выстрел наносит по 15 урона.\n" +
            "1. Заряд двухствольного дробовика - Теперь вы можете воспользоваться Дробовиком.\n" +
            "2. Выстрел дробовика - Позволят нанести от 70 до 140 урона в случае критического попадания.\n" +
            "3. Ярости - Усиливает следущую вашу атаку в 2 раза.\n" +
            "4. Шаверма - Шаверма, которую вы купили на вокзале, с шансом 50/50 либо восстановит 50 здоровья, либо отнимет его и снимет баф от бульона от пельменей.\n" +
            "5. Бульон от пельменей - Усиливает вашу регенерацию на 10, но только один раз.\n"
            );
        Random rnd = new();
        Unit player = new Unit() { Hp = rnd.Next(150, 300), Heal = 10 };
        Unit enemy = new Unit() { Hp = rnd.Next(150, 400), Heal = 10 };
        Skill skill = new Skill() { Damage = 0, Rage = false, Shotgun = false };
        bool game = true;
        int i = 0;
        while (game)
        {
            i++;
            Console.WriteLine($"Ход номер {i}");
            Action choose = new();
            string str = Console.ReadLine();
            game = choose.Atack(str, player, enemy, skill);
        }

        if (player.Hp <= 0)
        {
            Console.WriteLine("Вы умерли");
        }
        else
        {
            Console.WriteLine("Упырь мертв");
        }

    }

}
