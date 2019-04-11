using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustman2 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        strength = 1;
        vitality = 5;
        agility = 4;
        Recalc();
    }

    
}
