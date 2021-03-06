﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : Skills, Mate, Debuff
{
    
    public override void Init(Unit unit)
    {
        this.unit = unit;
        
        _name = "Прицеливание";
        trigger = "aim";
        triggerEffect = "scope";
        cooldown = cooldownTimerBASE + 5;
        cooldownTimer = 0;
        duration = 1;
        mf = 1;

    }

    public override int[] Effect() {
        // result[0] - count, result[1] - stats:
        // 0 - HP
        // 1 - strenght
        // 2 - agility
        // 3 - vitality
        // 4 - dmg (mf)
        int[] result = new int[2];
        result[0] = 3;
        result[1] = 4;
        return result;
    }

    public override int[] Attack()
    {
        //result[0] - dmg
        //result[1] - crit, 1 - true, 0 - false, -1 - effect
        
        int[] result = new int[2];
        result[0] = 0;
        result[1] = -1;
        durationTimer = duration;
        StartCoolDown();
        return result;
    }




}
