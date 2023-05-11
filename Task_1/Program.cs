internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Приветствуем вас в магазине кристалов");
        
        Console.Write("Сколько у вас золота = ");
        int gold = int.Parse(Console.ReadLine());

        int dimond = 10;
        Console.WriteLine($"Кристалы стоят {dimond} золота");

        Console.Write("Сколько вы хотите купить кристалов = ");
        int purchase = int.Parse(Console.ReadLine());

        bool deal = gold >= purchase * dimond;
        purchase *= Convert.ToInt32(deal);
        gold -= purchase * dimond;

        Console.WriteLine($"У вас имеется {gold} золота и {purchase} кристаллов");


    }
}