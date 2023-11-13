using GFDataApi.BaseClasses;
using GFDataApi.DataTypes;
using GFDataApi.Enums;
using GFDataApi.Querys.Data;
using GFDataApi.Translate;
using GFDataApi.Utils;

namespace GFDataApi.Querys.Classes
{
    public class CEnchantQuery : BaseQuery<int, EnchantData>
    {
        public CEnchantQuery() : base()
        {            
            Translations = new TEnchant();
        }        

        protected override async Task<EnchantData> Deserialize(IniLine IniLine)
        {
            return await Task.Run(() =>
            {
                EnchantData data = new();

                data.Id = IniLine.Next<int>();
                data.IconFileName = IniLine.Next<string>();
                data.AnimationId = IniLine.Next<uint>();
                data.EffectId = IniLine.Next<string>();
                data.EffectNode = IniLine.Next<string>();
                data.Name = IniLine.Next<string>();
                data.EnchantType = IniLine.Next<EEnchantType>();
                data.EnchantFlag = IniLine.Next<EEnchantFlag>();
                data.EnchantCategory = IniLine.Next<EEnchantCategory>();
                data.ImuneMonsterType = IniLine.Next<ushort>();
                
                for (int i = 0; i < data.EnchantCommands.Max(); i++)
                {
                    EnchantCommand cmd = data.EnchantCommands.Add()!;
                    cmd.Id = IniLine.Next<uint>();
                    cmd.Param1 = IniLine.Next<double>();
                    cmd.Param2 = IniLine.Next<double>();
                    cmd.Param3 = IniLine.Next<double>();
                    cmd.Param4 = IniLine.Next<double>();
                    cmd.Param5 = IniLine.Next<double>();
                    cmd.Param6 = IniLine.Next<double>();
                }

                data.Period = IniLine.Next<int>();
                data.HiWord = IniLine.Next<ushort>();
                data.LowWord = IniLine.Next<byte>();
                data.TransitionId = IniLine.Next<string>();
                data.EnchantTransition = IniLine.Next<EEnchantTransition>();
                data.TransitionRate = IniLine.Next<sbyte>();
                data.TransitionDuration = IniLine.Next<int>();
                data.TransitionPeriod = IniLine.Next<int>();
                data.TransitionIconFileName = IniLine.Next<string>();
                data.TransitionEnchantType = IniLine.Next<EEnchantType>();
                data.TransitionEnchantFlag = IniLine.Next<EEnchantFlag>();
                data.TransitionEnchantCategory = IniLine.Next<EEnchantCategory>();
                data.TransitionAnimationId = IniLine.Next<uint>();
                data.TransitionEffectId = IniLine.Next<string>();
                data.TransitionEffectNode = IniLine.Next<string>();
                data.TransitionEffectDuration = IniLine.Next<string>();
                data.TransitionDurationNode = IniLine.Next<string>();
                data.TransitionCooldownTime = IniLine.Next<int>();
                data.WeaponFlag = IniLine.Next<uint>();
                data.TransitionEnchantHiWord = IniLine.Next<ushort>();
                data.TransitionEnchantLowWord = IniLine.Next<byte>();
                data.Tip = IniLine.Next<string>();
                data.TransitionTip = IniLine.Next<string>();
                data.TransitionName = IniLine.Next<string>();
                data.MaxStack = IniLine.Next<ushort>();

                return data;
            });
        }

        protected override async Task<string> Serialize(EnchantData QueryItemObject)
        {
            return await Task.Run(() =>
            {                
                IniLineMaker line = new IniLineMaker();

                line.Put(QueryItemObject.Id);
                line.Put(QueryItemObject.IconFileName);
                line.Put(QueryItemObject.AnimationId);
                line.Put(QueryItemObject.EffectId);
                line.Put(QueryItemObject.EffectNode);
                line.Put(QueryItemObject.Name);
                line.Put<EEnchantType>(QueryItemObject.EnchantType);
                line.Put<EEnchantFlag>(QueryItemObject.EnchantFlag);
                line.Put<EEnchantCategory>(QueryItemObject.EnchantCategory);
                line.Put(QueryItemObject.ImuneMonsterType);

                for (int i = 0; i < QueryItemObject.EnchantCommands.Max(); i++)
                {
                    EnchantCommand cmd = QueryItemObject.EnchantCommands.GetEnchant(i);
                    line.Put(cmd.Id);
                    line.Put(cmd.Param1);
                    line.Put(cmd.Param2);
                    line.Put(cmd.Param3);
                    line.Put(cmd.Param4);
                    line.Put(cmd.Param5);
                    line.Put(cmd.Param6);
                }

                line.Put(QueryItemObject.Period);
                line.Put(QueryItemObject.HiWord);
                line.Put(QueryItemObject.LowWord);
                line.Put(QueryItemObject.TransitionId);
                line.Put<EEnchantTransition>(QueryItemObject.EnchantTransition);
                line.Put(QueryItemObject.TransitionRate);
                line.Put(QueryItemObject.TransitionDuration);
                line.Put(QueryItemObject.TransitionPeriod);
                line.Put(QueryItemObject.TransitionIconFileName);
                line.Put<EEnchantType>(QueryItemObject.TransitionEnchantType);
                line.Put<EEnchantFlag>(QueryItemObject.TransitionEnchantFlag);
                line.Put<EEnchantCategory>(QueryItemObject.TransitionEnchantCategory);
                line.Put(QueryItemObject.TransitionAnimationId);
                line.Put(QueryItemObject.TransitionEffectId);
                line.Put(QueryItemObject.TransitionEffectNode);
                line.Put(QueryItemObject.TransitionEffectDuration);
                line.Put(QueryItemObject.TransitionDurationNode);
                line.Put(QueryItemObject.TransitionCooldownTime);
                line.Put(QueryItemObject.WeaponFlag);
                line.Put(QueryItemObject.TransitionEnchantHiWord);
                line.Put(QueryItemObject.TransitionEnchantLowWord);
                line.Put(QueryItemObject.Tip);
                line.Put(QueryItemObject.TransitionTip);
                line.Put(QueryItemObject.TransitionName);
                line.Put(QueryItemObject.MaxStack);

                return line.GetString();
            });
        }

        protected override int GetId(EnchantData QueryItem)
        {
            return QueryItem.Id;
        }

        public override async Task<bool> Init()
        {
            await Task.WhenAll(
                Load()
              , LoadTranslations()
            );
            return true;
        }
    }
}
