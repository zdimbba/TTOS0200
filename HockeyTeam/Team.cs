using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeam
{
    class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> players;
        public Team(string name, string city)
        {
            Name = name;
            City = city;
            players = new List<Player>();
        }
        public override string ToString()
        {
            return Name + " " + City;
        }
    }
}