using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : Skills, Mate
{
    
    public override void Init(Unit unit)
    {
        this.unit = unit;
        cooldown = 5;
    }

    public override int Attack()
    {
        StartCoolDown();
        return 0;
    }
}
