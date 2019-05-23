using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageManager : Managers
{
   
    public GameObject message;
    public GameObject[] enemyes = new GameObject[3];
    public static bool[] enemyStatus = new bool[3] { true, true, true };
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < enemyes.Length; i++)
        {
            if (!enemyStatus[i])
            {
                enemyes[i].SetActive(false);
            }
        }
        if (!enemyes[2].activeSelf)
        {
            message.SetActive(true);
            Story.NextChapter();
            print(Story.chapter);
        }
    }

    public static void Restart()
    {
        for (int i = 0; i < enemyStatus.Length; i++)
        {
            enemyStatus[i] = true;
        }
    }

 


}
