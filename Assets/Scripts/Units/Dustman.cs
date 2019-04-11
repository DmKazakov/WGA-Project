using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustman : Enemy
{
    // Start is called before the first frame update
   // public GameObject dustman2;
    void Start()
    {
        level = 1;
        strength = 1;
        vitality = 3;
        agility = 4;
        Recalc();
        
    }

    // Update is called once per frame
    

    public override int Attack(double mf)
    {
        int i = Random.Range(minDMG, maxDMG);
        int result = (int)(i * mf);
        return result;
    }
}
