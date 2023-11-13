using GFDataApi.BaseClasses;
using GFDataApi.Querys.Data;
using GFDataApi.Translate;
using GFDataApi.Utils;

namespace GFDataApi.Querys.Classes
{
    internal class CEquipSetQuery : BaseQuery<uint, EquipSetData>
    {

        public CEquipSetQuery() {
            Translations = new TEquipSet();
        }
        public override async Task<bool> Init()
        {
            await Task.WhenAll(
                Load()
              , LoadTranslations()
            );
            return true;
        }

        protected override async Task<EquipSetData> Deserialize(IniLine IniLine)
        {
            return await Task.Run(() =>
            {
                EquipSetData data = new();

                data.Id = IniLine.Next<uint>();
                data.Name = IniLine.Next<string>();
                data.EffectId = IniLine.Next<uint>();
                data.RebirthAddAttrTable.LoadFromString(IniLine.Next<string>()!);
                data.HeadEquipId.LoadFromString(IniLine.Next<string>()!);                
                data.ChestEquipId.LoadFromString(IniLine.Next<string>()!);
                data.PantsEquipId.LoadFromString(IniLine.Next<string>()!);
                data.GloveEquipId.LoadFromString(IniLine.Next<string>()!);
                data.FeetEquipId.LoadFromString(IniLine.Next<string>()!);
                data.BackEquipId.LoadFromString(IniLine.Next<string>()!);
                data.Weapon1EquipId.LoadFromString(IniLine.Next<string>()!);
                data.Weapon2EquipId.LoadFromString(IniLine.Next<string>()!);
                data.Weapon3EquipId.LoadFromString(IniLine.Next<string>()!);

                for (int i = 0; i < data.AddAttrTable.MaxAttributes; i++)
                {
                    data.AddAttrTable.Add(IniLine.Next<int>());
                }

                data.ClassRestriction.LoadFromHexString(IniLine.Next<string>()!);

                return data;
            });
        }

        protected override uint GetId(EquipSetData QueryItem)
        {
            return QueryItem.Id;
        }

        protected override async Task<string> Serialize(EquipSetData QueryItemObject)
        {
            return await Task.Run(() =>
            {
                IniLineMaker line = new();

                line.Put(QueryItemObject.Id);
                line.Put(QueryItemObject.Name);
                line.Put(QueryItemObject.EffectId);
                line.Put(QueryItemObject.RebirthAddAttrTable);
                line.Put(QueryItemObject.HeadEquipId);
                line.Put(QueryItemObject.ChestEquipId);
                line.Put(QueryItemObject.PantsEquipId);
                line.Put(QueryItemObject.GloveEquipId);
                line.Put(QueryItemObject.FeetEquipId);
                line.Put(QueryItemObject.BackEquipId);
                line.Put(QueryItemObject.Weapon1EquipId);
                line.Put(QueryItemObject.Weapon2EquipId);
                line.Put(QueryItemObject.Weapon3EquipId);

                for (int i = 0; i < QueryItemObject.AddAttrTable.MaxAttributes; i++)
                {
                    line.Put(QueryItemObject.AddAttrTable.Get(i));
                }

                line.Put(QueryItemObject.ClassRestriction);

                return line.GetString();
            });
        }
    }
}
