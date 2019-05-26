using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosIV : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 4; //4
        vitality = 4; //4
        agility = 6; //6
        Recalc();

    }
}
