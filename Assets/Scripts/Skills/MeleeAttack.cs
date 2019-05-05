﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : Skills,Foe
{
    // private Unit unit;

    public override void Init(Unit unit)
    {
        this.unit = unit;
        _name = "Ближний бой";
        mf = 1;
        cooldown = 0;
        duration = 0;
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
            totalDmg =(int) (maxDMG * unit.criticalMF);
            
            
        }
        else
        {
            totalDmg = Random.Range(minDMG, maxDMG);
        }

        return totalDmg;
    }
    public override int[] Effect()
    {
        throw new System.NotImplementedException();
    }

}