using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GFDataApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IconFilename = table.Column<string>(type: "text", nullable: true),
                    ModelId = table.Column<string>(type: "text", nullable: true),
                    ModelFilename = table.Column<string>(type: "text", nullable: true),
                    WeaponEffectId = table.Column<string>(type: "text", nullable: true),
                    FlyEffectId = table.Column<string>(type: "text", nullable: true),
                    UsedEffectId = table.Column<string>(type: "text", nullable: true),
                    UsedSoundName = table.Column<string>(type: "text", nullable: true),
                    EnchanceEffectId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EquipType = table.Column<int>(type: "integer", nullable: false),
                    ItemType = table.Column<int>(type: "integer", nullable: false),
                    OpFlags = table.Column<long>(type: "bigint", nullable: false),
                    OpFlagsPlus = table.Column<long>(type: "bigint", nullable: false),
                    Target = table.Column<int>(type: "integer", nullable: false),
                    RestrictGender = table.Column<long>(type: "bigint", nullable: false),
                    RestrictLevel = table.Column<long>(type: "bigint", nullable: false),
                    RestrictMaxLevel = table.Column<long>(type: "bigint", nullable: false),
                    RebirthCount = table.Column<short>(type: "smallint", nullable: false),
                    RebirthScore = table.Column<short>(type: "smallint", nullable: false),
                    RebirthMaxScore = table.Column<short>(type: "smallint", nullable: false),
                    RestrictAlign = table.Column<long>(type: "bigint", nullable: false),
                    RestrictPrestige = table.Column<long>(type: "bigint", nullable: false),
                    RestrictClass = table.Column<long>(type: "bigint", nullable: false),
                    ItemQuality = table.Column<int>(type: "integer", nullable: false),
                    ItemGroup = table.Column<int>(type: "integer", nullable: false),
                    CastingTime = table.Column<int>(type: "integer", nullable: false),
                    CooldownTime = table.Column<int>(type: "integer", nullable: false),
                    CooldownGroup = table.Column<int>(type: "integer", nullable: false),
                    MaxHp = table.Column<double>(type: "double precision", nullable: false),
                    MaxMp = table.Column<double>(type: "double precision", nullable: false),
                    Str = table.Column<short>(type: "smallint", nullable: false),
                    Con = table.Column<short>(type: "smallint", nullable: false),
                    Int = table.Column<short>(type: "smallint", nullable: false),
                    Vol = table.Column<short>(type: "smallint", nullable: false),
                    Dex = table.Column<short>(type: "smallint", nullable: false),
                    AvgPhysicoDamage = table.Column<double>(type: "double precision", nullable: false),
                    RandPhysicoDamage = table.Column<double>(type: "double precision", nullable: false),
                    AttackRange = table.Column<int>(type: "integer", nullable: false),
                    AttackSpeed = table.Column<int>(type: "integer", nullable: false),
                    Attack = table.Column<double>(type: "double precision", nullable: false),
                    RangeAttack = table.Column<double>(type: "double precision", nullable: false),
                    PhysicoDefence = table.Column<double>(type: "double precision", nullable: false),
                    MagicDamage = table.Column<double>(type: "double precision", nullable: false),
                    MagicDefence = table.Column<double>(type: "double precision", nullable: false),
                    HitRate = table.Column<short>(type: "smallint", nullable: false),
                    DodgeRate = table.Column<short>(type: "smallint", nullable: false),
                    PhysicoCriticalRate = table.Column<short>(type: "smallint", nullable: false),
                    PhysicoCriticalDamage = table.Column<long>(type: "bigint", nullable: false),
                    MagicCriticalRate = table.Column<short>(type: "smallint", nullable: false),
                    MagicCriticalDamage = table.Column<long>(type: "bigint", nullable: false),
                    PhysicalPenetration = table.Column<short>(type: "smallint", nullable: false),
                    MagicalPenetration = table.Column<short>(type: "smallint", nullable: false),
                    PhysicalPenetrationDefence = table.Column<short>(type: "smallint", nullable: false),
                    MagicalPenetrationDefence = table.Column<short>(type: "smallint", nullable: false),
                    Attribute = table.Column<int>(type: "integer", nullable: false),
                    AttributeRate = table.Column<short>(type: "smallint", nullable: false),
                    AttributeDamage = table.Column<long>(type: "bigint", nullable: false),
                    AttributeResist = table.Column<long>(type: "bigint", nullable: false),
                    SpecialType = table.Column<int>(type: "integer", nullable: false),
                    SpecialRate = table.Column<short>(type: "smallint", nullable: false),
                    SpecialDamage = table.Column<long>(type: "bigint", nullable: false),
                    DropRate = table.Column<short>(type: "smallint", nullable: false),
                    DropIndex = table.Column<long>(type: "bigint", nullable: false),
                    TreasureBuffs = table.Column<int[]>(type: "integer[]", nullable: false),
                    EnchantType = table.Column<int>(type: "integer", nullable: false),
                    EnchantId = table.Column<int>(type: "integer", nullable: false),
                    ExpertLevel = table.Column<short>(type: "smallint", nullable: false),
                    ExpertEnchantId = table.Column<int>(type: "integer", nullable: false),
                    ElfSkillId = table.Column<int>(type: "integer", nullable: false),
                    EnchantTimeType = table.Column<int>(type: "integer", nullable: false),
                    EnchantDuration = table.Column<int>(type: "integer", nullable: false),
                    LimitType = table.Column<long>(type: "bigint", nullable: false),
                    DueDateTime = table.Column<long>(type: "bigint", nullable: false),
                    BackPackSize = table.Column<byte>(type: "smallint", nullable: false),
                    MaxSockets = table.Column<byte>(type: "smallint", nullable: false),
                    SocketRate = table.Column<double>(type: "double precision", nullable: false),
                    MaxDurability = table.Column<double>(type: "double precision", nullable: false),
                    MaxStack = table.Column<int>(type: "integer", nullable: false),
                    ShopPriceType = table.Column<long>(type: "bigint", nullable: false),
                    SysPrice = table.Column<double>(type: "double precision", nullable: false),
                    RestrictEventPosId = table.Column<string>(type: "text", nullable: true),
                    TargetIDs = table.Column<string>(type: "text", nullable: true),
                    MissionPosId = table.Column<long>(type: "bigint", nullable: false),
                    BlockRate = table.Column<string>(type: "text", nullable: true),
                    LogLevel = table.Column<byte>(type: "smallint", nullable: false),
                    AuctionType = table.Column<int>(type: "integer", nullable: false),
                    ExtraData = table.Column<int[]>(type: "integer[]", nullable: false),
                    Tip = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
