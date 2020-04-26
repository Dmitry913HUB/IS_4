using System.Data.Entity;

namespace IS_4
{
    class SoccerContext : DbContext
    {
        public SoccerContext() : base("SoccerDB2") { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
