namespace CharacterInheritance
{
    internal class Wizard : Hero
    {
        private float mana = 250;

        public Wizard(string name) : base(name)
        {
        }

        public void CastSpell(Character target)
        {
            float baseAttack = attackDamage;
            Console.WriteLine($"Casting fire bolt, dealing 50 damage to {target.Name}'s health");
            attackDamage = 50;
            Attack(target);
            attackDamage = baseAttack;
            mana -= 30;
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} casts an mystic spell bolstering their health. +25 pts to Health");

            health += 25f;
        }
    }
}
