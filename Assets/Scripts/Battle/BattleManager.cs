using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{

    // Start is called before the first frame update
    static List<GameObject> units;
    public GameObject activeMenu;
   

    internal void Fight() {
        //весь процесс боя
        if (units[0].tag.Equals("Player"))   { activeMenu.SetActive(true);}
        else { activeMenu.SetActive(false); }





    }

    internal void ToBattle(List<GameObject> units) {
        BattleManager.units = units;
        Sort();
        ReplaceActiveMenu();
        Fight();
        
    }

    internal void Sort() {
        GameObject temp;
        for (int i = 0; i < units.Count; i++)
        {
            for (int j = i + 1; j < units.Count; j++)
            {
                if (units[i].GetComponent<Unit>().initiative < units[j].GetComponent<Unit>().initiative)
                {
                    temp = units[i];
                    units[i] = units[j];
                    units[j] = temp;
                    
                }
            }
        }
    }
    internal void ReplaceActiveMenu() {
        activeMenu.transform.position = units[0].transform.position;
        //activeMenu.GetComponent<RectTransform>().anchoredPosition = units[0].transform.position;
    }
   
}
