using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player
    {
        public string Name { get; set; }
        private Map MyMap { get; set; }
        private Map BattleMap { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
