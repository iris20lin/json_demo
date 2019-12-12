using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_DEMO
{
    public class NPC
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Lv { get; set; }

        public NPC()
        {
        }

        public NPC(string name, int hp, int lv)
        {
            this.Name = name;
            this.Hp = hp;
            this.Lv = lv;
        }
    }
}
