using System.Security.Cryptography.X509Certificates;

public class Action
{
    int i = 3;
    Random rnd = new Random();
    
    public bool Atack(string choose, Unit player, Unit enemy, Skill skill)
    {
        
        switch (choose)
        {
            case "0":
                {
                    skill.Damage = skill.Rage ? 60 : 30;
                    skill.Rage = false;
                }
                break;
            case "1":
                {
                    skill.Shotgun = true;
                }
                break;
            case "2":
                {
                    skill.Damage = skill.Rage ?
                        skill.Damage = skill.Shotgun ? rnd.Next(140, 280) : 0 :
                        skill.Damage = skill.Shotgun ? rnd.Next(70, 140) : 0;
                    skill.Shotgun = false;
                    skill.Rage = false;
                }
                break;
            case "3":
                {
                    skill.Rage = true;
                }
                break;
            case "4":
                {
                    if (rnd.Next(0, 100) > 50)
                    {
                        player.Hp += 30;
                    }
                    else
                    {
                        player.Hp -= 30;
                        skill.Water = false;
                        player.Heal = 10;
                    }
                }
                break;
            case "5":
                {
                    if (skill.Water == false)
                    {
                        player.Heal += 20;
                        skill.Water = true;
                    }
                    
                }
                break;
            default:
                Console.WriteLine("Неверный ввод");
                break;
        }
        
       
        int enemyDmg = rnd.Next(30, 70);
        
        
        player.Hp += player.Heal;
        player.Hp -= enemyDmg;
        
        enemy.Hp += enemy.Heal;
        enemy.Hp = enemy.Hp - skill.Damage;
        skill.Damage = 0;


        Console.WriteLine($"\nСтатистика Упыря: \n Здоровье: {enemy.Hp} , Урон: {enemyDmg} \n\nСтатистика игрока: \n Здоровье: {player.Hp} Регенерация: {player.Heal} Дробовик: {skill.Shotgun} Ярость: {skill.Rage} Бульон от пельменей: {skill.Water} {i}\n");
        if (player.Hp < 1 || enemy.Hp < 1)
        { return false; }
        else
        {
            return true;
        }
    }
}
