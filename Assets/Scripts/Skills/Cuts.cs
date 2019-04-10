using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cuts : Skills
{
    
    // Start is called before the first frame update
    void Start()
    {
        _name = "Глубокие порезы";
        cooldown = 3;
        duration = 3;
        mf = 0.9;
       
    }

    // Update is called once per frame
    public int Effect()
    {
       
        return 0;
    }
}

