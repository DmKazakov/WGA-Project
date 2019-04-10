using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public GameObject playerPoint1;
    public GameObject[] squadPoint = new GameObject[2];


    public GameObject enemyPoint1;
    public GameObject[] enemySquadPoint = new GameObject[2];


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
        
    }

    void ToPlace()
    {
        //главный перс, назначаем спрайт, выставляем на точку
        player.GetComponent<SpriteRenderer>().sprite = player.GetComponent<Unit>().battleSprite;
        player.transform.position = playerPoint1.transform.position;
        units.Add(player);
        
        //тоже, но с тиммейтами
        GameObject[] squad = player.GetComponent<Unit>().squad;
        for (int i = 0; i < squad.Length; i++)
        {
            
            if (squad[i] != null)
            {
                squad[i].GetComponent<SpriteRenderer>().sprite = squad[i].GetComponent<Unit>().battleSprite;
                Instantiate(squad[i], squadPoint[i].transform.position, Quaternion.identity);
                units.Add(squad[i]);
            }

        }
        //главный враг, спрайт - на точку
        enemy.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<Unit>().battleSprite;
        enemy.transform.position = enemyPoint1.transform.position;
        units.Add(enemy);
        //Вражеский сквад
        squad = enemy.GetComponent<Unit>().squad;
        for (int i = 0; i < squad.Length; i++)
        {
            
            if (squad[i] != null)
            {
                squad[i].GetComponent<SpriteRenderer>().sprite = squad[i].GetComponent<Unit>().battleSprite;
                Instantiate(squad[i], enemySquadPoint[i].transform.position, Quaternion.identity);
                units.Add(squad[i]);
            }

        }

    }
    



}
