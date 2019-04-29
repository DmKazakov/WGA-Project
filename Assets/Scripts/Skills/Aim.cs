using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : Skills, Mate
{
    
    public override void Init(Unit unit)
    {
        this.unit = unit;
    }

    public override int Attack()
    {
        return 0;
    }
}
