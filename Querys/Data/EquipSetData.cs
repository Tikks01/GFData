using GFDataApi.DataTypes;

namespace GFDataApi.Querys.Data
{
    public record class EquipSetData
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public uint EffectId { get; set; }
        public SumAddAttrs RebirthAddAttrTable { get; set; } = new SumAddAttrs();
        public SumAddAttrs HeadEquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs ChestEquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs PantsEquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs GloveEquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs FeetEquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs BackEquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs Weapon1EquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs Weapon2EquipId { get; set; } = new SumAddAttrs();
        public SumAddAttrs Weapon3EquipId { get; set; } = new SumAddAttrs();        
        public AddAttrTable AddAttrTable { get; set; } = new AddAttrTable();
        public RestrictClass ClassRestriction { get; set; } = new RestrictClass();
    }
}
