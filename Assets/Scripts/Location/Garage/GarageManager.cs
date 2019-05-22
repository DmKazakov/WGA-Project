using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageManager : MonoBehaviour
{
   
    public GameObject message;
    public GameObject[] enemyes = new GameObject[3];
    public static bool[] enemyStatus = new bool[3] { true, true, true };
    // Start is called before the first frame update
    void Start()
    {
        Story.garageManager = gameObject;

        for (int i = 0; i < enemyes.Length; i++)
        {
            if (!enemyStatus[i])
            {
                enemyes[i].SetActive(false);
            }
        }
    }

    public void Restart()
    {
        
    }


}
