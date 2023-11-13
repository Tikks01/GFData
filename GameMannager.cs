using GFDataApi.BaseClasses;
using GFDataApi.Querys.Classes;
using GFDataApi.Querys.Data;
using GFDataApi.Querys.Records;

namespace GFDataApi
{
    public class GameMannager
    {
        public IBaseQuery<uint, ItemData> ItemQuery { get; private set; }
        public IBaseQuery<int, SpellData> SpellQuery { get; private set; }
        public IBaseQuery<int, EnchantData> EnchantQuery {  get; private set; }
        public IBaseQuery<uint, EquipSetData> EquipSetQuery { get; private set; }

        public GameMannager()
        {
            ItemQuery = new CItemQuery();
            SpellQuery = new CSpellQuery();
            EnchantQuery = new CEnchantQuery();
            EquipSetQuery = new CEquipSetQuery();
        }

        public async Task Init()
        {
            await Task.WhenAll(
                ItemQuery.Init(),
                SpellQuery.Init(),
                EnchantQuery.Init(),
                EquipSetQuery.Init()
            );
        }
    }
}