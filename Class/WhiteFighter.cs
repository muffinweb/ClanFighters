using ClanFighters.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClanFighters.Class
{
    public class WhiteFighter : IFighter
    {
        public WhiteFighter(string Name, int Health, int HitDamage)
        {
            this.Name = Name;
            this.Health = Health;
            this.HitDamage = HitDamage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int HitDamage { get; set; }

        public void HitEnemy(IFighter fighter)
        {
            fighter.Health = fighter.Health - this.HitDamage;
        }
    }
}
