using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosIII : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 2; //3
        vitality = 1; //5
        agility = 2; //4
        Recalc();

    }
}
