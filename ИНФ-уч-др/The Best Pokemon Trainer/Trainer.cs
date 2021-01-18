using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainer
{
    //Полета
    private string name;
    private int badgeCount;
    private readonly List<Pokemon> pokemons;

    //Конструктор
    public Trainer(string name)
    {
        this.Name = name;
        this.pokemons = new List<Pokemon>();
    }

    //Свойство
    public string Name
    {
        //Дава достъп за четене
        get { return this.name; }
        //Дава възможност за промяна на стойноста на полето име
        set
        {
            //Валидация
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid name!");
            }
            this.name = value;
        }
    }

    //Свойство
    public int BadgeCount
    {
        //Дава достъп за четене
        get { return this.badgeCount; }
        //Дава възможност за промяна на стойноста на полето име
        set
        {
            //Валидация
            if (value < 0)
            {
                throw new ArgumentException("BadgeCount must be positive!");
            }
            this.badgeCount = value;
        }
    }

    //Свойство
    public IReadOnlyCollection<Pokemon> Pokemons
    {
        //Дава достъп за четене
        get { return this.pokemons.AsReadOnly(); }
    }

    //Метод, изпълняващ код - Добавя покемони
    public void AddPokemonToTrainer(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }


    //Метод, връщащ резултат - true/false
    public bool IsHasPokemonWithThisElement(string element)
    {
        //Проверка за всички покемони
        foreach (var pokemon in this.Pokemons)
        {
            //Ако елемента съвпада - връщаме true, иначе false
            if (pokemon.Element == element)
            {
                return true;
            }
        }
        return false;
    }

    //Метод, изпълняващ код - Добавя значки
    public void AddBadge()
    {
        this.BadgeCount++;
    }

    //Метод, изпълняващ код
    public void DecreaseHealth()
    {
        //Списък от покемоните, които трябва да се премахнат
        List<Pokemon> pokemonsForRemove = new List<Pokemon>();

        //Проверка за всички покемони
        foreach (var pokemon in this.pokemons)
        {
            //Ако кръвта му е по-голяма от 10
            if (pokemon.Health > 10)
            {
                //Намаляме кръвта с 10
                pokemon.Health -= 10;
            }
            //Иначе
            else
            {
                //Добавяме премахнатите покемони
                pokemonsForRemove.Add(pokemon);
            }
        }
        //Ако се съдържат покемони
        if (pokemonsForRemove.Any())
        {
            //Проверка за всички покемони
            foreach (var pokemon in pokemonsForRemove)
            {
                //Премахваме покемона
                this.pokemons.Remove(pokemon);
            }
        }
    }

    //Метод - отпечатване
    public override string ToString()
    {
        return $"{this.Name} {this.BadgeCount} {this.Pokemons.Count}";
    }
}
