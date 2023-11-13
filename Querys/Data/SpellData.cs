using GFDataApi.DataTypes;
using GFDataApi.Enums;
using GFDataApi.Querys.Classes;

namespace GFDataApi.Querys.Records
{
    public record class SpellData : IComparable<SpellData>
    {
        public int Id { get; set; }
        public string? IconFileName { get; set; }
        public string? CastingAnimationId { get; set; }
        public string? ShootingAnimationId { get; set; }
        public string? CastingEffectId { get; set; }
        public string? ShootingEffectId { get; set; }
        public string? FlyEffectId { get; set; }
        public string? HitEffectId { get; set; }
        public string? HitNode { get; set; }
        public string? HitSound { get; set; }
        public int ShowEquip { get; set; }
        public string? Name { get; set; }
        public ESpellType SpellType { get; set; }
        public ESpellFlag SpellFlag { get; set; }
        public ulong OpFlag { get; set; }
        public ESpellTarget Target { get; set; }
        public int RestrictEquip { get; set; }
        public int RestrictLevel { get; set; }
        public RestrictClass RestrictClass { get; set; }
        //public string? RestrictClass { get; set; } //ERestrictClass RestrictClass { get; set; } provisorio, algumas vezes o valor é convertido para hexadecimal, algumas vezes não.
                                                  //esta como string para manter os valores originais ate decifrar a logica por tras da conversão em hexa
        public int RestrictRebirthCount { get; set; }
        public int RestrictRebirthScore { get; set; }
        public EFormType RestrictForm { get; set; }
        public int UseItemId { get; set; }
        public int ComboPoints { get; set; }
        public int CastingTime { get; set; }
        public long CooldownTime { get; set; }
        public long CooldownGroup { get; set; }
        public EAreaSpellType AreaSpellType { get; set; }
        public int Range { get; set; }
        public int Radius { get; set; }
        public string? AreaSpellParameter { get; set; }
        public double Mp { get; set; }
        public double Hp { get; set; }
        public int HpRate { get; set; }
        public int KeepHitingPeriod { get; set; }
        public double AvgDamage { get; set; }
        public double RandDamage { get; set; }
        public double DamageRate { get; set; }
        public double AvgDamage2 { get; set; }
        public double RandDamage2 { get; set; }
        public double DamageRate2 { get; set; }
        public double AvgDamage3 { get; set; }
        public double RandDamage3 { get; set; }
        public double DamageRate3 { get; set; }
        public double AvgDamage4 { get; set; }
        public double RandDamage4 { get; set; }
        public double DamageRate4 { get; set; }
        public double AvgDamage5 { get; set; }
        public double RandDamage5 { get; set; }
        public double DamageRate5 { get; set; }
        public int BreakSpellRate { get; set; }
        public EAttribute Attribute { get; set; }
        public double AttributeDamage { get; set; }
        public int AttributeRate { get; set; }
        public EMonsterType SpecialType { get; set; }
        public int SpecialRate { get; set; }
        public int SpecialDamage { get; set; }
        public int EnchantId { get; set; }
        public int EnchantRate { get; set; }
        public int EnchantDuration { get; set; }
        public int EnchantDuration2 { get; set; }
        public int EnchantDuration3 { get; set; }
        public int EnchantDuration4 { get; set; }
        public int EnchantDuration5 { get; set; }
        public int SelfEnchantId { get; set; }
        public int SelfEnchantRate { get; set; }
        public int SelfEnchantDuration { get; set; }
        public double LearnPrice { get; set; }
        public int LearnDependentSpellId { get; set; }
        public int SpellSet { get; set; }
        public string? Tip { get; set; }

        public SpellData()
        {
            RestrictClass = new RestrictClass();
        }
        public int CompareTo(SpellData? other)
        {
            if (other == null) return 1;
            if (this.Id > other.Id) return 1;
            if (this.Id < other.Id) return -1;
            return 0;
        }
    }
}
