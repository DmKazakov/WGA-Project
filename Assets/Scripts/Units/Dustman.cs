using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustman : Enemy
{
    // Start is called before the first frame update
   
 
    public override void Init()
    {
        level = 1;
        strength = 4; //4
        vitality = 3; //3
        agility = 4; //4
        Recalc();
    }




}
