using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosBoss : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 7; //3
        vitality = 4; //5
        agility = 2; //4
        Recalc();

    }
}
