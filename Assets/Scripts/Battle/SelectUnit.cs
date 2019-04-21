using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnit : MonoBehaviour
{
    public bool select;
    public static GameObject battleManager;
    private Color basicColor;

    private void OnMouseDown() 
    {
        if (select)
        {
            BattleManager.target = gameObject;
            int dmg = battleManager.GetComponent<BattleManager>().activeMenu.GetComponent<ActiveMenu>().Dmg;
            battleManager.GetComponent<BattleManager>().Fight(dmg);
            
        }
    }

    private void Update()
    {
        if (select)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(basicColor.r, basicColor.g, basicColor.b, 0.85f+ Mathf.PingPong( Time.time / 1.0f, 0.15f));
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = basicColor;
        }
    }
    private void Start()
    {
        basicColor = gameObject.GetComponent<SpriteRenderer>().color;
    }
}
