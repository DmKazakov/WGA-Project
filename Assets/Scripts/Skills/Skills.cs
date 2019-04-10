using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skills : MonoBehaviour
{
   protected string _name;
   protected int cooldown;
   internal bool isCurrent = false;
   protected int duration;
   public GameObject player;
   protected Unit unit;
   internal double mf;

    void Start()
    {
        unit = player.GetComponent<Unit>();
    }
    //Менеджер боя вызывает атаку у Unit с мф скила, далее вызывает эффект
}
