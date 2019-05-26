using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cuts : Skills, Foe, Poison,Melee
{
    int effectDMG;


    public override void Init(Unit unit)
    {
        
        this.unit = unit;
        _name = "Глубокие порезы";
        trigger = "cuts";
        triggerEffect = "blood";
        cooldown =cooldownTimerBASE + 4;
        cooldownTimer = 0;
        duration = 2;
        mf = 0.9;

    }

    // Update is called once per frame
    public override int[] Effect()
    {
        // result[0] - count, result[1] - stats:
        // 0 - HP
        // 1 - strenght
        // 2 - agility
        // 3 - vitality
        // 4 - dmg (mf)
        int[] result = new int[2];
        result[0] = effectDMG;
        if (result[0] < 1)
        {
            result[0] = 1;
        }
        result[1] = 0;

        return result;
    }

    public override int[] Attack()
    {
     //totalDmg[0] - dmg
     //totalDmg[1] - crit, 0 - false, 1- true

        int minDMG = unit.minDMG;
        int maxDMG = unit.maxDMG;
        float criticalChance = unit.criticalChance;
        int criticalDMG = unit.criticalDMG;
        int[] totalDmg = new int[2];

        int chance = Random.Range(0, 100);
        if (chance > (100 - criticalChance))
        {
            totalDmg[0] = criticalDMG;
            totalDmg[1] = 1;
        }
        else
        {
            totalDmg[0] = Random.Range(minDMG, maxDMG);
            totalDmg[1] = 0;
        }

        totalDmg[0] = (int)(totalDmg[0] * mf);
        StartCoolDown();
        EffectInit(totalDmg);
        return totalDmg;
    }
    private void EffectInit(int[] dmg)
    {
        durationTimer = duration;
        effectDMG = (int)(dmg[0] * 0.3);
    }
    
}

