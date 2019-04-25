using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMenu : MonoBehaviour
    
{
    public GameObject battleManager;
    private int dmg;

   

    public void ToTarget() //включаем возможность выбора на юнитах
    {
        for (int i = 0; i < BattleManager.units.Count; i++)
        {
            
            if (BattleManager.units[i].tag.Equals("Enemy"))
            {
                BattleManager.units[i].GetComponent<SelectUnit>().select = true;
            }
           
        }
        
    }

    //тут прописываем получение цифры дмг в зависимости от скилла

    internal void ReplaceActiveMenu(List<GameObject> units)
    {
        gameObject.transform.position = units[0].transform.position;
        gameObject.SetActive(true);

    }
    public void MeleeAttack() {
        dmg = BattleManager.units[0].GetComponent<Unit>().Attack(1);
        print("ББ");
    }

    public void RangeAttack() {
        dmg = BattleManager.units[0].GetComponent<Unit>().RangeAttack(1);
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
