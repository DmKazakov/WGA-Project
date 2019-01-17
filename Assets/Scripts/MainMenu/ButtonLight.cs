using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLight : MonoBehaviour {

    private SpriteRenderer buttonColor;
    private Color colorOn;
    private Color colorOff;
    

    public void Start()
    {
        buttonColor = GetComponent<SpriteRenderer>();
       
    }

     void OnMouseEnter()
    {
        buttonColor.color = new Color(buttonColor.color.r, buttonColor.color.g, buttonColor.color.b, 255f);
            
    }
     void OnMouseExit()
    {
        buttonColor.color = new Color(buttonColor.color.r, buttonColor.color.g, buttonColor.color.b, 0f);
    }
}
