namespace CharacterInheritance
{
    internal class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
            attackDamage = 35;
            health = 250;
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} releases a mighty yell, that tremors the land. +25 pts to damage");
            attackDamage += 25f;
        }
    }
}
