using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosIII : Enemy
{
    public override void Init()
    {
        level = 2;
        strength = 6; //3
        vitality = 5; //5
        agility = 2; //4
        Recalc();

    }
}
