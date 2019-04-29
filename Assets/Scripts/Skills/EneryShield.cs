using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneryShield : Skills, Mate
{
    public override void Init(Unit unit)
    {
        this.unit = unit;
    
        _name = "Энергетический щит";
        cooldown = 6;
        duration = 3;
        mf = 0;

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
