using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : Skills,Foe
{
    // private Unit unit;

    public override void Init(Unit unit)
    {
        this.unit = unit;
        _name = "Ближний бой";
        trigger = "melee";
        triggerEffect = "";
        mf = 1;
        cooldown = 0;
        duration = 0;
    }

    public override int[] Attack() 
    {
        //result[0] - dmg
        //result[1] - crit, 1 - true, 0 - false, -1 - effect

        int minDMG = unit.minDMG;
        int maxDMG = unit.maxDMG;
        float criticalChance = unit.criticalChance;
        int criticalDMG = unit.criticalDMG;
        int[] totalDmg = new int[2];

        int chance = Random.Range(0, 100);
        if (chance > (100 - criticalChance))
        {
            totalDmg[0] =(int) (maxDMG * unit.criticalMF);
            totalDmg[1] = 1;
            
        }
        else
        {
            totalDmg[0] = Random.Range(minDMG, maxDMG);
            totalDmg[1] = 0;
        }

        return totalDmg;
    }
    public override int[] Effect(Transform transform)
    {
        return null;
    }

}
