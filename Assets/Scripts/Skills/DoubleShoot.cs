using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShoot : Skills,Foe
{
    // Start is called before the first frame update
    public override void Init(Unit unit)
    {
        this.unit = unit;
    
        _name = "Двойной выстрел";
        cooldown = 4;
        duration = 1;
        mf = 0.7;

    }

    public int Effect()
    {

        return 0;
    }

    public override int Attack()
    {
        return 0;
    }
}
