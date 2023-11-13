namespace GFDataApi.Enums
{
    [Flags]
    public enum EEnchantFlag
    {
        RemoveAttack = 1 << 0,
        RemoveBeAttacked = 1 << 1,
        RemoveHurt = 1 << 2,
        EnchantReserve = 1 << 3,
        CantAbandon = 1 << 4,
        DieReserve = 1 << 5,
        VultureOnly = 1 << 6,
        WolfOnly = 1 << 7,
        GorilaOnly = 1 << 8,
        NoBoss = 1 << 9,
        NoTransNode = 1 << 10,
        DailyType = 1 << 11,
        MachineOnly = 1 << 12,
        NoUseItem = 1 << 13,
        NoTotem = 1 << 14,
        HideIcon = 1 << 15,
        Vip = 1 << 16,
        NoMove = 1 << 17,
        Heal = 1 << 18,
        NoRebirth = 1 << 19,
        NoBattlefield = 1 << 20,
        NoWarningMsg = 1 << 21,
        NoStack = 1 << 22,
        RecoverPriestForm = 1 << 23,
        NoRefresh = 1 << 24
    }
}
