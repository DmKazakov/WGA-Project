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
        SchoolManager.enemy1 = false;

        player.GetComponent<PlayerKeyboardController>().statrtPoint = gameObject.GetComponent<StartPointResetter>().pointName;
        
        
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("CombatScene");
    }
}
