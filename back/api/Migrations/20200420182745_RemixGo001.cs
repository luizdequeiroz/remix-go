using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class RemixGo001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PenaltyValue = table.Column<int>(nullable: false),
                    PenaltyDescrition = table.Column<string>(nullable: true),
                    BonusValue = table.Column<int>(nullable: false),
                    BonusDescription = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capabilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TestValue = table.Column<int>(nullable: false),
                    TestValueEfficiencyLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disadvantages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TestValue = table.Column<int>(nullable: false),
                    TestValueEfficiencyLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disadvantages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnhancedMoves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TestValue = table.Column<int>(nullable: false),
                    TestValueEfficiencyLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnhancedMoves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenericAdvantage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TestValue = table.Column<int>(nullable: false),
                    TestValueEfficiencyLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericAdvantage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DifficultyValue = table.Column<int>(nullable: false),
                    DifficultyDescription = table.Column<string>(nullable: true),
                    EffectValue = table.Column<int>(nullable: false),
                    EffectDescription = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Practices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAndRiches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAndRiches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TestValue = table.Column<int>(nullable: false),
                    TestValueEfficiencyLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    PlayerId = table.Column<int>(nullable: false),
                    CharacterName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Archetype = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LevelLabel = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    ExperienceLabel = table.Column<string>(nullable: true),
                    PhysicalTestDiceQuantity = table.Column<int>(nullable: false),
                    PhysicalTestDiceFaceQuantity = table.Column<int>(nullable: false),
                    MentalTestDiceQuantity = table.Column<int>(nullable: false),
                    MentalTestDiceFaceQuantity = table.Column<int>(nullable: false),
                    GenericTestDiceLabel = table.Column<string>(nullable: true),
                    GenericTestDiceQuantity = table.Column<int>(nullable: false),
                    GenericTestDiceFaceQuantity = table.Column<int>(nullable: false),
                    GenericAdvantagesLabel = table.Column<string>(nullable: true),
                    WeightCapacity = table.Column<int>(nullable: false),
                    HealthPoints = table.Column<int>(nullable: false),
                    Annotations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSs_Users_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RMXs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    PlayerId = table.Column<int>(nullable: false),
                    CharacterName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Adrenaline = table.Column<int>(nullable: false),
                    AdrenalineEfficiencyLimit = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    AttackEfficiencyLimit = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    DefenseEfficiencyLimit = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    DexterityEfficiencyLimit = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    StrengthEfficiencyLimit = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    IntelligenceEfficiencyLimit = table.Column<int>(nullable: false),
                    Resistance = table.Column<int>(nullable: false),
                    ResistanceEfficiencyLimit = table.Column<int>(nullable: false),
                    Sapience = table.Column<int>(nullable: false),
                    SapienceEfficiencyLimit = table.Column<int>(nullable: false),
                    Velocity = table.Column<int>(nullable: false),
                    VelocityEfficiencyLimit = table.Column<int>(nullable: false),
                    Annotations = table.Column<string>(nullable: true),
                    ExperiencePoints = table.Column<int>(nullable: false),
                    ExperienceLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMXs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMXs_Users_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tables_Users_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SheetArmors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    ArmorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetArmors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetArmors_Armors_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetArmors_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetArmors_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetCapabilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    CapabilitieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetCapabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetCapabilities_Capabilities_CapabilitieId",
                        column: x => x.CapabilitieId,
                        principalTable: "Capabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetCapabilities_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetCapabilities_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetDisadvantages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    DisadvantageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetDisadvantages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetDisadvantages_Disadvantages_DisadvantageId",
                        column: x => x.DisadvantageId,
                        principalTable: "Disadvantages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetDisadvantages_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetDisadvantages_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetEnhancedMoves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    EnhancedMoveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetEnhancedMoves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetEnhancedMoves_EnhancedMoves_EnhancedMoveId",
                        column: x => x.EnhancedMoveId,
                        principalTable: "EnhancedMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetEnhancedMoves_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetEnhancedMoves_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetGenericAdvantage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    GenericAdvantageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetGenericAdvantage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetGenericAdvantage_GenericAdvantage_GenericAdvantageId",
                        column: x => x.GenericAdvantageId,
                        principalTable: "GenericAdvantage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetGenericAdvantage_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetGenericAdvantage_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetItems_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetItems_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetPractices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    PracticeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetPractices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetPractices_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetPractices_Practices_PracticeId",
                        column: x => x.PracticeId,
                        principalTable: "Practices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetPractices_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetPropertyAndRiches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    PropertyAndRicheId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetPropertyAndRiches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetPropertyAndRiches_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetPropertyAndRiches_PropertyAndRiches_PropertyAndRicheId",
                        column: x => x.PropertyAndRicheId,
                        principalTable: "PropertyAndRiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetPropertyAndRiches_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetSkills_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetSkills_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SheetWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RMXId = table.Column<int>(nullable: true),
                    MSId = table.Column<int>(nullable: true),
                    WeaponId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetWeapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetWeapons_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetWeapons_RMXs_RMXId",
                        column: x => x.RMXId,
                        principalTable: "RMXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetWeapons_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    TableId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerTables_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTables_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Fullname", "Password", "RegisterDate", "UpdateDate", "Username" },
                values: new object[] { 1, "oluizdequeiroz@gmail.com", "Luiz de Queiroz", "8BC00E795870011174F8138ED09DF91B2822F5A6D19DC48B5C06E63598BCFD1D997C3A95736EE965C36A42F5D0F8A7E0A4CA29F9CBD1A4E4559940E64658CE0A", new DateTime(2020, 4, 20, 15, 27, 44, 888, DateTimeKind.Local).AddTicks(4215), null, "luizdequeiroz" });

            migrationBuilder.CreateIndex(
                name: "IX_MSs_PlayerId",
                table: "MSs",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTables_TableId",
                table: "PlayerTables",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTables_UserId",
                table: "PlayerTables",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RMXs_PlayerId",
                table: "RMXs",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetArmors_ArmorId",
                table: "SheetArmors",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetArmors_MSId",
                table: "SheetArmors",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetArmors_RMXId",
                table: "SheetArmors",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetCapabilities_CapabilitieId",
                table: "SheetCapabilities",
                column: "CapabilitieId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetCapabilities_MSId",
                table: "SheetCapabilities",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetCapabilities_RMXId",
                table: "SheetCapabilities",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetDisadvantages_DisadvantageId",
                table: "SheetDisadvantages",
                column: "DisadvantageId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetDisadvantages_MSId",
                table: "SheetDisadvantages",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetDisadvantages_RMXId",
                table: "SheetDisadvantages",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetEnhancedMoves_EnhancedMoveId",
                table: "SheetEnhancedMoves",
                column: "EnhancedMoveId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetEnhancedMoves_MSId",
                table: "SheetEnhancedMoves",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetEnhancedMoves_RMXId",
                table: "SheetEnhancedMoves",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetGenericAdvantage_GenericAdvantageId",
                table: "SheetGenericAdvantage",
                column: "GenericAdvantageId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetGenericAdvantage_MSId",
                table: "SheetGenericAdvantage",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetGenericAdvantage_RMXId",
                table: "SheetGenericAdvantage",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetItems_ItemId",
                table: "SheetItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetItems_MSId",
                table: "SheetItems",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetItems_RMXId",
                table: "SheetItems",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetPractices_MSId",
                table: "SheetPractices",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetPractices_PracticeId",
                table: "SheetPractices",
                column: "PracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetPractices_RMXId",
                table: "SheetPractices",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetPropertyAndRiches_MSId",
                table: "SheetPropertyAndRiches",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetPropertyAndRiches_PropertyAndRicheId",
                table: "SheetPropertyAndRiches",
                column: "PropertyAndRicheId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetPropertyAndRiches_RMXId",
                table: "SheetPropertyAndRiches",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetSkills_MSId",
                table: "SheetSkills",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetSkills_RMXId",
                table: "SheetSkills",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetSkills_SkillId",
                table: "SheetSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetWeapons_MSId",
                table: "SheetWeapons",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetWeapons_RMXId",
                table: "SheetWeapons",
                column: "RMXId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetWeapons_WeaponId",
                table: "SheetWeapons",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_MasterId",
                table: "Tables",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerTables");

            migrationBuilder.DropTable(
                name: "SheetArmors");

            migrationBuilder.DropTable(
                name: "SheetCapabilities");

            migrationBuilder.DropTable(
                name: "SheetDisadvantages");

            migrationBuilder.DropTable(
                name: "SheetEnhancedMoves");

            migrationBuilder.DropTable(
                name: "SheetGenericAdvantage");

            migrationBuilder.DropTable(
                name: "SheetItems");

            migrationBuilder.DropTable(
                name: "SheetPractices");

            migrationBuilder.DropTable(
                name: "SheetPropertyAndRiches");

            migrationBuilder.DropTable(
                name: "SheetSkills");

            migrationBuilder.DropTable(
                name: "SheetWeapons");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Capabilities");

            migrationBuilder.DropTable(
                name: "Disadvantages");

            migrationBuilder.DropTable(
                name: "EnhancedMoves");

            migrationBuilder.DropTable(
                name: "GenericAdvantage");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Practices");

            migrationBuilder.DropTable(
                name: "PropertyAndRiches");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "MSs");

            migrationBuilder.DropTable(
                name: "RMXs");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
