namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public override string Name { get; set; }
        public override int Intelligence { get; set; }

        public override int Health { get; set; }


    public Wizard(string name)
    {
        Name = name;
        Intelligence = 25;
        Health = 50;
    }
    

        public override int Attack(Human target)
    {
        int damage = 5 * this.Intelligence;
        target.Health = target.Health - damage;
        this.Health += damage;
        return target.Health;
    }

    public int Heal(Human target)
    {
        target.Health+= 10 * this.Intelligence;
        return target.Health;
    }
    }
}