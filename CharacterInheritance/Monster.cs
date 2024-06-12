namespace CharacterInheritance
{
    internal class Monster : Character
    {
        public Monster(string name) : base(name)
        {
        }

        public override void SayName()
        {
            Console.WriteLine($"URRRRAAHHHHHHH <Monster Language translated to english: \"My name is {Name} and im about to smash you\">");
        }
    }
}
