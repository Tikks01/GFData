using GFDataApi.BaseClasses;
using GFDataApi.Config;
using GFDataApi.Enums;
using GFDataApi.Querys.Records;
using GFDataApi.Translate;
using GFDataApi.Utils;
using System.Text;

namespace GFDataApi.Querys.Classes
{
    public class CSpellQuery : BaseQuery<int, SpellData>
    {              
        public CSpellQuery() : base() {             
            Translations = new TSpell();
        }

        public override async Task<bool> Init()
        {            
            FileName = "Spell";
            await Task.WhenAll(
                Load()
              , LoadTranslations()
            );
            return true;        
        }

        protected override async Task<SpellData> Deserialize(IniLine IniLine)
        {
            return await Task.Run(() =>
            {                
                SpellData data = new();                

                data.Id = IniLine.Next<int>();
                data.IconFileName = IniLine.Next<string>();
                data.CastingAnimationId = IniLine.Next<string>();
                data.ShootingAnimationId = IniLine.Next<string>();
                data.CastingEffectId = IniLine.Next<string>();
                data.ShootingEffectId = IniLine.Next<string>();
                data.FlyEffectId = IniLine.Next<string>();
                data.HitEffectId = IniLine.Next<string>();
                data.HitNode = IniLine.Next<string>();
                data.HitSound = IniLine.Next<string>();
                data.ShowEquip = IniLine.Next<int>();
                data.Name = IniLine.Next<string>();
                data.SpellType = IniLine.Next<ESpellType>();                
                data.SpellFlag = IniLine.Next<ESpellFlag>();
                data.OpFlag = IniLine.Next<ulong>();                
                data.Target = IniLine.Next<ESpellTarget>();
                data.RestrictEquip = IniLine.Next<int>();
                data.RestrictLevel = IniLine.Next<int>();
                data.RestrictClass.LoadFromHexString(IniLine.Next<string>()!);
                data.RestrictRebirthCount = IniLine.Next<int>();
                data.RestrictRebirthScore = IniLine.Next<int>();                
                data.RestrictForm = IniLine.Next<EFormType>();
                data.UseItemId = IniLine.Next<int>();
                data.ComboPoints = IniLine.Next<int>();
                data.CastingTime = IniLine.Next<int>();
                data.CooldownTime = IniLine.Next<int>();
                data.CooldownGroup = IniLine.Next<int>();                
                data.AreaSpellType = IniLine.Next<EAreaSpellType>();
                data.Range = IniLine.Next<int>();
                data.Radius = IniLine.Next<int>();
                data.AreaSpellParameter = IniLine.Next<string>();
                data.Mp = IniLine.Next<double>();
                data.Hp = IniLine.Next<double>();
                data.HpRate = IniLine.Next<int>();
                data.KeepHitingPeriod = IniLine.Next<int>();
                data.AvgDamage = IniLine.Next<double>();
                data.RandDamage = IniLine.Next<double>();
                data.DamageRate = IniLine.Next<double>();
                data.AvgDamage2 = IniLine.Next<double>();
                data.RandDamage2 = IniLine.Next<double>();
                data.DamageRate2 = IniLine.Next<double>();
                data.AvgDamage3 = IniLine.Next<double>();
                data.RandDamage3 = IniLine.Next<double>();
                data.DamageRate3 = IniLine.Next<double>();
                data.AvgDamage4 = IniLine.Next<double>();
                data.RandDamage4 = IniLine.Next<double>();
                data.DamageRate4 = IniLine.Next<double>();
                data.AvgDamage5 = IniLine.Next<double>();
                data.RandDamage5 = IniLine.Next<double>();
                data.DamageRate5 = IniLine.Next<double>();
                data.BreakSpellRate = IniLine.Next<int>();                
                data.Attribute = IniLine.Next<EAttribute>();
                data.AttributeDamage = IniLine.Next<double>();
                data.AttributeRate = IniLine.Next<int>();                
                data.SpecialType = IniLine.Next<EMonsterType>();
                data.SpecialRate = IniLine.Next<int>();
                data.SpecialDamage = IniLine.Next<int>();
                data.EnchantId = IniLine.Next<int>();
                data.EnchantRate = IniLine.Next<int>();
                data.EnchantDuration = IniLine.Next<int>();
                data.EnchantDuration2 = IniLine.Next<int>();
                data.EnchantDuration3 = IniLine.Next<int>();
                data.EnchantDuration4 = IniLine.Next<int>();
                data.EnchantDuration5 = IniLine.Next<int>();
                data.SelfEnchantId = IniLine.Next<int>();
                data.SelfEnchantRate = IniLine.Next<int>();
                data.SelfEnchantDuration = IniLine.Next<int>();
                data.LearnPrice = IniLine.Next<double>();
                data.LearnDependentSpellId = IniLine.Next<int>();
                data.SpellSet = IniLine.Next<int>();
                data.Tip = IniLine.Next<string>();

                return data;
            });           
        }

