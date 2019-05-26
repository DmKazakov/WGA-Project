using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLerp : MonoBehaviour
{
    internal Vector2 enemy;
    internal Vector2 startPosition;
    private float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject.transform.position;
        startPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.position = Vector2.Lerp(transform.position, enemy, Time.deltaTime * speed);
     
 
    }
    public void ReturnPlayer()
    {
        Invoke("SetEnemyTarget", 0.5f);
    }
    private void SetEnemyTarget()
    {
        enemy = startPosition;
    }
}
