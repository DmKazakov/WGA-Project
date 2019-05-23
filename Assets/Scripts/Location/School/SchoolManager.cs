using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolManager : MonoBehaviour
{
    public static bool enemy1 = true;
    public GameObject enemy;
    public GameObject message;
    // Start is called before the first frame update
    void Start()
    {

        if (!enemy1)
        {
            enemy.SetActive(false);

        }
        if (Story.chapter==1.1 && !enemy1)
        {
            message.SetActive(true);
            Story.NextChapter();
        }
    }

    public static void Restart()
    {
        enemy1 = true;
    }

    
}
