using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosIII : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 6; //6
        vitality = 3; //3
        agility = 2; //2
        Recalc();

    }
}
