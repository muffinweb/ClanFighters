using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClanFighters.Interface
{
    public interface IFighter
    {
        string Name { get; set; }

        int Health { get; set; }

        int HitDamage { get; set; }

        void HitEnemy(IFighter fighter);
    }
}
