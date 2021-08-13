using System;

namespace WizardNinjaSamurai
{

    public abstract class Human
{
    public abstract string Name { get; set; }
    public int Strength { get; set; }
    public virtual int Intelligence { get; set; }
    public virtual int Dexterity { get; set; }
    public virtual int Health { get; set; }

    public Human()
    {
        Name = null;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    
    public Human(string name, int strength, int intelligence, int dexterity, int hlth)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = hlth;
    }
    
    public virtual int Attack(Human target)
    {
        int damage = 5 * target.Strength;
        target.Health = target.Health - damage;
        return target.Health;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Health: {Health}");
    }
}

}
