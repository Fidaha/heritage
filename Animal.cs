using System;

namespace AnimalChallenge;

abstract class Animal
{
    public abstract void Move();
    public void Eat()
    {
        Console.WriteLine("Je mange de la nourriture.");
    }
}

class Bipède : Animal
{
    public override void Move()
    {
        Console.WriteLine("Je me déplace sur deux jambes.");
    }
}

class Quadrupède : Animal
{
    public override void Move()
    {
        Console.WriteLine("Je me déplace sur quatre pattes.");
    }
}

class Humain : Bipède
{
    public override void Move()
    {
        Console.WriteLine("Je marche sur deux jambes.");
    }
}

class Singe : Bipède
{
    public override void Move()
    {
        Console.WriteLine("Je me déplace en grimpant aux arbres.");
    }
}

class Elephant : Quadrupède
{
    public override void Move()
    {
        Console.WriteLine("Je marche sur quatre pattes.");
    }
}

class Tortue : Quadrupède
{
    public override void Move()
    {
        Console.WriteLine("Je me déplace lentement sur quatre pattes.");
    }
}

class Lézard : Quadrupède
{
    public override void Move()
    {
        Console.WriteLine("Je rampe sur le sol.");
    }
}
