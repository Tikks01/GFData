using GFDataApi.DataTypes.Enums;

namespace GFDataApi.Data
{
    public record ItemComboData
    {
        public uint Id { get; set; }
        public string? ModelFileName { get; set; }
        public string? Prefix { get; set; }
        public string? RestrictItemType { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public EItemQuality Quality { get; set; }
        public ulong Star { get; set; }
        public short GroupNum { get; set; }
        public ushort NameWeights { get; set; }
        public byte Rate { get; set; }
        public byte IsRepeat { get; set; }
        public uint MaxHp { get; set; }
        public uint MaxMp { get; set; }
        public short Str { get; set; }
        public short Con { get; set; }
        public short Int { get; set; }
        public short Vol { get; set; }
        public short Dex { get; set; }
        public double AvgPhysicoDamage { get; set; }
        public double Attack { get; set; }
        public double RangeAttack { get; set; }
        public double PhysicoDefence { get; set; }
        public double MagicAttack { get; set; }
        public double MagicDefence { get; set; }
        public byte HitRate { get; set; }
        public byte DodgeRate { get; set; }
        public short PhysicalPenetration { get; set; }
        public short MagicalPenetration { get; set; }
        public short PhysicalPenetrationDefence { get; set; }
        public short MagicalPenetrationDefence { get; set; }
        public string? BuffIconFileName { get; set; }
        public int EnchantId { get; set; }
        public int EnchantId2 { get; set; }
        public byte MaxSocket { get; set; }
        public sbyte SocketRate { get; set; }
        public ushort AddDurability { get; set; }
        public uint AddPrice { get; set; }
        public sbyte BlockRate { get; set; }
        public byte LogLevel { get; set; }
    }
}
