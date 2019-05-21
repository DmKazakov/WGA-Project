using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosV : Enemy
{
    void Start()
    {
        level = 1;
        strength = 1; //3
        vitality = 1; //5
        agility = 1; //4
        Recalc();

    }
}
