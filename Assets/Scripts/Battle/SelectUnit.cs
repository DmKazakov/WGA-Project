using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnit : MonoBehaviour
{
    public bool select;
    public static GameObject battleManager;
    private Color basicColor;
    public GameObject self;
    public GameObject target;

    private void OnMouseDown() 
    {
        if (select)
        {
            BattleManager.target = gameObject;
            
            battleManager.GetComponent<BattleManager>().Fight();
            
        }
    }

    private void Update()
    {
        if (select)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(basicColor.r, basicColor.g, basicColor.b, 0.85f+ Mathf.PingPong( Time.time / 1.0f, 0.15f));
            target.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = basicColor;
            target.SetActive(false);
        }
    }
    private void Start()
    {
        basicColor = gameObject.GetComponent<SpriteRenderer>().color;
    }
}
