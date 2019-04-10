using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    GameObject player;
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    public static void Fight(GameObject[] player, GameObject[] enemy) {
        //весь процесс боя


    }

   
}
