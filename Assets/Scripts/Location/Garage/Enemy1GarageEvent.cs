using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1GarageEvent : WorldEnemyAction
{
    public int number;
    public override void Event()
    {
        GarageManager.enemyStatus[number] = false;
    }
}
