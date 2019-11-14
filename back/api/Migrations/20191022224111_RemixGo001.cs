using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace api.Migrations
{
    public partial class RemixGo001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capabilitie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capabilitie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disadvantage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disadvantage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnhancedMove",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnhancedMove", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Practice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAndRiche",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAndRiche", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
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
                    Password = table.Column<string>(nullable: false),
                    Fullname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
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
                name: "Cards",
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
                    Resistance = table.Column<int>(nullable: false),
                    ResistanceEfficiencyLimit = table.Column<int>(nullable: false),
                    Sapience = table.Column<int>(nullable: false),
                    SapienceEfficiencyLimit = table.Column<int>(nullable: false),
                    Velocity = table.Column<int>(nullable: false),
                    VelocityEfficiencyLimit = table.Column<int>(nullable: false),
                    Annotations = table.Column<string>(nullable: true),
                    ExperiencePoints = table.Column<int>(nullable: false),
                    ExperienceLevel = table.Column<int>(nullable: false),
                    TableId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Users_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTable",
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
                    table.PrimaryKey("PK_PlayerTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerTable_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTable_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardArmor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    ArmorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardArmor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardArmor_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardArmor_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardCapabilitie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    CapabilitieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCapabilitie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardCapabilitie_Capabilitie_CapabilitieId",
                        column: x => x.CapabilitieId,
                        principalTable: "Capabilitie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardCapabilitie_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardDisadvantage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    DisadvantageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDisadvantage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardDisadvantage_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardDisadvantage_Disadvantage_DisadvantageId",
                        column: x => x.DisadvantageId,
                        principalTable: "Disadvantage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardEnhancedMove",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    EnhancedMoveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardEnhancedMove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardEnhancedMove_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardEnhancedMove_EnhancedMove_EnhancedMoveId",
                        column: x => x.EnhancedMoveId,
                        principalTable: "EnhancedMove",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardItem_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardPractice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    PracticeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPractice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardPractice_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardPractice_Practice_PracticeId",
                        column: x => x.PracticeId,
                        principalTable: "Practice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardPropertyAndRiche",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    PropertyAndRicheId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPropertyAndRiche", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardPropertyAndRiche_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardPropertyAndRiche_PropertyAndRiche_PropertyAndRicheId",
                        column: x => x.PropertyAndRicheId,
                        principalTable: "PropertyAndRiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardSkill_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardWeapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardWeapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardWeapon_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardWeapon_Weapon_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardArmor_ArmorId",
                table: "CardArmor",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_CardArmor_CardId",
                table: "CardArmor",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardCapabilitie_CapabilitieId",
                table: "CardCapabilitie",
                column: "CapabilitieId");

            migrationBuilder.CreateIndex(
                name: "IX_CardCapabilitie_CardId",
                table: "CardCapabilitie",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardDisadvantage_CardId",
                table: "CardDisadvantage",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardDisadvantage_DisadvantageId",
                table: "CardDisadvantage",
                column: "DisadvantageId");

            migrationBuilder.CreateIndex(
                name: "IX_CardEnhancedMove_CardId",
                table: "CardEnhancedMove",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardEnhancedMove_EnhancedMoveId",
                table: "CardEnhancedMove",
                column: "EnhancedMoveId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItem_CardId",
                table: "CardItem",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItem_ItemId",
                table: "CardItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CardPractice_CardId",
                table: "CardPractice",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardPractice_PracticeId",
                table: "CardPractice",
                column: "PracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_CardPropertyAndRiche_CardId",
                table: "CardPropertyAndRiche",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardPropertyAndRiche_PropertyAndRicheId",
                table: "CardPropertyAndRiche",
                column: "PropertyAndRicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_TableId",
                table: "Cards",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSkill_CardId",
                table: "CardSkill",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSkill_SkillId",
                table: "CardSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CardWeapon_CardId",
                table: "CardWeapon",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardWeapon_WeaponId",
                table: "CardWeapon",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTable_TableId",
                table: "PlayerTable",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTable_UserId",
                table: "PlayerTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_MasterId",
                table: "Tables",
                column: "MasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardArmor");

            migrationBuilder.DropTable(
                name: "CardCapabilitie");

            migrationBuilder.DropTable(
                name: "CardDisadvantage");

            migrationBuilder.DropTable(
                name: "CardEnhancedMove");

            migrationBuilder.DropTable(
                name: "CardItem");

            migrationBuilder.DropTable(
                name: "CardPractice");

            migrationBuilder.DropTable(
                name: "CardPropertyAndRiche");

            migrationBuilder.DropTable(
                name: "CardSkill");

            migrationBuilder.DropTable(
                name: "CardWeapon");

            migrationBuilder.DropTable(
                name: "PlayerTable");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Capabilitie");

            migrationBuilder.DropTable(
                name: "Disadvantage");

            migrationBuilder.DropTable(
                name: "EnhancedMove");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Practice");

            migrationBuilder.DropTable(
                name: "PropertyAndRiche");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
