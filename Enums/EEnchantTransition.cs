namespace GFDataApi.Enums
{
    public enum EEnchantTransition
    {
        None = 0,
        AttackToSelf = 1,
        AttackToOpponent = 2,
        HurtToSelf = 3,
        HurtToOpponent = 4,
        CastSpellToSelf = 5,
        CastSpellToOpponent = 6,
        KillToSelf = 7,
        BeKilledToOpponent = 8,
        ReviveToSelf = 9,
        HealToSelf = 10,
        HealToOpponent = 11,
        BeHealedToSelf = 12,
        BeHealedToOpponent = 13,
        CastClassSpellToSelf = 14,
        CastClassSpellToOpponent = 15,
    }
}
