using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public GameObject playerPoint1;
    public GameObject playerPoint2;
    public GameObject playerPoint3;

    public GameObject enemyPoint1;
    public GameObject enemyPoint2;
    public GameObject enemyPoint3;

    GameObject player;
    GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //расставляем юнитов
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        player.GetComponent<SpriteRenderer>().sprite = player.GetComponent<Player>().battleSprite;
        enemy.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<Player>().battleSprite;



    }

    void ToPlace() {
        
    }

   
}
