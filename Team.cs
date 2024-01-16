using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes_JuanHernandez
{
    internal class Team
    {
        // Fields
        string _sport;
        string _teamname;
        string _city;
        int _datefounded;

        // Properties
        public string Sport { get => _sport; set => _sport = value; }
        public string Teamname { get => _teamname; set => _teamname = value; }
        public string City { get => _city; set => _city = value; }
        public int Datefounded { get => _datefounded; set => _datefounded = value; }
    }
}
