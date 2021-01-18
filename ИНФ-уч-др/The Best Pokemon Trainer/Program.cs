using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    //Поле
    private static readonly Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

    static void Main()
    {
        //Метод
        CreateTrainersAndPokemons();
        //Метод
        Tournament();
        //Метод
        PrintTrainersInfo();
    }

    //Метод, изпълняващ код
    private static void Tournament()
    {
        //Цикъл за повторение
        while (true)
        {
            //Четене на низ
            string element = Console.ReadLine();
            //Проверка ако елемента е "End"
            if (element == "End")
            {
                //Спира програмата
                break;
            }
            //Проверка за всички треньори
            foreach (var trainer in trainers)
            {
                bool isToAddBadge = trainer.Value.IsHasPokemonWithThisElement(element);
                //Ако е true
                if (isToAddBadge)
                {
                    //Добавяме значка
                    trainer.Value.AddBadge();
                }
                //Иначе
                else
                {
                    //Намаляме кръвта
                    trainer.Value.DecreaseHealth();
                }
            }
        }
    }

    //Метод, изпълняващ код
    private static void PrintTrainersInfo()
    {
        //Проверка за всички треньори, сортирани в низходящ ред
        foreach (var trainer in trainers.OrderByDescending(x => x.Value.BadgeCount))
        {
            //Отпечатваме стойността на треньора
            Console.WriteLine(trainer.Value);
        }
    }

    //Метод, изпълняващ код
    private static void CreateTrainersAndPokemons()
    {
        //Цикъл за повторение
        while (true)
        {
            //Създаване на масив от низове
            string[] info = Console.ReadLine() //Четене....
                .Split(' ') //Разделяне с интервал
                .ToArray(); //Превръщане в масив

            //Слагаме името на треньора в масива
            string trainerName = info[0];
            //Проверка, ако името е "Tournament"
            if (trainerName == "Tournament")
            {
                //Спира програмата
                break;
            }

            //Слагаме името на покемона в масива
            string pokemonName = info[1];
            //Слагаме елемента в масива
            string element = info[2];
            //Слагаме кръвта в масива
            int health = int.Parse(info[3]);
            //Създаване на покемон
            Pokemon pokemon = new Pokemon(pokemonName, element, health);
            //Проверка, ако името на треньора не се съдържа в "trainers"
            if (!trainers.ContainsKey(trainerName))
            {
                //Създаване на треньор
                Trainer trainer = new Trainer(trainerName);
                //Добавяме треньора
                trainers.Add(trainerName, trainer);
            }
            //Добавяме треньора и покемона му
            trainers[trainerName].AddPokemonToTrainer(pokemon);
        }
    }
}