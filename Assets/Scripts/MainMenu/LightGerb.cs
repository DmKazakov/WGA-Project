using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGerb : MonoBehaviour {

    private SpriteRenderer gerbColor;

	// Use this for initialization
	void Start () {
        gerbColor = GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {

        gerbColor.color = new Color(gerbColor.color.r, gerbColor.color.g, gerbColor.color.b, (0.6f + Mathf.PingPong(Time.time / 4.0f, 0.5f)));
    }
}
