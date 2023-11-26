
using System;
using System.Collections.Generic;

// Интерфейс, представляющий часть дома
public interface IPart
{
    void Build();
}

public interface IWorker
{
    void Work(IPart part);
}

public class Basement : IPart
{
    public void Build()
    {
        Console.WriteLine("Building a Basement:");
        Console.WriteLine("  |__|__|__|__|");
    }
}

public class Wall : IPart
{
    public void Build()
    {
        Console.WriteLine("Building a Wall:");
        Console.WriteLine("  |  |  |  |  |");
    }
}

public class Door : IPart
{
    public void Build()
    {
        Console.WriteLine("Building a Door:");
        Console.WriteLine("  |  D  |  |  |");
    }
}

public class Window : IPart
{
    public void Build()
    {
        Console.WriteLine("Building a Window:");
        Console.WriteLine("  |  W  |  |  |");
    }
}

public class Roof : IPart
{
    public void Build()
    {
        Console.WriteLine("Building a Roof:");
        Console.WriteLine(" /\\  /\\  /\\  /\\");
    }
}

public class House
{
    private List<IPart> parts = new List<IPart>();

    public void AddPart(IPart part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("House is built. Here is the structure:");
        foreach (var part in parts)
        {
            part.Build();
        }
    }
}

public class Worker : IWorker
{
    public void Work(IPart part)
    {
        part.Build();
    }
}
public class TeamLeader : IWorker
{
    public void Work(IPart part)
    {
        // Бригадир не строит, а формирует отчет
        Console.WriteLine("Team Leader reports:");
        part.Build();
    }
}

public class Team
{
    private List<IWorker> workers = new List<IWorker>();

    public void AddWorker(IWorker worker)
    {
        workers.Add(worker);
    }

    public void StartBuilding(House house)
    {
        Console.WriteLine("Building the house:");
        foreach (var worker in workers)
        {
            worker.Work(new Basement());
            worker.Work(new Wall());
            worker.Work(new Wall());
            worker.Work(new Wall());
            worker.Work(new Wall());
            worker.Work(new Door());
            worker.Work(new Window());
            worker.Work(new Window());
            worker.Work(new Window());
            worker.Work(new Window());
            worker.Work(new Roof());
        }

        house.Show();
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        // Создаем дом и бригаду строителей
        House house = new House();
        Team team = new Team();

        // Добавляем строителей в бригаду
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new TeamLeader());

        // Начинаем строительство
        team.StartBuilding(house);
    }
}
