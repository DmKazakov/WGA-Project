using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShoot : Skills
{
    // Start is called before the first frame update
    void Start()
    {
        _name = "Двойной выстрел";
        cooldown = 4;
        duration = 1;
        mf = 0.7;

    }

    public int Effect()
    {

        return unit.Attack(mf);
    }
}
