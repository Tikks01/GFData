using GFDataApi.Config.JsonConverters;
using GFDataApi.DataTypes;
using GFDataApi.DataTypes.BaseClasses;
using GFDataApi.DataTypes.Enums;
using GFDataApi.DataTypes.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GFDataApi.Data
{
    [Table("Items")]
    public record ItemData : IDataType<uint>
    {
        public uint Id { get; set; }
        public string? IconFilename { get; set; }
        public string? ModelId { get; set; }
        public string? ModelFilename { get; set; }
        public string? WeaponEffectId { get; set; }
        public string? FlyEffectId { get; set; }
        public string? UsedEffectId { get; set; }
        public string? UsedSoundName { get; set; }
        public string? EnchanceEffectId { get; set; }
        [JsonConverter(typeof(TranslatableStringConverter))]
        public TranslatableString Name { get; set; } = new();
        public EEquipType EquipType { get; set; }
        public EItemType ItemType { get; set; }
        public uint OpFlags { get; set; }
        public uint OpFlagsPlus { get; set; }
        public EItemTarget Target { get; set; }
        public uint RestrictGender { get; set; }
        public uint RestrictLevel { get; set; }
        public uint RestrictMaxLevel { get; set; }
        public short RebirthCount { get; set; }
        public short RebirthScore { get; set; }
        public short RebirthMaxScore { get; set; }
        public uint RestrictAlign { get; set; }
        public uint RestrictPrestige { get; set; }
        [JsonConverter(typeof(RestrictClassJsonConverter))]
        public RestrictClass RestrictClass { get; set; } = new();
        public EItemQuality ItemQuality { get; set; }
        public ushort ItemGroup { get; set; }
        public int CastingTime { get; set; }
        public int CooldownTime { get; set; }
        public ushort CooldownGroup { get; set; }
        public double MaxHp { get; set; }
        public double MaxMp { get; set; }
        public short Str { get; set; }
        public short Con { get; set; }
        public short Int { get; set; }
        public short Vol { get; set; }
        public short Dex { get; set; }
        public double AvgPhysicoDamage { get; set; }
        public double RandPhysicoDamage { get; set; }
        public ushort AttackRange { get; set; }
        public ushort AttackSpeed { get; set; }
        public double Attack { get; set; }
        public double RangeAttack { get; set; }
        public double PhysicoDefence { get; set; }
        public double MagicDamage { get; set; }
        public double MagicDefence { get; set; }
        public sbyte HitRate { get; set; }
        public sbyte DodgeRate { get; set; }
        public short PhysicoCriticalRate { get; set; }
        public uint PhysicoCriticalDamage { get; set; }
        public short MagicCriticalRate { get; set; }
        public uint MagicCriticalDamage { get; set; }
        public short PhysicalPenetration { get; set; }
        public short MagicalPenetration { get; set; }
        public short PhysicalPenetrationDefence { get; set; }
        public short MagicalPenetrationDefence { get; set; }
        public EAttribute Attribute { get; set; }
        public short AttributeRate { get; set; }
        public uint AttributeDamage { get; set; }
        public uint AttributeResist { get; set; }
        public EMonsterType SpecialType { get; set; }
        public short SpecialRate { get; set; }
        public uint SpecialDamage { get; set; }
        public sbyte DropRate { get; set; }
        public uint DropIndex { get; set; }
        //[JsonConverter(typeof(TreasureBuffsJsonConverter))]
        public int[] TreasureBuffs { get; set; } = new int[4];
        public EBuffIconType EnchantType { get; set; }
        public int EnchantId { get; set; }
        public short ExpertLevel { get; set; }
        public int ExpertEnchantId { get; set; }
        public ushort ElfSkillId { get; set; }
        public ETimeType EnchantTimeType { get; set; }
        public int EnchantDuration { get; set; }
        public uint LimitType { get; set; }
        public uint DueDateTime { get; set; }
        public byte BackPackSize { get; set; }
        public byte MaxSockets { get; set; }
        public double SocketRate { get; set; }
        public double MaxDurability { get; set; }
        public ushort MaxStack { get; set; }
        public uint ShopPriceType { get; set; }
        public double SysPrice { get; set; }
        public string? RestrictEventPosId { get; set; }
        public string? TargetIDs { get; set; }
        public uint MissionPosId { get; set; }
        public string? BlockRate { get; set; }
        public byte LogLevel { get; set; }
        public EAuctionType AuctionType { get; set; }
        public int[] ExtraData { get; set; } = new int[3];
        [JsonConverter(typeof(TranslatableStringConverter))]
        public TranslatableString Tip { get; set; } = new();

        [NotMapped]
        public bool ItemMall { get; set; }
        [NotMapped]
        public bool HealthTime { get; set; }
        [NotMapped]
        public sbyte ItemMallAddRate { get; set; }
        [NotMapped]
        public bool ItemFlameProof { get; set; }
        [NotMapped]
        public short SafeStregthen { get; set; }
        [NotMapped]
        public short StrengthenType { get; set; }
    }
}
