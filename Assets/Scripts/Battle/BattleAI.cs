using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAI : MonoBehaviour
{
    private static List<GameObject> playerUnits = new List<GameObject>();

    public static void SearchTarget()
    {
        for (int i = 0; i < BattleManager.units.Count; i++)
        {


            if (BattleManager.units[i].tag.Equals("Player"))
            {
                playerUnits.Add(BattleManager.units[i]);
                
            }
        }
    }
    public static void ChoiceTarget()
    {
        playerUnits.Clear();
        SearchTarget();
        int numTarget = Random.Range(0, playerUnits.Count - 1);
        BattleManager.target = playerUnits[numTarget];
        
    }
}

   
   

