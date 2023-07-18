using System;

public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public interface ISleeper
{
    void Sleep();
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot working...");
    }
}

public class Human : IWorker, IEater, ISleeper
{
    public void Work()
    {
        Console.WriteLine("Human working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Human sleeping...");
    }
}

public class Animal : IEater, ISleeper
{
    public void Eat()
    {
        Console.WriteLine("Animal eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal sleeping...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IWorker worker = new Human();
        worker.Work();

        IEater eater = new Human();
        eater.Eat();

        ISleeper sleeper = new Human();
        sleeper.Sleep();

        eater = new Animal();
        eater.Eat();

        sleeper = new Animal();
        sleeper.Sleep();
    }
}
