using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Chupocabra
    {
        public string name;
        public int xp;
        public int dmg;
        public int mp;
        public int armor;
        public Chupocabra(string name, int xp, int dmg, int mp, int armor)
        {
            this.name = name;
            this.xp = xp;
            this.dmg = dmg;
            this.mp = mp;
            this.armor = armor;
        }
        public void attack()
        {

        }
    }
}
