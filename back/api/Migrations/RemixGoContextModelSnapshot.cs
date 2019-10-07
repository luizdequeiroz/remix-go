﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using domain;

namespace api.Migrations
{
    [DbContext(typeof(RemixGoContext))]
    partial class RemixGoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("domain.Entities.Armor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Armor");
                });

            modelBuilder.Entity("domain.Entities.Capabilitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Capabilitie");
                });

            modelBuilder.Entity("domain.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Adrenaline");

                    b.Property<int>("AdrenalineEfficiencyLimit");

                    b.Property<int>("Age");

                    b.Property<string>("Annotations");

                    b.Property<int>("Attack");

                    b.Property<int>("AttackEfficiencyLimit");

                    b.Property<string>("CharacterName");

                    b.Property<string>("Class");

                    b.Property<int>("Defense");

                    b.Property<int>("DefenseEfficiencyLimit");

                    b.Property<int>("Dexterity");

                    b.Property<int>("DexterityEfficiencyLimit");

                    b.Property<int>("ExperienceLevel");

                    b.Property<int>("ExperiencePoints");

                    b.Property<int>("Level");

                    b.Property<int>("PlayerId");

                    b.Property<string>("Race");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<int>("Resistance");

                    b.Property<int>("ResistanceEfficiencyLimit");

                    b.Property<int>("Sapience");

                    b.Property<int>("SapienceEfficiencyLimit");

                    b.Property<int>("Strength");

                    b.Property<int>("StrengthEfficiencyLimit");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int>("Velocity");

                    b.Property<int>("VelocityEfficiencyLimit");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("domain.Entities.CardArmor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArmorId");

                    b.Property<int>("CardId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("ArmorId");

                    b.HasIndex("CardId");

                    b.ToTable("CardArmor");
                });

            modelBuilder.Entity("domain.Entities.CardCapabilitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CapabilitieId");

                    b.Property<int>("CardId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CapabilitieId");

                    b.HasIndex("CardId");

                    b.ToTable("CardCapabilitie");
                });

            modelBuilder.Entity("domain.Entities.CardDisadvantage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<int>("DisadvantageId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DisadvantageId");

                    b.ToTable("CardDisadvantage");
                });

            modelBuilder.Entity("domain.Entities.CardEnhancedMove", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<int>("EnhancedMoveId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("EnhancedMoveId");

                    b.ToTable("CardEnhancedMove");
                });

            modelBuilder.Entity("domain.Entities.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<int>("ItemId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ItemId");

                    b.ToTable("CardItem");
                });

            modelBuilder.Entity("domain.Entities.CardPractice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<int>("PracticeId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PracticeId");

                    b.ToTable("CardPractice");
                });

            modelBuilder.Entity("domain.Entities.CardPropertyAndRiche", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<int>("PropertyAndRicheId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PropertyAndRicheId");

                    b.ToTable("CardPropertyAndRiche");
                });

            modelBuilder.Entity("domain.Entities.CardSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<int>("SkillId");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("SkillId");

                    b.ToTable("CardSkill");
                });

            modelBuilder.Entity("domain.Entities.CardWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int>("WeaponId");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("WeaponId");

                    b.ToTable("CardWeapon");
                });

            modelBuilder.Entity("domain.Entities.Disadvantage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Disadvantage");
                });

            modelBuilder.Entity("domain.Entities.EnhancedMove", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("EnhancedMove");
                });

            modelBuilder.Entity("domain.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("domain.Entities.PlayerTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<int>("TableId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("TableId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCardTable");
                });

            modelBuilder.Entity("domain.Entities.Practice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Practice");
                });

            modelBuilder.Entity("domain.Entities.PropertyAndRiche", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("PropertyAndRiche");
                });

            modelBuilder.Entity("domain.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("domain.Entities.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("MasterId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("MasterId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("domain.Entities.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Weapon");
                });

            modelBuilder.Entity("domain.Entities.Card", b =>
                {
                    b.HasOne("domain.Entities.User", "Player")
                        .WithMany("Cards")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardArmor", b =>
                {
                    b.HasOne("domain.Entities.Armor", "Armor")
                        .WithMany()
                        .HasForeignKey("ArmorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardArmors")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardCapabilitie", b =>
                {
                    b.HasOne("domain.Entities.Capabilitie", "Capabilitie")
                        .WithMany()
                        .HasForeignKey("CapabilitieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardCapabilities")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardDisadvantage", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardDisadvantages")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Disadvantage", "Disadvantage")
                        .WithMany()
                        .HasForeignKey("DisadvantageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardEnhancedMove", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardEnhancedMoves")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.EnhancedMove", "EnhancedMove")
                        .WithMany()
                        .HasForeignKey("EnhancedMoveId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardItem", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardItems")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardPractice", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardPractices")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Practice", "Practice")
                        .WithMany()
                        .HasForeignKey("PracticeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardPropertyAndRiche", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardPropertiesAndRiches")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.PropertyAndRiche", "PropertyAndRiche")
                        .WithMany()
                        .HasForeignKey("PropertyAndRicheId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardSkill", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardSkills")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.CardWeapon", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany("CardWeapons")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Weapon", "Weapon")
                        .WithMany()
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.PlayerTable", b =>
                {
                    b.HasOne("domain.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.Table", "Table")
                        .WithMany("PlayerTables")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("domain.Entities.User", "Player")
                        .WithMany("PlayerTables")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("domain.Entities.Table", b =>
                {
                    b.HasOne("domain.Entities.User", "Master")
                        .WithMany()
                        .HasForeignKey("MasterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
