using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    // Start is called before the first frame update
   
    public void Init()
    {
        level = 1;
        freeStatPoints = 4;
        strength = 5;
        agility = 5;
        vitality = 5;

    }

    public override int Attack(double mf)
    {
        int i = Random.Range(minDMG, maxDMG);
        int result = (int)(i * mf);
        return result;
    }

    
}
