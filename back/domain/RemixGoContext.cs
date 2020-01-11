using domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace domain
{
    public class RemixGoContext : DbContext
    {
        public RemixGoContext(DbContextOptions<RemixGoContext> options) : base(options) { }

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
