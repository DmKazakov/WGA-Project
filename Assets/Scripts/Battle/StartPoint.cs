using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
   
    public GameObject[] squadPoint = new GameObject[3];
    public GameObject[] enemySquadPoint = new GameObject[3];


    GameObject player;
    GameObject enemy;

    List<GameObject> units = new List<GameObject>();

    public GameObject battleManager;

    // Start is called before the first frame update
    void Start()
    {
        //расставляем юнитов
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        ToPlace();
        battleManager.GetComponent<BattleManager>().ToBattle(units);
        SelectUnit.battleManager = battleManager;
        
    }

    void ToPlace()
    {
                //расставляем отряд
        GameObject[] squad = player.GetComponent<Avatar>().squad;
        for (int i = 0; i < squad.Length; i++)
        {
            GameObject playerUnit;
            if (squad[i] != null)
            {
                
                playerUnit = Instantiate<GameObject>(squad[i], squadPoint[i].transform.position, Quaternion.identity);
                
                units.Add(playerUnit);
            }

        }
       
        //Вражеский сквад
        squad = enemy.GetComponent<Avatar>().squad;
        for (int i = 0; i < squad.Length; i++)
        {
            GameObject enemyUnit;
            if (squad[i] != null)
            {
                enemyUnit = Instantiate<GameObject>(squad[i], enemySquadPoint[i].transform.position, Quaternion.identity);
                units.Add(enemyUnit);
            }

        }
        //делаем активными и пересчитываем
        for (int i = 0; i <units.Count; i++)
        {
            units[i].SetActive(true);
            units[i].GetComponent<Unit>().Recalc();
           // print("Активирован и пересчитан: " + units[i].name);
        }
        //вырубаем аватары
        player.SetActive(false);
        enemy.SetActive(false);
    }
    



}
