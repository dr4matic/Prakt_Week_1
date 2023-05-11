﻿using System;

namespace Task_6;

class Program
{
    static void Main(string[] args)
    {
        const string AddsCom = "1";
        const string DisplayCom = "2";
        const string DeleteCom = "3";
        const string SurnameSearchCom = "4";
        const string ExitCom = "5";

        string[] positions = new string[0];
        string[] fullNames = new string[0];
        bool Exit = true;

        while (Exit)
        {
            Console.Clear();
            Console.WriteLine($"{AddsCom}. Добавить досье ");
            Console.WriteLine($"{DisplayCom}. Вывести все досье ");
            Console.WriteLine($"{DeleteCom}. Удалить досье по номеру ");
            Console.WriteLine($"{SurnameSearchCom}. Поиск по фамилии ");
            Console.WriteLine($"{ExitCom}. Закончить сеанс ");

            switch (Console.ReadLine())
            {
                case AddsCom:
                    Add(ref fullNames, ref positions);
                    break;

                case DisplayCom:
                    Display(positions, fullNames);
                    Console.Write("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;

                case DeleteCom:
                    Delete(ref fullNames, ref positions);
                    Console.Write("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;

                case SurnameSearchCom:
                    SurnameSearch(fullNames, positions);
                    Console.Write("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;

                case ExitCom:
                    Exit = false;
                    break;

            }


        }
    }
    
    private static void Add(ref string[] names, ref string[] positions)
    {
        Console.WriteLine("Введите ФИО сотрудника");
        string name = Console.ReadLine();
        Console.WriteLine("Введите должность сотрудника");
        string position = Console.ReadLine();

        names = Increase(names, name);
        positions = Increase(positions, position);
    }

    private static string[] Increase(string[] array, string text)
    {
        string[] tempArray = new string[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[i];
        }

        tempArray[tempArray.Length - 1] = text;
        array = tempArray;
        return array;
    }

    private static void Display(string[] positions, string[] fullNames)
    {
        int index = 1;

        for (int i = 0; i < positions.Length; i++)
        {
            Console.WriteLine($" [{index}] " +
                $"\n ФИО : {fullNames[i]} " +
                $"\n Должность : {positions[i]}");
            index++;
        }
    }

    private static void Delete(ref string[] fullNames, ref string[] positions)
    {
        Console.Write("Введите номер досье: ");
        var inputNumber = Console.ReadLine();
        bool SuccessfulDelete;
        bool.TryParse(inputNumber, out SuccessfulDelete);
        if (SuccessfulDelete == true)
        {
            int number = int.Parse(inputNumber);
            if (number > 0 && number <= fullNames.Length)
            {
                int index = number - 1;
                fullNames = Decrease(fullNames, index);
                positions = Decrease(positions, index);
                Console.WriteLine($"Досье с номером [ {number} ] удалено\n");
            }
            else
            {
                Console.WriteLine("Досье с таким номером не существует\n");
            }
        }
        else Console.WriteLine("Необходимо ввести номер\n");
    }

    private static string[] Decrease(string[] array, int index)
    {
        string[] tempArray = new string[array.Length - 1];

        for (int i = 0; i < index; i++)
        {
            tempArray[i] = array[i];
        }

        for (int i = index; i < array.Length - 1; i++)
        {
            tempArray[i] = array[i + 1];
        }

        array = tempArray;
        return array;
    }

    private static void SurnameSearch(string[] fullNames, string[] positions)
    {
        Console.WriteLine("Введите фамилию для поиска досье");
        string surname = Console.ReadLine();
        bool SuccessfulSearch = false;

        for (int i = 0; i < fullNames.Length; i++)
        {
            string[] split = fullNames[i].Split(' ');

            if (split[0].ToLower() == surname.ToLower())
            {
                Console.WriteLine($"Номер [ {i + 1} ] | ФИО : {fullNames[i]} | должность : {positions[i]}\n");
                SuccessfulSearch = true;
            }
        }

        if (SuccessfulSearch == false)
        {
            Console.WriteLine($"Досье сотрудников с фамилией '{surname}' не найдено\n");
        }

    }
}