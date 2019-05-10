using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustman : Enemy
{
    // Start is called before the first frame update
   
    void Start()
    {
        level = 1;
        strength = 1; //3
        vitality = 1; //5
        agility = 1; //4
        Recalc();
        
    }


 

}
