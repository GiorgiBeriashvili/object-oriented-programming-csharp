using System;
using Assignment_03.Models.Abstract;
using Assignment_03.Models.Interfaces;

namespace Assignment_03.Models
{
    public sealed class Katana : Weapon, IMeleeWeapon
    {
        public override string Name { get; set; }
        public override double Damage { get; set; }
        public override (int minimum, int maximum) DamageModifierRange { get; set; }
        
        public double Cut(Player player) => player.Health -= Damage * new Random().Next(DamageModifierRange.minimum, DamageModifierRange.maximum);

        public Katana(string name, double damage, (int minimum, int maximum) damageModifierRange)
        {
            Name = name;
            Damage = damage * BaseDamage;
            DamageModifierRange = damageModifierRange;
        }
    }
}