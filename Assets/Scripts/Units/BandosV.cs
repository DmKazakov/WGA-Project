using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosV : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 8; //8
        vitality = 4; //4
        agility = 2; //2
        Recalc();

    }
}
