using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
    public override string Name { get; set; }
    public override int Dexterity { get; set; }
    public Ninja(string name)
    {
        Name = name;
        Dexterity = 175;
    }

    public override int Attack(Human target)
    {
        int damage = 5 * this.Dexterity;
        Random rand = new Random();
        if(rand.Next(5)==1){
            damage += 10;
        }
        target.Health = target.Health - damage;
        return target.Health;
    }

    public int Steal(Human target)
    {
        target.Health-=5;
        this.Health+=5;
        return this.Health;
    }

    }

}