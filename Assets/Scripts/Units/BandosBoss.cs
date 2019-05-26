using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosBoss : Enemy
{
    public override void Init()
    {
        level = 1;
        strength = 7; //7
        vitality = 4; //4
        agility = 2; //2
        Recalc();

    }
}
