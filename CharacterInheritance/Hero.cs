namespace CharacterInheritance
{
    internal class Hero : Character
    {
        public Hero(string name) : base(name)
        {
        }

        public virtual void SpecialAbility()
        {
            Name = Name.ToUpper();
        }
    }
}
