using GFDataApi.DataTypes;
using GFDataApi.Enums;
using GFDataApi.JsonConverters;
using GFDataApi.Querys.Records;
using System.Text.Json.Serialization;

namespace GFDataApi.Querys.Data
{
    public record EnchantData : IComparable<SpellData>
    {
        public int Id { get; set; }
        public string? IconFileName { get; set; }
        public uint AnimationId { get; set; }
        public string? EffectId { get; set; }
        public string? EffectNode { get; set; }
        public string? Name { get; set; }
        public EEnchantType EnchantType { get; set; }
        public EEnchantFlag EnchantFlag { get; set; }
        public EEnchantCategory EnchantCategory { get; set; }
        public ushort ImuneMonsterType { get; set; }
        [JsonConverter(typeof(EnchantCommandsJsonConverter))]
        public EnchantCommands EnchantCommands { get; set; }        
        public int Period { get; set; }
        public ushort HiWord { get; set; }
        public byte LowWord { get; set; }
        public string? TransitionId { get; set; }
        public EEnchantTransition EnchantTransition { get; set; }
        public sbyte TransitionRate { get; set; }
        public int TransitionDuration { get; set; }
        public int TransitionPeriod { get; set; }
        public string? TransitionIconFileName { get; set; }
        public EEnchantType TransitionEnchantType { get; set; }
        public EEnchantFlag TransitionEnchantFlag { get; set; }
        public EEnchantCategory TransitionEnchantCategory { get; set; }
        public uint TransitionAnimationId { get; set; }
        public string? TransitionEffectId { get; set; }
        public string? TransitionEffectNode { get; set; }
        public string? TransitionEffectDuration { get; set; }
        public string? TransitionDurationNode { get; set; }        
        public int TransitionCooldownTime { get; set; }
        public uint WeaponFlag { get; set; }
        public ushort TransitionEnchantHiWord { get; set; }
        public byte TransitionEnchantLowWord { get; set; }
        public string? Tip { get; set; }
        public string? TransitionTip { get; set; }
        public string? TransitionName { get; set; }
        public ushort MaxStack { get; set; }

        public int CompareTo(SpellData? other)
        {
            if (other == null) return 1;
            if (this.Id > other.Id) return 1;
            if (this.Id < other.Id) return -1;
            return 0;
        }

        public EnchantData()
        {
            EnchantCommands = new EnchantCommands();
        }
    }
}
