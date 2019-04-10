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
        vitality = 1;
        agility = 4;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override int Attack(double mf)
    {
        throw new System.NotImplementedException();
    }
}
