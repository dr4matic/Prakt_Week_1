internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа в которой нет ничего интересного");
        Console.WriteLine("Для выхода напишите exit");
        Console.WriteLine();

        string exit = "";
        Random rnd = new ();
        

        while (exit != "exit")
        {
            List<string> list = new() { "В этой программе нет ничего интересного","Вы тут ничего не найдете","Тут правда нет ничего интересного","Вы можете не пытаться все равно тут ничего нет","Вы просто тратите время в пустую вы тут ничего не найдете"};
            Console.WriteLine(list[rnd.Next(0, list.Count)]);

            exit = Console.ReadLine().ToLower();
        }

    }
}