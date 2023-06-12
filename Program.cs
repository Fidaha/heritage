namespace AnimalChallenge;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animaux = new Animal[5];
        animaux[0] = new Humain();
        animaux[1] = new Singe();
        animaux[2] = new Elephant();
        animaux[3] = new Tortue();
        animaux[4] = new Lézard();

        foreach (Animal animal in animaux)
        {
            animal.Move();
            animal.Eat();
            Console.WriteLine();
        }

      
    }
}
