using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustman : Enemy
{
    // Start is called before the first frame update
   
    void Start()
    {
        level = 1;
        strength = 3;
        vitality = 3;
        agility = 4;
        Recalc();
        
    }


 

}
