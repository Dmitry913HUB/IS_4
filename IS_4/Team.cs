using System.Collections.Generic;

namespace IS_4
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public Team() { Players = new List<Player>(); }
    }
}
