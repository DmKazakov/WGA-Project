using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnit : MonoBehaviour
{
    public bool select;
    public static GameObject battleManager;
    private void OnMouseDown()
    {
        if (select)
        {
            BattleManager.target = gameObject;
            int dmg = battleManager.GetComponent<BattleManager>().activeMenu.GetComponent<ActiveMenu>().Dmg;
            battleManager.GetComponent<BattleManager>().Fight(dmg);
            
        }
    }
}
