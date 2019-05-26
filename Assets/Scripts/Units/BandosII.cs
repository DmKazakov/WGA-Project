using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosII : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 5; //5
        vitality = 3; //3
        agility = 3; //3
        Recalc();

    }
}
