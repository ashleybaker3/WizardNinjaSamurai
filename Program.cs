using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wizard Misdreavus = new Wizard("Misdreavus");
            Ninja Greninja = new Ninja("Greninja");
            Samurai Samurott = new Samurai("Samurott");
            Misdreavus.GetInfo();
            Greninja.GetInfo();
            Samurott.GetInfo();
            Console.WriteLine("************");
            Misdreavus.Heal(Greninja);
            Samurott.Meditate();
            Greninja.Steal(Samurott);
            Misdreavus.GetInfo();
            Greninja.GetInfo();
            Samurott.GetInfo();
        }
    }
}
