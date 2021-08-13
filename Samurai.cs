namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public override string Name { get; set; }

        public override int Health { get; set; }

        public Samurai(string name)
        {
            Name = name;
            Health = 200;
        }

        public override int Attack(Human target)
        {
            int damage = 5 * this.Strength;
            target.Health = target.Health - damage;
            if(target.Health<=50)
            {
                target.Health = 0;
            }
            return target.Health;
        }

        public int Meditate()
        {
            this.Health = 200;
            return this.Health;
        }
    }
}