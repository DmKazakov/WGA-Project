using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DexChange : MonoBehaviour
{
    public GameObject player;
    public GameObject statsUp;
    public GameObject statsDown;
    Unit component;
    // Use this for initialization
    void Start()
    {
        component = player.GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (component.emptypoints < 1 || component.dextery > 9)
        {

            statsUp.SetActive(false);
        }
        else
        {
            statsUp.SetActive(true);
           

        }

        if (component.dextery < 2)
        {
            statsDown.SetActive(false);
        }
        else
        {
            statsDown.SetActive(true);
        }

    }
    public void Up()
    {

        component.dextery += 1;
        component.emptypoints -= 1;
    }
    public void Down()
    {
        component.dextery -= 1;
        component.emptypoints += 1;

    }

}
