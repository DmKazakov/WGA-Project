using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    // Start is called before the first frame update
    void Start()
    {

    }

   

    public void Init()
    {
        level = 1;
        freeStatPoints = 4;
        strength = 5;
        agility = 5;
        vitality = 5;

    }

  //  public void Recalc()
  //  {
  //      hitPoint = vitality * 10 + strength * 5 + level * vitality;
  //      criticalChance = 0 + (2 * agility);
   //     criticalMF = 2;
  //      criticalDMG = (int)(maxDMG * criticalMF);
  //      dodge = 0 + (int)(0.5 * agility);
  //      armor = (int)(vitality / 2);
   //     initiative = 0 + (int)(agility / 2) + (int)(strength / 2);
   //     minDMG = 1 + strength;
   //     maxDMG = 3 + strength;
   // }

    public override int Attack(double mf)
    {
        int i = Random.Range(minDMG, maxDMG);
        int result = (int)(i * mf);
        return result;
    }

    
}
