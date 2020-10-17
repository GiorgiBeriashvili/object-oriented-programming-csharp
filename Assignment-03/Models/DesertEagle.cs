using System;
using Assignment_03.Models.Abstract;
using Assignment_03.Models.Interfaces;

namespace Assignment_03.Models
{
    public sealed class DesertEagle : Weapon, IRangedWeapon
    {
        public override string Name { get; set; }
        public override double Damage { get; set; }
        public override (int minimum, int maximum) DamageModifierRange { get; set; }

        public double Shoot(Player player) => player.Health -= Damage * new Random().Next(DamageModifierRange.minimum, DamageModifierRange.maximum);

        public DesertEagle(string name, double damage, (int minimum, int maximum) damageModifierRange)
        {
            Name = name;
            Damage = damage * BaseDamage;
            DamageModifierRange = damageModifierRange;
        }
    }
}