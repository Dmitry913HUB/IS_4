using System.Collections.Generic;

namespace IS_4
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public Player() { Teams = new List<Team>(); }
    }
}
