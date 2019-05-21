using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionEnter : MonoBehaviour
{
    GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Avatar>().sceneName = SceneManager.GetActiveScene().name;      
        player.GetComponent<PlayerKeyboardController>().statrtPoint = gameObject.GetComponent<StartPointResetter>().pointName;

        gameObject.GetComponent<WorldEnemyAction>().Event();
        
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("CombatScene");
    }
}
