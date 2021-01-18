using System;
using System.Collections.Generic;
using System.Text;
public class Pokemon
{
    //Полета
    private string name;
    private string element;
    private int health;

    //Конструктор
    public Pokemon(string name, string element, int health)
    {
        this.Name = name;
        this.Element = element;
        this.Health = health;
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
    public string Element
    {
        //Дава достъп за четене
        get { return this.element; }
        //Дава възможност за промяна на стойноста на полето име
        set
        {
            //Валидация
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid element!");
            }
            this.element = value;
        }
    }

    //Свойство
    public int Health
    {
        //Дава достъп за четене
        get { return this.health; }
        //Дава възможност за промяна на стойноста на полето име
        set
        {
            //Валидация
            if (value < 0)
            {
                throw new ArgumentException("Health must be positive!");
            }
            this.health = value;
        }
    }
}