        protected override int GetId(SpellData QueryItem)
        {
            return QueryItem.Id;
        }

        protected override async Task<string> Serialize(SpellData QueryItemObject)
        {
            return await Task.Run(() =>
            {

                StringBuilder sb = new();
                IniLineMaker line = new IniLineMaker();

                line.Put(QueryItemObject.Id);
                line.Put(QueryItemObject.IconFileName);
                line.Put(QueryItemObject.CastingAnimationId);
                line.Put(QueryItemObject.ShootingAnimationId);                
                line.Put(QueryItemObject.CastingEffectId);
                line.Put(QueryItemObject.ShootingEffectId);
                line.Put(QueryItemObject.FlyEffectId);
                line.Put(QueryItemObject.HitEffectId);
                line.Put(QueryItemObject.HitNode);
                line.Put(QueryItemObject.HitSound);
                line.Put(QueryItemObject.ShowEquip);                
                line.Put(QueryItemObject.Name);
                line.Put<ESpellType>(QueryItemObject.SpellType);
                line.Put<ESpellFlag>(QueryItemObject.SpellFlag);
                line.Put(QueryItemObject.OpFlag);
                line.Put<ESpellTarget>(QueryItemObject.Target);

                line.Put(QueryItemObject.RestrictEquip);
                line.Put(QueryItemObject.RestrictLevel);
                line.Put(QueryItemObject.RestrictClass);                
                line.Put(QueryItemObject.RestrictRebirthCount);
                line.Put(QueryItemObject.RestrictRebirthScore);
                line.Put<EFormType>(QueryItemObject.RestrictForm);

                line.Put(QueryItemObject.UseItemId);                
                line.Put(QueryItemObject.ComboPoints);
                line.Put(QueryItemObject.CastingTime);
                line.Put(QueryItemObject.CooldownTime);
                line.Put(QueryItemObject.CooldownGroup);
                line.Put<EAreaSpellType>(QueryItemObject.AreaSpellType);                
                line.Put(QueryItemObject.Range);
                line.Put(QueryItemObject.Radius);
                line.Put(QueryItemObject.AreaSpellParameter);
                line.Put(QueryItemObject.Mp);
                line.Put(QueryItemObject.Hp);
                line.Put(QueryItemObject.HpRate);
                line.Put(QueryItemObject.KeepHitingPeriod);
                line.Put(QueryItemObject.AvgDamage);
                line.Put(QueryItemObject.RandDamage);
                line.Put(QueryItemObject.DamageRate);
                line.Put(QueryItemObject.AvgDamage2);
                line.Put(QueryItemObject.RandDamage2);
                line.Put(QueryItemObject.DamageRate2);
                line.Put(QueryItemObject.AvgDamage3);
                line.Put(QueryItemObject.RandDamage3);
                line.Put(QueryItemObject.DamageRate3);
                line.Put(QueryItemObject.AvgDamage4);
                line.Put(QueryItemObject.RandDamage4);
                line.Put(QueryItemObject.DamageRate4);
                line.Put(QueryItemObject.AvgDamage5);
                line.Put(QueryItemObject.RandDamage5);
                line.Put(QueryItemObject.DamageRate5);
                line.Put(QueryItemObject.BreakSpellRate);
                line.Put<EAttribute>(QueryItemObject.Attribute);                
                line.Put(QueryItemObject.AttributeDamage);
                line.Put(QueryItemObject.AttributeRate);
                line.Put<EMonsterType>(QueryItemObject.SpecialType);                
                line.Put(QueryItemObject.SpecialRate);
                line.Put(QueryItemObject.SpecialDamage);

                line.Put(QueryItemObject.EnchantId);
                line.Put(QueryItemObject.EnchantRate);
                line.Put(QueryItemObject.EnchantDuration);
                line.Put(QueryItemObject.EnchantDuration2);
                line.Put(QueryItemObject.EnchantDuration3);
                line.Put(QueryItemObject.EnchantDuration4);
                line.Put(QueryItemObject.EnchantDuration5);
                line.Put(QueryItemObject.SelfEnchantId);
                line.Put(QueryItemObject.SelfEnchantRate);
                line.Put(QueryItemObject.SelfEnchantDuration);
                line.Put(QueryItemObject.LearnPrice);
                line.Put(QueryItemObject.LearnDependentSpellId);
                line.Put(QueryItemObject.SpellSet);
                line.Put(QueryItemObject.Tip);

                return line.GetString();
            });
        }                

        public override async Task<bool> Save()
        {
            string pathDb = GFConfiguration.Instance.Data.PathToDatabase;            
            return await SaveToFile(pathDb);
        }

    }
}
