# Usage

Sample usage scenario after running the `dotnet run` command:

```plaintext
Enter the player's name: Samurai

Choose the weapon for the player:
1 - Katana (damage -> 8, damage modifier range -> 0-4)
2 - Desert Eagle (damage -> 6, damage modifier range -> 1-3)

Enter the player's weapon (1-2): 1

Successfully inferred player named as `Samurai` armed with `Katana`!

Enter the player's name: Commando

Choose the weapon for the player:
1 - Katana (damage -> 8, damage modifier range -> 0-5)
2 - Desert Eagle (damage -> 6, damage modifier range -> 1-4)

Enter the player's weapon (1-2): 2

Successfully inferred player named as `Commando` armed with `Desert Eagle`!

Commencing duel between `Samurai` (100 health) and `Commando` (100 health)!

Luck favors `Samurai` as the initiator against the defender `Commando`.

Duel has begun!

Turn 1: Samurai struck Commando for 8 damage!
Turn 2: Commando retaliated Samurai with 12 damage!
Turn 3: Samurai struck Commando for 8 damage!
Turn 4: Commando retaliated Samurai with 18 damage!
Turn 5: Samurai struck Commando for 0 damage!
Turn 6: Commando retaliated Samurai with 12 damage!
Turn 7: Samurai struck Commando for 16 damage!
Turn 8: Commando retaliated Samurai with 12 damage!
Turn 9: Samurai struck Commando for 8 damage!
Turn 10: Commando retaliated Samurai with 18 damage!
Turn 11: Samurai struck Commando for 16 damage!
Turn 12: Commando retaliated Samurai with 12 damage!
Turn 13: Samurai struck Commando for 24 damage!
Turn 14: Commando retaliated Samurai with 12 damage!
Turn 15: Samurai struck Commando for 24 damage!

Samurai has 4 health, whereas Commando has -4 health.

`Samurai` is victorious!

Would you like to initiate the duel again? (Y/n): n
```
