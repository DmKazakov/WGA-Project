using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{

    // Start is called before the first frame update
    static List<GameObject> units;
   

    internal static void Fight() {
        //весь процесс боя



    }

    internal static void ToBattle(List<GameObject> units) {
        BattleManager.units = units;
        Sort();
        Fight();
    }

    internal static void Sort() {
        GameObject temp;
        for (int i = 0; i < units.Count; i++)
        {
            for (int j = i + 1; j < units.Count; j++)
            {
                if (units[i].GetComponent<Unit>().initiative > units[j].GetComponent<Unit>().initiative)
                {
                    temp = units[i];
                    units[i] = units[j];
                    units[j] = temp;
                    
                }
            }
        }
    }
   
}
