using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skills : MonoBehaviour
{
   protected string _name;
   protected int cooldown;
   internal bool isCurrent = false;
   protected int duration;
   protected Unit unit;
   internal double mf;

    
}
