namespace GFDataApi.DataTypes.Enums
{
    [Flags]
    public enum EItemOpFlagsPlus
    {
        None = 0x0,
        IKCombine = 0x1,
        GKCombine = 0x2,
        EquipShow = 0x4,
        PurpleWLimit = 0x8,
        PurpleALimit = 0x10,
        UseBind = 0x20,
        OneStack = 0x40,
        RideCombineIK = 0x80,
        RideCombineGK = 0x100,
        VIP = 0x200,


        ChairCombineIK = 0x800,
        ChairCombnineGK = 0x1000,
        RedWLimit = 0x2000,
        RedALimit = 0x4000,
        CrystalCombo = 0x8000,
        SouvenirCombo = 0x10000,
        GodAreaCombo = 0x20000,
        ElfTabletEquip = 0x40000,
        ElfTabletExp = 0x80000,
        ShowProbability = 0x100000,
        StorageForbidden = 0x200000,
        FamilyStorageForbidden = 0x400000
    }
}
