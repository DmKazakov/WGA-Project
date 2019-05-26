using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosI : Enemy
{
   public override void Init()
    {
        level = 1;
        strength = 3; //3
        vitality = 3; //5
        agility = 5; //4
        Recalc();

    }
}
