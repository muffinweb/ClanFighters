using ClanFighters.Class;
using ClanFighters.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClanFighters;

class ClanFighters
{
    public static void Main(string[] args)
    {
        // First create BlackFighter Character
        BlackFighter blackFighter = new BlackFighter("Blackie", 100, 10);

        // Second create WhiteFighther Character
        WhiteFighter whiteFighter = new WhiteFighter("Whitie", 100, 10);


        // Check Fighters First
        CheckFighters(blackFighter);
        CheckFighters(whiteFighter);

        // Now Let's Street Fighter
        blackFighter.HitEnemy(whiteFighter);

        // Checking fighters again
        CheckFighters(blackFighter);
        CheckFighters(whiteFighter);

    }

    public static void CheckFighters(IFighter fighter)
    {
        Console.WriteLine(fighter.Name + " - " + fighter.Health.ToString() + " - " + fighter.HitDamage);
    }
}