using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAI : MonoBehaviour
{
    private static List<GameObject> playerUnits = new List<GameObject>();


    public static void ChoiceTarget()
    {
        playerUnits.Clear();
        SearchTarget();
        int numTarget = Random.Range(0, playerUnits.Count);
        BattleManager.target = playerUnits[numTarget];


    }
    public static void SearchTarget()
    {
        if (BattleManager.skill.GetComponent<Skills>() is Mate)
        {
            SearchMate();
        }
        else
        {
            SearchPlayers();
        }
    }
    public static void SearchPlayers()
    {
        for (int i = 0; i < BattleManager.units.Count; i++)
        {
            if (BattleManager.units[i].tag.Equals("Player"))
            {
                playerUnits.Add(BattleManager.units[i]);
            }
        }
    }
    public static void SearchMate()
    {
        for (int i = 0; i < BattleManager.units.Count; i++)
        {
            if (BattleManager.units[i].tag.Equals("Enemy"))
            {
                playerUnits.Add(BattleManager.units[i]);
            }
        }
    }






    public static void ChoiceSkill(GameObject unit)
    {
        GameObject result = null;
        while (result == null)
        {
            result = GetSkill(unit);
        }
        BattleManager.skill = result;
    }
    public static GameObject GetSkill(GameObject unit)
    {
        Unit un = unit.GetComponent<Unit>();
        int numskill = Random.Range(0, un.activeSkills.Length);
        int coold;
        if (un.activeSkills[numskill] != null)
        {
            coold = un.activeSkills[numskill].GetComponent<Skills>().cooldownTimer;
        }
        else
        {
            return null;
        }
        
        if (coold > 0)
        {
            return null;
        }
        else
        {
            return un.activeSkills[numskill];
        }
    }
}




