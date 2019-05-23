using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TManager : Managers
{
    public GameObject barricade;
    private void Start()
    {
        if (Story.chapter >1.2)
        {
            barricade.SetActive(false);
        }
    }
    public static void Restart() { }

}
