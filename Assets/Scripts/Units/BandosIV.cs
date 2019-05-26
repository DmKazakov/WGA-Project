using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosIV : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 4; //3
        vitality = 4; //5
        agility = 6; //4
        Recalc();

    }
}
