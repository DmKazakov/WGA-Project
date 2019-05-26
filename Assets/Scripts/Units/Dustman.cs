using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustman : Enemy
{
    // Start is called before the first frame update
   
 
    public override void Init()
    {
        level = 1;
        strength = 1; //4
        vitality = 1; //4
        agility = 1; //4
        Recalc();
    }




}
