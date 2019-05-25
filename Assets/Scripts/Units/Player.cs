using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    // Start is called before the first frame update
   
    public override void Init()
    {
        nameGame = "Безымянная";
        level = 1;
        freeStatPoints = 4;
        strength = 5;
        agility = 5;
        vitality = 5;

        armorBase = 0;
        maxDMGbase = 0;
        baseCooldown = 0;
        perkEmpty = 0;
        perkActive = new bool[3] { false, false, false };
    }

    
  

    
}
