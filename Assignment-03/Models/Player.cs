using Assignment_03.Models.Abstract;

namespace Assignment_03.Models
{
    public class Player
    {
        public readonly string Name;
        public double Health = 100;
        public bool Alive = true;
        public readonly Weapon Weapon;

        public Player(string name, Weapon weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        private delegate double DamageAbility(Player player);

        public double? Damage(Player player)
        {
            DamageAbility damageAbility = Weapon switch
            {
                DesertEagle desertEagle => desertEagle.Shoot,
                Katana katana => katana.Cut,
                _ => default
            };

            var damage = player.Health - damageAbility?.Invoke(player);

            if (player.Health <= 0) player.Alive = false;

            return damage;
        }
    }
}