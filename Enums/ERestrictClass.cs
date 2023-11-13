﻿namespace GFDataApi.Enums
{
    [Flags]
    public enum ERestrictClass : long
    {
        None = 0,
        Newbie = 1L << 0,
        Fighter = 1L << 1,
        Warrior = 1L << 2,
        Berserker = 1L << 3,
        Paladin = 1L << 4,
        Hunter = 1L << 5,
        Archer = 1L << 6,
        Ranger = 1L << 7,
        Assassin = 1L << 8,
        Acolyte = 1L << 9,
        Priest = 1L << 10,
        Cleric = 1L << 11,
        Sage = 1L << 12,
        SpellCaster = 1L << 13,
        Mage = 1L << 14,
        Wizard = 1L << 15,
        Necromancer = 1L << 16,
        Warlord = 1L << 17,
        Templar = 1L << 18,
        SharpShooter = 1L << 19,
        DarkStalker = 1L << 20,
        Prophet = 1L << 21,
        Mystic = 1L << 22,
        Archmage = 1L << 23,
        Demonologist = 1L << 24,
        Mechanic = 1L << 25,
        Machinist = 1L << 26,
        Engeener = 1L << 27,
        Demolitionist = 1L << 28,
        Gearmaster = 1L << 29,
        Gunner = 1L << 30,
        Empty = 1L << 31,
        DarkKnight = 1L << 32,
        Cruzader = 1L << 33,
        Hawkeye = 1L << 34,
        Windshadow = 1L << 35,
        Saint = 1L << 36,
        Shaman = 1L << 37,
        Avatar = 1L << 38,
        Shadowlord = 1L << 39,
        Destroyer = 1L << 40,
        HolyKnight = 1L << 41,
        Predator = 1L << 42,
        Shinobi = 1L << 43,
        Archangel = 1L << 44,
        Druid = 1L << 45,
        Warlock = 1L << 46,
        Shinigami = 1L << 47,
        Cogmaster = 1L << 48,
        Bombardier = 1L << 49,
        Mechmaster = 1L << 50,
        Artillerist = 1L << 51,
        Wanderer = 1L << 52,
        Drifter = 1L << 53,
        VoidRunner = 1L << 54,
        TimeTraveler = 1L << 55,
        Dimencionalist = 1L << 56,
        Keymaster = 1L << 57,
        Reaper = 1L << 58,
        Chronomancer = 1L << 59,
        Phantom = 1L << 60,
        Chronoshifter = 1L << 61
    }
}
