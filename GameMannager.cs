using GFDataApi.DataContext.Implementations.PGSQL;
using GFDataApi.DataContext.Interfaces;
using GFDataApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GFDataApi
{
    public class GameMannager
    {
        //public IBaseQuery<uint, ItemData> ItemQuery { get; private set; }
        //public IBaseQuery<int, SpellData> SpellQuery { get; private set; }
        //public IBaseQuery<int, EnchantData> EnchantQuery {  get; private set; }
        //public IBaseQuery<uint, EquipSetData> EquipSetQuery { get; private set; }

        public ItemService ItemService { get; set; }

        public GameMannager()
        {
            Initialize();
            //Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //ItemQuery = new BaseQuery<uint, ItemData>(new ItemDbPg());            
            //SpellQuery = new CSpellQuery();
            //EnchantQuery = new CEnchantQuery();
            //EquipSetQuery = new CEquipSetQuery();

            /*             
             S_Achievement.ini
             S_Activity.ini
             S_Ai.ini                        
             S_Battlefield.ini
             S_BeastsTower.ini            
             S_Bingo.ini
             S_Classes.ini
             S_Class<class>.ini
             S_Collection.ini
             S_DailyAwards.ini
             S_Dialogue.ini
             S_DropItem.ini
             S_DynamicEvent.ini
             S_Elf.ini
             S_ElfAI.ini
             S_ElfCollect.ini
             S_ElfCombine.ini
             S_ElfKing.ini
             S_ElfLottery.ini
             S_ElfRacing.ini
             S_ElfRacingPerform.ini
             S_ElfRacingPerformEvent.ini
             S_ElfRacingReward.ini
             S_ElfSkill.ini
             S_ElftabletAbility.ini
             S_ElftabletCombo.ini
             S_ElfTeamFight.ini
             S_ElfTemple.ini
             S_ElfTempleChallenge.ini
             S_ElfTrain.ini                          
             S_EquipType.ini
             S_Equip_Train.ini
             S_Equip_Train_Type.ini
             S_Exam.ini
             S_FamilyTree.ini
             S_Festival.ini
             S_FightDisplay.ini
             S_FightKing.ini
             S_GMToolCmds.ini
             S_GodAreaAwake.ini
             S_GodAreaCombine.ini
             S_GrowCrop.ini
             S_GrowEquip.ini             
             S_ItemCombo.ini
             S_ItemExchange.ini             
             S_Level.ini
             S_LuckyBar.ini
             S_Mask.ini
             S_Mentorship.ini
             S_MentorshipInstance.ini
             S_MentorshipReward.ini
             S_Mission.ini
             S_Monster.ini
             S_MonsterStep.ini             
             S_Node.ini
             S_Npc.ini             
             S_Parameter.ini
             S_PointAbility.ini
             S_PVP.ini
             S_Race.ini
             S_RaceGroup.ini
             S_Races.ini
             S_RainbowEvent.ini
             S_RainbowRoad.ini             
             S_RankAward.ini
             S_RecommendEvents.ini
             S_RideCombo.ini
             S_RideStep.ini             
             S_Schedule.ini
             S_SNS.ini                          
             S_StarAvenue.ini
             S_StarReward.ini
             S_StateDependence.ini
             S_Store.ini
             S_SysSetup.ini            
             S_Territory.ini
             S_TextIndex.ini
             S_TextLimit.ini            
             S_Title.ini
             S_Transport.ini
             S_VIP.ini*/
        }        

        private void Initialize()
        {
            //await ItemQuery.PreInit();

            ServiceCollection services = new ServiceCollection();
            ProviderRegisters.RegisterPgSql(services);            
            ProviderRegisters.RegisterServices(services);            
            var provider = services.BuildServiceProvider();            

            ItemService = provider.GetRequiredService<ItemService>();            
        }
    }
}