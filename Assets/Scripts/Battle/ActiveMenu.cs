using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMenu : MonoBehaviour
    
{
    public GameObject battleManager;
    private int dmg;

   

    public void ToTarget() {
        for (int i = 0; i < BattleManager.units.Count; i++)
        {
            print(i);
            if (BattleManager.units[i].tag.Equals("Enemy"))
            {
                BattleManager.units[i].GetComponent<SelectUnit>().select = true;
            }
        }
        print("выбор цели");
    }
    public void MeleeAttack() {
        dmg = BattleManager.units[0].GetComponent<Unit>().Attack(1);
        print("ББ");
    }

    public void RangeAttack() {
        dmg = BattleManager.units[0].GetComponent<Unit>().Attack(1);
        print("ДБ");
    }

     public int Dmg
    {
        get
        {
            return dmg;
        }
    }
}
