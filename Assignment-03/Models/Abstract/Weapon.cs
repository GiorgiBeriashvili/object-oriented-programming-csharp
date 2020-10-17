namespace Assignment_03.Models.Abstract
{
    public abstract class Weapon
    {
        protected const int BaseDamage = 2;
        public abstract string Name { get; set; }
        public abstract double Damage { get; set; }
        public abstract (int minimum, int maximum) DamageModifierRange { get; set; }
    }
}