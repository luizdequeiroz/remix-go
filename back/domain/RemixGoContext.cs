using domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace domain
{
    public class RemixGoContext : DbContext
    {
        public RemixGoContext(DbContextOptions<RemixGoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "luizdequeiroz",
                Password = "C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC",
                RegisterDate = DateTime.Now,
                Fullname = "Luiz de Queiroz",
                Email = "oluizdequeiroz@gmail.com"
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Card> Cards { get; set; }

        public DbSet<PlayerTable> PlayerTables { get; set; }

        public DbSet<Armor> Armors { get; set; }
        public DbSet<Capabilitie> Capabilities { get; set; }
        public DbSet<Disadvantage> Disadvantages { get; set; }
        public DbSet<EnhancedMove> EnhancedMoves { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Practice> Practices { get; set; }
        public DbSet<PropertyAndRiche> PropertyAndRiches { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<CardArmor> CardArmors { get; set; }
        public DbSet<CardCapabilitie> CardCapabilities { get; set; }
        public DbSet<CardDisadvantage> CardDisadvantages { get; set; }
        public DbSet<CardEnhancedMove> CardEnhancedMoves { get; set; }
        public DbSet<CardItem> CardItems { get; set; }
        public DbSet<CardPractice> CardPractices { get; set; }
        public DbSet<CardPropertyAndRiche> CardPropertyAndRiches { get; set; }
        public DbSet<CardSkill> CardSkills { get; set; }
        public DbSet<CardWeapon> CardWeapons { get; set; }
    }
}
