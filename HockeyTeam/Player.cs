using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeam
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hand { get; set; }
        public int JerseyNumber { get; set; }

        public Player()
        {

        }
        public Player(string firstname, string lastname, string hand, int jerseynumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Hand = hand;
            JerseyNumber = jerseynumber;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Hand + " " + JerseyNumber;
        }
    }
}