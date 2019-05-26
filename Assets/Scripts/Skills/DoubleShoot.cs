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

    public override int[] Effect()
    {

        return null;
    }

    public override int[] Attack()
    {
        int[] result = new int[2];
        result[0] = 0;
        result[1] = 0;
        return result;
    }
}
