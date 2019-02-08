using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrChange : MonoBehaviour {
    public GameObject player;
    public GameObject stats;
    Unit component;
    // Use this for initialization
    void Start () {
        component = player.GetComponent<Unit>();
    }
	
	// Update is called once per frame
public	void Update () {
        if (component.strength > 9 && stats.name == "StrUP")
        {

            this.gameObject.SetActive(false);
        }
        else if (component.strength < 2 && stats.name == "StrDown")
        {
            this.gameObject.SetActive(false);
        }
        if (component.strength > 1) { gameObject.SetActive(true); }
    }
    public void OnMouseDown()
    {
        if (component.emptypoints > 0 && stats.name == "StrUp")

        {
            component.strength += 1;
            component.emptypoints -= 1;
            print("fff");

        } 
        else if (stats.name == "StrDown")
        {
            component.strength -= 1;
            component.emptypoints += 1;
        }
    }
   
}
