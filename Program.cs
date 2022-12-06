using battleRoyal;

namespace battleRoyal
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy JoeNutz = new Enemy(100, 20);
            Enemy MikeHawkHertz = new Enemy(120, 10);
            // Fighter BigusNIgus = new Fighter("Bigus Gayus Nigga barlsus", 100) Attack*0.25)
            // Knight MikeOxlong = new Knight("Mike Oxlong", 100,) RecieveDamage*0.10)
            // Sorcerer BenDover = new Sorcerer("Ben Dover", 100, 100(Mana))
            // Beast
            Enemy[] combatants = new Enemy[] { JoeNutz, MikeHawkHertz };
            int combAlive = combatants.Length;
            int round = 0;
            while (combAlive > 1)
            {
                Console.WriteLine("\\--//" + round++ + "\\--//");
                foreach (var c in combatants)
                {
                    var x = c.PickOpponent(combatants);
                    c.Attack(x);
                }
                combAlive = 0;
                foreach (var c in combatants)
                {
                    if (c.HeLivin) combAlive++;
                    Console.WriteLine(c);
                }
                Console.WriteLine(" Joe Nutz livin: {0}", JoeNutz.HeLivin);
                Console.WriteLine("Joe Nutz's Health bar be like: {0}", JoeNutz.HealthBar());
                Console.WriteLine("Mike Hawk Hertz livin: {0}", MikeHawkHertz.HeLivin);
                Console.WriteLine("Mike Hawk Hertz's Health bar be like: {0}", MikeHawkHertz.HealthBar());
            }
        }
    }
}