using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolManager : MonoBehaviour
{
    public static bool enemy1 = true;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        if (!enemy1)
        {
            enemy.SetActive(false);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
