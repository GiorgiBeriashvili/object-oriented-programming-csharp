using System;
using Assignment_03.Models.Enumerations;

namespace Assignment_03.Models
{
    public static class GameManager
    {
        private static Player _initiator;
        private static Player _defender;
        private static int _turn;
        private static double? _damage;
        private static Player _victor;
        
        public static void Duel(Player playerOne, Player playerTwo)
        {
            _initiator = GetInitiator(playerOne, playerTwo);
            _defender = _initiator == playerOne ? playerTwo : playerOne;
            _turn = default;
            _damage = default;
            _victor = default;

            Console.WriteLine($"Commencing duel between `{_initiator.Name}` ({_initiator.Health} health) and `{_defender.Name}` ({_defender.Health} health)!\n");
   
            Console.WriteLine($"Luck favors `{_initiator.Name}` as the initiator against the defender `{_defender.Name}`.\n");

            Console.WriteLine(Status(DuelState.Start));

            while (_initiator.Alive && _defender.Alive)
            {
                _damage = _initiator.Damage(_defender);

                Console.WriteLine(Status(DuelState.Initiative));

                if (DeterminedVictor()) break;
                
                _damage = _defender.Damage(_initiator);
                
                Console.WriteLine(Status(DuelState.Retaliation));

                if (DeterminedVictor()) break;
            }
            
            Console.WriteLine(Status(DuelState.Contemplation));

            Console.WriteLine(Status(DuelState.End));
        }

        private static bool DeterminedVictor()
        {
            if (!_initiator.Alive)
            {
                _victor = _defender;

                return true;
            }
            
            if (!_defender.Alive)
            {
                _victor = _initiator;

                return true;
            }

            return false;
        }

        private static string Status(DuelState duelState)
        {
            var status = duelState switch
            {
                DuelState.Start => "Duel has begun!\n",
                DuelState.Initiative => $"Turn {++_turn}: {_initiator.Name} struck {_defender.Name} for {_damage} damage!",
                DuelState.Retaliation => $"Turn {++_turn}: {_defender.Name} retaliated {_initiator.Name} with {_damage} damage!",
                DuelState.Contemplation => $"\n{_initiator.Name} has {_initiator.Health} health, whereas {_defender.Name} has {_defender.Health} health.\n",
                DuelState.End => $"`{_victor.Name}` is victorious!",
                _ => default
            };

            return status;
        }

        private static Player GetInitiator(Player playerOne, Player playerTwo)
        {
            var (minimum, maximum) = (0, 10);
            const int threshold = 5;

            return new Random().Next(minimum, maximum) < threshold ? playerOne : playerTwo;
        }
    }
}