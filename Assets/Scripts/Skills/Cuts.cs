using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cuts : Skills, Foe
{



    public override void Init(Unit unit)
    {
        this.unit = unit;
        _name = "Глубокие порезы";
        cooldown = 4;
        cooldownTimer = 0;
        duration = 3;
        mf = 0.9;

    }

    // Update is called once per frame
    public int Effect()
    {

        return 0;
    }

    public override int Attack()
    {
        int minDMG = unit.minDMG;
        int maxDMG = unit.maxDMG;
        float criticalChance = unit.criticalChance;
        int criticalDMG = unit.criticalDMG;
        int totalDmg = 0;

        int chance = Random.Range(0, 100);
        if (chance > (100 - criticalChance))
        {
            totalDmg = criticalDMG;
            print("КРИТ МAXDMG " + maxDMG + " mf " + unit.criticalMF + " crDmg " + criticalDMG);
        }
        else
        {
            totalDmg = Random.Range(minDMG, maxDMG);
        }
        StartCoolDown();
        return totalDmg;
    }
 
}

