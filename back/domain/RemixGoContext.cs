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
                Password = "8BC00E795870011174F8138ED09DF91B2822F5A6D19DC48B5C06E63598BCFD1D997C3A95736EE965C36A42F5D0F8A7E0A4CA29F9CBD1A4E4559940E64658CE0A",
                RegisterDate = DateTime.Now,
                Fullname = "Luiz de Queiroz",
                Email = "oluizdequeiroz@gmail.com"
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<RMX> RMXs { get; set; }
        public DbSet<MS> MSs { get; set; }

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

        public DbSet<SheetArmor> SheetArmors { get; set; }
        public DbSet<SheetCapabilitie> SheetCapabilities { get; set; }
        public DbSet<SheetDisadvantage> SheetDisadvantages { get; set; }
        public DbSet<SheetEnhancedMove> SheetEnhancedMoves { get; set; }
        public DbSet<SheetItem> SheetItems { get; set; }
        public DbSet<SheetPractice> SheetPractices { get; set; }
        public DbSet<SheetPropertyAndRiche> SheetPropertyAndRiches { get; set; }
        public DbSet<SheetSkill> SheetSkills { get; set; }
        public DbSet<SheetWeapon> SheetWeapons { get; set; }
    }
}
