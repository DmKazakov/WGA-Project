using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosII : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 1; //3
        vitality = 1; //5
        agility = 1; //4
        Recalc();

    }
}
