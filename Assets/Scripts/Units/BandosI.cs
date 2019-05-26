using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosI : Enemy
{
   public override void Init()
    {
        level = 1;
        strength = 3; //3
        vitality = 3; //3
        agility = 5; //5
        Recalc();

    }
}
