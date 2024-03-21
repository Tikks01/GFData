namespace GFDataApi.Querys.Classes
{
    public class CItemQuery //: BaseQuery<uint, ItemData>
    {

        //    public CItemQuery(IDataContext<uint, ItemData> DataContext) : base(DataContext)
        //    {
        //    }
        //    private async Task<ItemData> Deserialize(IniLine IniLine)
        //    {
        //        return await Task.Run(() =>
        //        {
        //            ItemData data = new();
        //            data.Id = IniLine.Next<uint>();
        //            data.IconFilename = IniLine.Next<string>();
        //            data.ModelId = IniLine.Next<string>();
        //            data.ModelFilename = IniLine.Next<string>();
        //            data.WeaponEffectId = IniLine.Next<string>();
        //            data.FlyEffectId = IniLine.Next<string>();
        //            data.UsedEffectId = IniLine.Next<string>();
        //            data.UsedSoundName = IniLine.Next<string>();
        //            data.EnchanceEffectId = IniLine.Next<string>();
        //            data.Name = IniLine.Next<string>();
        //            data.ItemType = IniLine.Next<EItemType>();
        //            data.EquipType = IniLine.Next<EEquipType>();
        //            data.OpFlags = IniLine.Next<uint>();
        //            data.OpFlagsPlus = IniLine.Next<uint>();
        //            data.Target = IniLine.Next<EItemTarget>();
        //            data.RestrictGender = IniLine.Next<uint>();
        //            data.RestrictLevel = IniLine.Next<uint>();
        //            data.RestrictMaxLevel = IniLine.Next<uint>();
        //            data.RebirthCount = IniLine.Next<short>();
        //            data.RebirthScore = IniLine.Next<short>();
        //            data.RebirthMaxScore = IniLine.Next<short>();
        //            data.RestrictAlign = IniLine.Next<uint>();
        //            data.RestrictPrestige = IniLine.Next<uint>();
        //            data.RestrictClass.LoadFromHexString(IniLine.Next<string>()!);
        //            data.ItemQuality = IniLine.Next<EItemQuality>();
        //            data.ItemGroup = IniLine.Next<ushort>();
        //            data.CastingTime = IniLine.Next<int>();
        //            data.CooldownTime = IniLine.Next<int>();
        //            data.CooldownGroup = IniLine.Next<ushort>();
        //            data.MaxHp = IniLine.Next<double>();
        //            data.MaxMp = IniLine.Next<double>();
        //            data.Str = IniLine.Next<short>();
        //            data.Con = IniLine.Next<short>();
        //            data.Int = IniLine.Next<short>();
        //            data.Vol = IniLine.Next<short>();
        //            data.Dex = IniLine.Next<short>();
        //            data.AvgPhysicoDamage = IniLine.Next<double>();
        //            data.RandPhysicoDamage = IniLine.Next<double>();
        //            data.AttackRange = IniLine.Next<ushort>();
        //            data.AttackSpeed = IniLine.Next<ushort>();
        //            data.Attack = IniLine.Next<double>();
        //            data.RangeAttack = IniLine.Next<double>();
        //            data.PhysicoDefence = IniLine.Next<double>();
        //            data.MagicDamage = IniLine.Next<double>();
        //            data.MagicDefence = IniLine.Next<double>();
        //            data.HitRate = IniLine.Next<sbyte>();
        //            data.DodgeRate = IniLine.Next<sbyte>();
        //            data.PhysicoCriticalRate = IniLine.Next<short>();
        //            data.PhysicoCriticalDamage = IniLine.Next<uint>();
        //            data.MagicCriticalRate = IniLine.Next<short>();
        //            data.MagicCriticalDamage = IniLine.Next<uint>();
        //            data.PhysicalPenetration = IniLine.Next<short>();
        //            data.MagicalPenetration = IniLine.Next<short>();
        //            data.PhysicalPenetrationDefence = IniLine.Next<short>();
        //            data.MagicalPenetrationDefence = IniLine.Next<short>();
        //            data.Attribute = IniLine.Next<EAttribute>();
        //            data.AttributeRate = IniLine.Next<short>();
        //            data.AttributeDamage = IniLine.Next<uint>();
        //            data.AttributeResist = IniLine.Next<uint>();
        //            data.SpecialType = IniLine.Next<EMonsterType>();
        //            data.SpecialRate = IniLine.Next<short>();
        //            data.SpecialDamage = IniLine.Next<uint>();
        //            data.DropRate = IniLine.Next<sbyte>();
        //            data.DropIndex = IniLine.Next<uint>();

        //            for (int i = 0; i < data.TreasureBuffs.Count(); i++)
        //            {
        //                data.TreasureBuffs.Set(i, IniLine.Next<int>());
        //            }

        //            data.EnchantType = IniLine.Next<EBuffIconType>();
        //            data.EnchantId = IniLine.Next<int>();
        //            data.ExpertLevel = IniLine.Next<short>();
        //            data.ExpertEnchantId = IniLine.Next<int>();
        //            data.ElfSkillId = IniLine.Next<ushort>();
        //            data.EnchantTimeType = IniLine.Next<ETimeType>();
        //            data.EnchantDuration = IniLine.Next<int>();
        //            data.LimitType = IniLine.Next<uint>();
        //            data.DueDateTime = IniLine.Next<uint>();
        //            data.BackPackSize = IniLine.Next<byte>();
        //            data.MaxSockets = IniLine.Next<byte>();
        //            data.SocketRate = IniLine.Next<double>();
        //            data.MaxDurability = IniLine.Next<double>();
        //            data.MaxStack = IniLine.Next<ushort>();
        //            data.ShopPriceType = IniLine.Next<uint>();
        //            data.SysPrice = IniLine.Next<double>();
        //            data.RestrictEventPosId = IniLine.Next<string>();

        //            data.TargetIDs = IniLine.Next<string>();
        //            data.BlockRate = IniLine.Next<string>();
        //            data.LogLevel = IniLine.Next<byte>();
        //            data.AuctionType = IniLine.Next<EAuctionType>();

        //            for (int i = 0; i < data.ExtraData.Length; i++ )
        //            {
        //                data.ExtraData[i] = IniLine.Next<int>();
        //            }

        //            data.Tip = IniLine.Next<string>();

        //            data.ItemMall = isItemMall;
        //            data.HealthTime = false;
        //            data.ItemMallAddRate = 0;
        //            data.ItemFlameProof = false;
        //            data.SafeStregthen = 0;
        //            data.StrengthenType = 0;

        //            return data;
        //        });
        //    }
        //    private async Task<string> Serialize(ItemData QueryItemObject)
        //    {
        //        return await Task.Run(() =>
        //        {
        //            IniLineMaker line = new IniLineMaker();

        //            line.Put(QueryItemObject.Id);
        //            line.Put(QueryItemObject.IconFilename);
        //            line.Put(QueryItemObject.ModelId);
        //            line.Put(QueryItemObject.ModelFilename);
        //            line.Put(QueryItemObject.WeaponEffectId);
        //            line.Put(QueryItemObject.FlyEffectId);
        //            line.Put(QueryItemObject.UsedEffectId);
        //            line.Put(QueryItemObject.UsedSoundName);
        //            line.Put(QueryItemObject.EnchanceEffectId);
        //            line.Put(QueryItemObject.Name);
        //            line.Put<EItemType>(QueryItemObject.ItemType);
        //            line.Put<EEquipType>(QueryItemObject.EquipType);
        //            line.Put(QueryItemObject.OpFlags);
        //            line.Put(QueryItemObject.OpFlagsPlus);
        //            line.Put<EItemTarget>(QueryItemObject.Target);
        //            line.Put(QueryItemObject.RestrictGender);
        //            line.Put(QueryItemObject.RestrictLevel);
        //            line.Put(QueryItemObject.RestrictMaxLevel);
        //            line.Put(QueryItemObject.RebirthCount);
        //            line.Put(QueryItemObject.RebirthScore);
        //            line.Put(QueryItemObject.RebirthMaxScore);
        //            line.Put(QueryItemObject.RestrictAlign);
        //            line.Put(QueryItemObject.RestrictPrestige);
        //            line.Put(QueryItemObject.RestrictClass);
        //            line.Put<EItemQuality>(QueryItemObject.ItemQuality);
        //            line.Put(QueryItemObject.ItemGroup);
        //            line.Put(QueryItemObject.CastingTime);
        //            line.Put(QueryItemObject.CooldownTime);
        //            line.Put(QueryItemObject.CooldownGroup);
        //            line.Put(QueryItemObject.MaxHp);
        //            line.Put(QueryItemObject.MaxMp);
        //            line.Put(QueryItemObject.Str);
        //            line.Put(QueryItemObject.Con);
        //            line.Put(QueryItemObject.Int);
        //            line.Put(QueryItemObject.Vol);
        //            line.Put(QueryItemObject.Dex);
        //            line.Put(QueryItemObject.AvgPhysicoDamage);
        //            line.Put(QueryItemObject.RandPhysicoDamage);
        //            line.Put(QueryItemObject.AttackRange);
        //            line.Put(QueryItemObject.AttackSpeed);
        //            line.Put(QueryItemObject.Attack);
        //            line.Put(QueryItemObject.RangeAttack);
        //            line.Put(QueryItemObject.PhysicoDefence);
        //            line.Put(QueryItemObject.MagicDamage);
        //            line.Put(QueryItemObject.MagicDefence);
        //            line.Put(QueryItemObject.HitRate);
        //            line.Put(QueryItemObject.DodgeRate);
        //            line.Put(QueryItemObject.PhysicoCriticalRate);
        //            line.Put(QueryItemObject.PhysicoCriticalDamage);
        //            line.Put(QueryItemObject.MagicCriticalRate);
        //            line.Put(QueryItemObject.MagicCriticalDamage);
        //            line.Put(QueryItemObject.PhysicalPenetration);
        //            line.Put(QueryItemObject.MagicalPenetration);
        //            line.Put(QueryItemObject.PhysicalPenetrationDefence);
        //            line.Put(QueryItemObject.MagicalPenetrationDefence);
        //            line.Put<EAttribute>(QueryItemObject.Attribute);
        //            line.Put(QueryItemObject.AttributeRate);
        //            line.Put(QueryItemObject.AttributeDamage);
        //            line.Put(QueryItemObject.AttributeResist);
        //            line.Put<EMonsterType>(QueryItemObject.SpecialType);
        //            line.Put(QueryItemObject.SpecialRate);
        //            line.Put(QueryItemObject.SpecialDamage);
        //            line.Put(QueryItemObject.DropRate);
        //            line.Put(QueryItemObject.DropIndex);

        //            for (int i = 0; i < QueryItemObject.TreasureBuffs.Count(); i++)
        //            {
        //                line.Put(QueryItemObject.TreasureBuffs.Get(i));
        //            }

        //            line.Put<EBuffIconType>(QueryItemObject.EnchantType);
        //            line.Put(QueryItemObject.EnchantId);
        //            line.Put(QueryItemObject.ExpertLevel);
        //            line.Put(QueryItemObject.ExpertEnchantId);
        //            line.Put(QueryItemObject.ElfSkillId);
        //            line.Put<ETimeType>(QueryItemObject.EnchantTimeType);
        //            line.Put(QueryItemObject.EnchantDuration);
        //            line.Put(QueryItemObject.LimitType);
        //            line.Put(QueryItemObject.DueDateTime);
        //            line.Put(QueryItemObject.BackPackSize);
        //            line.Put(QueryItemObject.MaxSockets);
        //            line.Put(QueryItemObject.SocketRate);
        //            line.Put(QueryItemObject.MaxDurability);
        //            line.Put(QueryItemObject.MaxStack);
        //            line.Put(QueryItemObject.ShopPriceType);
        //            line.Put(QueryItemObject.SysPrice);
        //            line.Put(QueryItemObject.RestrictEventPosId);
        //            line.Put(QueryItemObject.TargetIDs);
        //            line.Put(QueryItemObject.BlockRate);
        //            line.Put(QueryItemObject.LogLevel);
        //            line.Put<EAuctionType>(QueryItemObject.AuctionType);

        //            for (int i = 0; i < QueryItemObject.ExtraData.Length; i++)
        //            {
        //                line.Put(QueryItemObject.ExtraData[i]);
        //            }

        //            line.Put(QueryItemObject.Tip);

        //            return line.GetString();
        //        });
        //    }
        //    public async override Task<bool> Init()
        //    {
        //        FileName = "Item";
        //        await base.Load();

        //        isItemMall = true;

        //        FileName = "ItemMall";
        //        await base.Load();

        //        await LoadTranslations("");
        //        return true;
        //    }
        //    protected async override Task<bool> SaveToFile(string path, IniFileType type = IniFileType.Client)
        //    {
        //        var Config = GFConfiguration.Instance.Data;
        //        SortedDictionary<uint, ItemData> dItem = new SortedDictionary<uint, ItemData> ();
        //        SortedDictionary<uint, ItemData> dItemMall = new SortedDictionary<uint, ItemData>();

        //        List<string> fItem = new List<string> {
        //            $"|{_File.Version}|{_File.Columns}|"
        //        };
        //        List<string> fItemMall = new List<string> {
        //            $"|{_File.Version}|{_File.Columns}|"
        //        };

        //        foreach (var item in QueryItems)
        //        {
        //            if (item.Value.ItemMall)
        //                dItemMall.Add(item.Key, item.Value);
        //            else
        //                dItem.Add(item.Key, item.Value);                
        //        }

        //        foreach (var item in dItem)
        //        {
        //            fItem.Add(await Serialize(item.Value));
        //        }

        //        foreach(var item in dItemMall)
        //        {
        //            fItemMall.Add(await Serialize(item.Value));
        //        }            

        //        Encoding big5 = Encoding.GetEncoding("Big5");

        //        var _Prefix = type switch
        //        {
        //            IniFileType.Client => "C_",
        //            IniFileType.Server => "S_",
        //            _ => "C_"
        //        };

        //        var CompletePath = _Prefix + "Item.ini";

        //        await File.WriteAllLinesAsync(Path.Combine( path, CompletePath), fItem, big5);

        //        CompletePath = _Prefix + "ItemMall.ini";
        //        await File.WriteAllLinesAsync(Path.Combine(path, CompletePath), fItemMall, big5);            

        //        return true;
        //    }              
        //}

    }
}
