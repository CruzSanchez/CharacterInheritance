namespace CharacterInheritance;

internal class Program
{
    static List<Character> characters = new List<Character>();
    static List<Hero> party = new List<Hero>();
    static List<Monster> enemys = new List<Monster>();

    static void Main(string[] args)
    {
        var baseCharacter = new Character("Mr. Generic");
        var barb = new Barbarian("Skullbash");
        var wizz = new Wizard("Jack Ashtalker");
        var monster = new Monster("Mr. Owl");

        characters.Add(baseCharacter);
        characters.Add(barb);
        characters.Add(wizz);
        characters.Add(monster);

        party.Add(wizz);
        party.Add(barb);

        enemys.Add(monster);

        Console.WriteLine("Start");
        Console.WriteLine();

        foreach (var character in characters)
        {
            //Cannot use special ability since they are being treated as Characters!!

            Console.WriteLine("##########");
            character.SayName();
            character.CheckHealth();
            Console.WriteLine("##########");
            Console.WriteLine();
        }

        Console.WriteLine("------BREAK------");
        Console.WriteLine();

        foreach (var hero in party)
        {
            hero.SpecialAbility();
            hero.Attack(monster);
            Console.WriteLine();
        }

        wizz.CastSpell(barb);
        Console.WriteLine($"{wizz.Name} got confused and sent a spell at {barb.Name} by accident");

        Console.WriteLine();
        Console.WriteLine("------BREAK------");
        Console.WriteLine();

        foreach (var enemy in enemys)
        {
            enemy.CheckHealth();
            Console.WriteLine();
        }

        Console.WriteLine("------BREAK------");

        foreach (var character in characters)
        {
            //Cannot use special ability since they are being treated as Characters!!

            Console.WriteLine("##########");
            character.CheckHealth();
            Console.WriteLine("##########");
            Console.WriteLine();
        }

    }
}
