namespace CharacterInheritance
{
    internal class Character
    {
        public string Name { get; protected set; }
        protected float health = 100f;
        protected float attackDamage = 5f;
        protected bool isAlive = true;

        public Character(string name)
        {
            Name = name;
        }

        public virtual void SayName()
        {
            Console.WriteLine($"Hello, I am the great {Name}");
        }

        public void TakeDamage(Character damageDealer)
        {
            health -= damageDealer.attackDamage;
        }

        public void CheckHealth()
        {
            if (health <= 0)
            {
                health = 0;
                isAlive = false;
                Console.WriteLine("You are ded");
            }

            Console.WriteLine($"{Name} has {health} HP left.");
        }

        public void Attack(Character characterToAttack)
        {
            Console.WriteLine($"Attacking {characterToAttack.Name}!");
            characterToAttack.TakeDamage(this);
        }
    }
}
