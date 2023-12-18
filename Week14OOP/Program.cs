Dog goodboy = new Dog("Good boy");
Console.WriteLine($"Name: {goodboy.Name}, Level of happiness: {goodboy.LevelOfHappiness}");

while (goodboy.LevelOfHappiness < 5)
{
    goodboy.Bark();
}
goodboy.Wag();

Dog goodgirl = new Dog("Good girl");
Console.WriteLine($"Name: {goodgirl.Name}, Level of happiness: {goodgirl.LevelOfHappiness}");

while (goodgirl.LevelOfHappiness < 10)
{
    goodgirl.Bark();
}
goodgirl.Wag();


class Dog
{
    public string Name;
    public int LevelOfHappiness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappiness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }

    public void Bark()
    {
        LevelOfHappiness++;
        Console.WriteLine("Woof-woof");
    }

    public void Wag()
    {
        Console.WriteLine($"{Name} is wagging its tail.\nWhoosh-whoosh");
    }
}